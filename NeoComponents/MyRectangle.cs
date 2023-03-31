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
                
            }
        }
    }
}
