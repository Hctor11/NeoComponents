using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        public int BorderRadius { get => borderRadius; set => borderRadius=value; }
        public int GradientAngle { get => gradientAngle; set => gradientAngle=value; }
        public Color GradientTopColor { get => gradientTopColor; set => gradientTopColor=value; }
        public Color GradientBottomColor { get => gradientBottomColor; set => gradientBottomColor=value; }



    }
}
