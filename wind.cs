using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class wind
    {
        public int x, y, windTimer;

        //Holds image
        public Image Wind = Properties.Resources.wind;


        // blank constructor method for explosion
        public wind()
        {
        }

        // constructor method for explosion
        public wind(int _x, int _y, Image _Wind, int _windTimer)
        {
            x = _x;
            y = _y;
            Wind = _Wind;
            windTimer = _windTimer;
        }
    }
}
