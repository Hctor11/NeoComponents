using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoComponents
{
    internal class MyRectangle
    {
        private float x, y, width, height, radius;
        private Point location;
        private GraphicsPath graphicsPath;

        public MyRectangle(float x, float y, float width, float height, float radius, Point location, GraphicsPath graphicsPath)
        {
            this.x=x;
            this.y=y;
            this.width=width;
            this.height=height;
            this.radius=radius;
            this.location=location;
            this.graphicsPath=graphicsPath;

            if (radius <= 0f)
            {
                graphicsPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else 
            {
                graphicsPath.AddArc(new RectangleF(x, y, 2f * radius, 2f * radius), 180f, 90f );
                graphicsPath.AddArc(new RectangleF(width - (2f * radius) - 1f, x, 2f * radius, 2f * radius), 270f, 90f);
                graphicsPath.AddArc(new RectangleF(width - (2f * radius) - 1f, height - (2f * radius) - 1f, 2f * radius, 2f * radius), 0f, 90f);
                graphicsPath.AddArc(new RectangleF(x, height - (2f * radius) - 1f, 2f * radius, 2f * radius), 90f, 90f);
                graphicsPath.CloseAllFigures();
            }
        }

        public GraphicsPath path => graphicsPath;
        public RectangleF Rect => new RectangleF(x, y, width, height);
        public float Radius
        {

            get => Radius;
            set => Radius = value;

        }
    }
}
