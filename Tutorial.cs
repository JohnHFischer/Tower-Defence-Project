//John Fischer
//Turtle Tower Defence game
//2014 June
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tutorial : Form
    {       
        string choice = "null";

        public Tutorial()
        {
            InitializeComponent();
            Method();   
        }

        private void Method()
        {
            if (choice == "Tower 1")
            {
                infoScreen.Visible = true;
                infoScreen.Text = "Tower 1 Automatically aims at a turtle and fires at it";
            }
            if (choice == "Tower 2")
            {
                infoScreen.Visible = true;
                infoScreen.Text = "Tower 2 does not aim but instead it shoots 8 shots in a circle";
            }
            if (choice == "Tower 3")
            {
                infoScreen.Visible = true;
                infoScreen.Text = "The Hut does not attack Turtles or directly impact them but the Hut gives you access to the shop where your can purchase upgrades for your Towers.";
            }
            if (choice == "Special")
            {
                infoScreen.Visible = true;
                infoScreen.Text = "Lightning is a special ability being only avalible if unlocked through the shop. Lightning is expensive but kills all the Turtles on the screen.";
            }
            if (choice == "Turtle")
            {
                infoScreen.Visible = true;
                infoScreen.Text = "In the game Turtle Defence your goal is to kill the Turtles before they get through the map. To do this you need to place towers by clicking on them and placing them!";
            }
            if (choice == "null")
            {
                infoScreen.Visible = false;
                returnLabel.Visible = true;
            }
            else
            {
                infoScreen.Text = infoScreen.Text + "\n \n (Click to Return)";
                returnLabel.Visible = false;
            }
            this.Refresh();


        }

        private void tower1Box_Click(object sender, EventArgs e)
        {
            choice = "Tower 1";
            Method();
        }

        private void tower2Box_Click(object sender, EventArgs e)
        {
            choice = "Tower 2";
            Method();
        }

        private void tower3Box_Click(object sender, EventArgs e)
        {
            choice = "Tower 3";
            Method();
        }

        private void specialBox_Click(object sender, EventArgs e)
        {
            choice = "Special";
            Method();
        }

        private void turtleBox_Click(object sender, EventArgs e)
        {
            choice = "Turtle";
            Method();
        }

        private void infoScreen_Click(object sender, EventArgs e)
        {
            choice = "null";
            Method();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
