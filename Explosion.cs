using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Explosion
    {
        public int x, y, explosionTimer;

        //Holds image
        public Image boom = Properties.Resources.explosion;
        

        // blank constructor method for explosion
        public Explosion()
        {
        }

        // constructor method for explosion
        public Explosion(int _x, int _y, Image _boom, int _explosionTimer)
        {
            x = _x;
            y = _y;
            boom = _boom;
            explosionTimer = _explosionTimer;
        }  
    }
}


