using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoComponents
{
    public class NeoButton : Button
    {
        // atributos
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.DodgerBlue;

        // Propiedades
        public int BorderSize
        {
            get => borderSize;
            set 
            { 
                borderSize = value;
                Invalidate();
            }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get => BackColor;
            set => BackColor = value;

        }

        public Color TextColor
        {
            get => ForeColor;
            set => ForeColor = value;

        }

        // Constructor

        public NeoButton()
        {
            Size = new Size(200, 100);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
        }

        // Metodos

        private GraphicsPath GetFigurePath(RectangleF rec, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width - radius, rec.Y, radius, radius, 270, 90);
            path.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF recSurf = new RectangleF(0, 0, Width, Height);
            RectangleF recBorder = new RectangleF(1,1, Width - 0.5f, Height -1);

            if (borderRadius > 1)
            {
                using (GraphicsPath pathSurf = GetFigurePath(recSurf, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(recBorder, borderRadius - 1f))
                using (Pen penSurf = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(pathSurf);
                    pevent.Graphics.DrawPath(penBorder, pathSurf);

                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath((Pen)penBorder, pathBorder);
                    }
                }
            }
            else 
            {
                Region = new Region(recSurf);
                
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0, Width -1, Height -1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                Invalidate();
            }
        }
    }
}
