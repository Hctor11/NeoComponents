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

        // constructor
        public PanelRadius() {
            this.BackColor = Color.White;
        }
    }
}
