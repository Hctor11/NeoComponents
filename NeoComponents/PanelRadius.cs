using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace NeoComponents
{
    public class PanelRadius : Panel
    {
        // Campos
        private int borderRadius = 30;
        private int gradientAngle = 90;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        // Constructor
        public PanelRadius() {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);
        }

        // Propiedades
        public int BorderRadius { 
            get => borderRadius;
            set { 
                borderRadius=value;
                this.Invalidate();
            }
        }
        public int GradientAngle {
            get => gradientAngle;
            set { 
                gradientAngle=value;
                this.Invalidate();
            } 
        }
        public Color GradientTopColor { 
            get => gradientTopColor;
            set { 
                gradientTopColor=value;
                this.Invalidate();
            }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { 
                gradientBottomColor=value;
                this.Invalidate();
            }
        }

        // Metodos
        private GraphicsPath GetNeoPath(RectangleF rectangle, float radius) 
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;

        }

        // Metodos overriden
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradiente
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush NeoBrush = new LinearGradientBrush(
                this.ClientRectangle,
                this.GradientTopColor,
                this.gradientBottomColor,
                this.gradientAngle);

            Graphics NeoGraphics = e.Graphics;
            NeoGraphics.FillRectangle(NeoBrush, ClientRectangle);

            // Panel Radius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetNeoPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {

                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);

                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }

    }
}
