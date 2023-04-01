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
    public class NeoTextBox : Control
    {
        // Campos
        private int borderSize = 0;
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
            backColor = Color.White;
            Font = new Font("Century Gothic", 12F);
            DoubleBuffered = true;
        }

        // Propiedades
        public char PasswordChar
        {
            get { return textBox.PasswordChar; }
            set 
            { 
                textBox.PasswordChar = value; 
                base.Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get { return textBox.UseSystemPasswordChar; }
            set
            {
                textBox.UseSystemPasswordChar = value;
                base.Invalidate();
            }
        }

        public Color NeoBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                if (backColor != Color.Transparent) 
                {
                    textBox.BackColor = backColor;
                    base.Invalidate();
                }
            }
        }

        public override Color BackColor 
        { 
            get => base.BackColor ; 
            set => base.BackColor= Color.Transparent; 
        }

        public Color BorderColor
        {
            get => borderColor;
            set 
            { 
                borderColor=value;
                Invalidate();
            }
        }

        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor=value;
                Invalidate();
            }
        }

        public int Radius
        {
            get => radius;
            set 
            {
                radius=value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize=value;
                Invalidate();
            }
        }

        public string PlaceHolder
        { 
            get => placeholder;
            set
            {
                placeholder=value;
                if (Text == placeholder || Text == string.Empty)
                {
                    Text = placeholder;
                    textBox.ForeColor = placeholderColor;
                }
                else
                {
                    textBox.ForeColor = mColor;
                }
                Invalidate();
            }
        }

        // Metodos
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textBox.Font = Font;
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textBox.ForeColor = mColor = ForeColor;
            base.Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textBox.Text = Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            shape = new MyRectangle((float)base.Width, (float)base.Height, (float)radius/2, 0f, 0f).path;
            innerRectangle = new MyRectangle(base.Width - 0.5f, base.Height-0.5f, (float)radius/2, 0.5f, 0.5f).path;
            Pen pen = new Pen(BorderColor, BorderSize);

            if (textBox.Height >= (base.Height - 4))
                base.Height = textBox.Height + 4;

            textBox.Location = new Point(Radius - 5, (base.Height/2)-(textBox.Font.Height/2));
            textBox.Width = base.Width - ((int)(radius*1.5));
            e.Graphics.SmoothingMode = (SmoothingMode.HighQuality);
            e.Graphics.DrawPath(pen, shape);

            using (SolidBrush brush = new SolidBrush(backColor)) 
            { 
                e.Graphics.FillPath((Brush)brush, innerRectangle);
            }

            NeoTranslate.MakeTransparent(this, e.Graphics);

            base.OnPaint(e);

        }
    }
}
