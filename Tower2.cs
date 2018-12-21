using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Tower2
    {

        public int x, y, sprite, tower2Timer;
        public float degree;

        //Holds tower images
        public Image tower2Image = Properties.Resources.tower2;
        
        // blank constructor method for character
        public Tower2()
        {
        }


        // constructor method for tower1
        public Tower2(int _x, int _y, Image _tower2Image, int _tower2Timer, float _degree)
        {
            x = _x;
            y = _y;                  
            tower2Image = _tower2Image;
            tower2Timer = _tower2Timer;
            degree = _degree;
        }
    }
}
