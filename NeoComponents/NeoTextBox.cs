﻿using System;
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
    }
}
