using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Shooting
    {
        public int x, y, speed, sprite, targetx, targety, direction, startx, starty, vertical, horizontal;
        
        //Holds Image
        public Image bulletImages = Properties.Resources.shot;
        //Blank constructor method
        public Shooting()
        {
        }

        //constructor method for shooting
        public Shooting(int _x, int _y, int _speed, Image _bulletImages, int _sprite, int _direction, int _targetx, int _targety, int _startx, int _starty, int _horizontal, int _vertical)
        {
            x = _x;
            y = _y;
            speed = _speed;
            bulletImages = _bulletImages;            
            sprite = _sprite;
            direction = _direction;
            targetx = _targetx;
            targety = _targety;
            startx = _startx;
            starty = _starty;
            vertical = _vertical;
            horizontal = _horizontal;
        }

        /// <summary>
        /// Takes the towers designated direction and moves it accordingly
        /// </summary>
        /// <param name="shot">Object</param>
        /// <param name="d">Direction of the shot</param>
        /// <param name="f">Form1</param>
        public void Shoot(Shooting shot, int d, Form f)
        {       
            // move shot down  
            if (direction == 3)
            {
                shot.y = shot.y - shot.speed;
            }
            //move shot up
            else if (direction == 0)
            {
                shot.y = shot.y + shot.speed;
            }
            //move shot left
            else if (direction == 1)
            {
                shot.x = shot.x - shot.speed;
            }
            //move shot right
            else if (direction == 2)
            {
                shot.x = shot.x + shot.speed;
            }
            //move shot up and left
            else if (direction == 4)
            {
                shot.x = shot.x - shot.speed;
                shot.y = shot.y - shot.speed;
            }
                //move shot up and right
            else if (direction == 5)
            {
                shot.x = shot.x + shot.speed;
                shot.y = shot.y - shot.speed;
            }
                //move shot down and left
            else if (direction == 6)
            {
                shot.x = shot.x - shot.speed;
                shot.y = shot.y + shot.speed;
            }
                //move shot down and right
            else if (direction == 7)
            {
                shot.x = shot.x + shot.speed;
                shot.y = shot.y + shot.speed;
            }
        }

        //Bullet collision
        public bool Collision(Character c, Shooting shot)
        {
            // determine the distance between two character objects based on their centres
            double distance = Math.Sqrt(Math.Pow(shot.x - c.x, 2) + (Math.Pow(shot.y - c.y, 2)));

            if (distance < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}