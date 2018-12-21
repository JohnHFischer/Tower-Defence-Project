using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Tower1
    {
        public int x, y, tower1Timer, targetX, targetY, rotationSpeed;
        public float degree;
        
        //Holds tower images    
        public Bitmap tower1Images;
        public Image shootImages = Properties.Resources.shot;

        // blank constructor method for character
        public Tower1()
        {
        }

        // constructor method for tower1
        public Tower1(int _x, int _y, Bitmap _tower1Images, int _tower1Timer, int _targetX, int _targetY, float _degree, int _rotationSpeed)
        {
            x = _x;
            y = _y;
            tower1Images = _tower1Images;       
            tower1Timer = _tower1Timer;
            targetX = _targetX;
            targetY = _targetY;
            degree = _degree;
            rotationSpeed = _rotationSpeed;         
        }
    }
}
