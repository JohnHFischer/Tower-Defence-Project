using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public class Tower3
    {

        public int x, y, sprite;

        //Holds tower images
        public Image tower3Image = Properties.Resources.tower3;

        // blank constructor method for character
        public Tower3()
        {
        }


        // constructor method for tower1
        public Tower3(int _x, int _y, Image _tower3Image)
        {
            x = _x;
            y = _y;
            tower3Image = _tower3Image;
            
        }
    }
}
