using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoComponents
{
    public class NeoTextBox : Control
    {
        // Campos
        private int bordeSize = 0;
        private int radius = 50;
        private Color borderColor = Color.Transparent;
        private Color backColor;
        private Color placeholderColor = Color.Gray;
        private Color mColor = Color.Transparent;
        private string placeholder;
        private GraphicsPath shape;
        private GraphicsPath innerRectangle;
        public TextBox textBox = new TextBox();

        // Constructor
        public NeoTextBox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);

            base.Controls.Add(textBox);
            base.Size = new Size(200, 50);
            textBox.Parent = this;
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = backColor;
            BackColor = Color.Transparent;

        }
    }
}
