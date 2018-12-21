using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Player
    {
        public string name;
        public string highscore;

        public Player()
        {            
        }

        public Player(string _name, string _highscore)
        {
            name = _name;
            highscore = _highscore;
        }

    }
}
