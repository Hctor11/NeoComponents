using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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


    }
}
