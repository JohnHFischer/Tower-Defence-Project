using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    /// <summary>
    /// All characters objects for this program are derived from this class
    /// </summary>
    public class Character
    {
        public int x, y, speed, direction, sprite, lives;
       

        // array to hold all character images
        public Image[] charImages = new Image[4];
        
        // blank constructor method for character
        public Character()
        {
            
        }


        // constructor method for character
        public Character(int _x, int _y, int _speed, Image[] _charImages, int _direction, int _sprite, int _lives)
        {
            x = _x;
            y = _y;
            speed = _speed;
            charImages = _charImages;
            direction = _direction;
            sprite = _sprite;
            lives = _lives;       
        }

        /// <summary>
        /// Allows the character to move around the screen
        /// </summary>
        /// <param name="c">character object to be moved</param>
        /// <param name="d">direction to be moved</param>
        /// <param name="f">form the characters are drawn to</param>
        public void Move(Character c, string d, Form f)
        {
            // set direction image base on:
            // 0 = down, 1 = left, 2 = right, 3 = up
            switch (d)
            {
                case "up":
                    direction = 3;
                    break;
                case "down":
                    direction = 0;
                    break;
                case "left":
                    direction = 1;
                    break;
                case "right":
                    direction = 2;
                    break;                
                default:
                    break;
            }

            

            if (direction == 3)
            {
                c.y -= c.speed;
                sprite = 1;
            }
            else if (direction == 0)
            {
                c.y += c.speed;
                sprite = 0;
            }
            else if (direction == 1)
            {
                c.x -= c.speed;
                sprite = 3;
            }
            else if (direction == 2)
            {
                c.x += c.speed;
                sprite = 2;
            }
           
        }
    }
}

