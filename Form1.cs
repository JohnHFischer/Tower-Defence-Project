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
using System.Threading;
using System.Media;
using System.Xml;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Current page being shown
        int currentPage;
        //Triggers when the user runs out of lives
        Boolean gameOver = false;      
        //Holds the users Final score
        string scoreString;
        //Creates a random number for special
        Random randNum = new Random();
        //speed of shots
        int shotSpeed;
        //number of lives that the monsters have
        int monsterLives = 1;
        //holds random number
        int rand;
        //Spawn rate of the turtles
        int spawnRate;
        //Delay between each spawn
        int tempSeconds;       
        //Monsters speed
        int monsterSpeed;
        //Gold
        int totalGold;
        //Valie of eliminating a turtle
        int lootValue = 125;
        //Total time in seconds
        int totalTime;
        //The amount of time in between tower 1 shots
        int timer1;
        //The amount of time in between tower 2 shots
        int timer2;
        //Users score
        int totalScore;
        //Users lives
        int totalLives;
        //Wave number
        int waveNumber = 1;
        //Mouses x value
        int mouseX;
        //Mouses y value
        int mouseY;
        //Cost of tower 1
        int tower1Cost = 500;
        //Cost of tower 2
        int tower2Cost = 750;
        //Cost of tower 3
        int tower3Cost = 1000;
        //Records the total number of turtles spawned
        int totalSpawns;
        //Increases at a rate of ++ used by other ints
        int timer;
        //Tower 1 shot delay value
        int tower1ShotDelay = 80;
        //Tower 2 shot delay value
        int tower2ShotDelay = 180;
        //Tower 1 upgrade cost
        int tower1UpgradeCost = 5000;
        //Tower 2 upgrade cost
        int tower2UpgradeCost = 5000;
        //Tower 3 upgrade cost
        int tower3UpgradeCost = 20000;
        //Number of tower 1 upgrades
        int tower1UpgradeClick = 0;
        //Number of tower 2 upgrades
        int tower2UpgradeClick = 0;
        //Holds the time left on the special cooldown
        int specialCooldown;
        //Used to find the specialCooldown
        int specialTimer;
        //Holds the amount of time that the animation will last for
        int specialPaintTimer;
        int wave = 1;
        //Cost of using the special Ability
        int specialCost = 5000;       
        int waveToSpawn;
        Boolean waveReady = true;
        Boolean waveGo = false;
        Boolean tower3UpgradeClick = false;     
        Boolean rKeyDown = false;        
        //Text
        String introText = "The Turtles are Attacking! \n \nDo not let them through!";
        //Text
        String instructionsText = "Place Towers to destroy the Turtles. \n \n Monkeys: Monkeys face the Turtles \n and fire in that direction. \n \n Birds: Birds fire 8 Shots in a circle \n but fire slower than Monkeys. \n \n Hut: The Hut doesn't shoot or kill Turtles but it does \n improve your towers and offers upgrades.";  
        //Turtle image array
        Image[] enemyImages = { Properties.Resources.turtleDown,
                                   Properties.Resources.turtleUp,
                                   Properties.Resources.turtleRight,
                                   Properties.Resources.turtleLeft};
        //Images and Bitmaps
        Bitmap tower1Images = Properties.Resources.tower1bitmapFIXEDSIZEandcolour;
        Bitmap tower1hand = Properties.Resources.tower1bitmaphand;
        Bitmap tower2Image = Properties.Resources.owl80by80;
        Image wind = Properties.Resources.windBlack;
        Image startWave = Properties.Resources.startButtonWorking;
        Image overrun = Properties.Resources.very;
        Image boom = Properties.Resources.explosion;
        Image lightning = Properties.Resources.lightning;
        Image shopBack = Properties.Resources.shopBack;
        Image instructionBack = Properties.Resources.instructionBack2;
        Image menuBack = Properties.Resources.menuBack;
        Image startBackround = Properties.Resources.startBackround;
        Image store = Properties.Resources.store;
        Image nope = Properties.Resources.nopeworks;
        Image destroy = Properties.Resources.destroy;               
        Image tower3Image = Properties.Resources.tower3;
        Image shootImages = Properties.Resources.shot;
        Image winner = Properties.Resources.winnerfix;
        //List of highscores
        public static List<Player> play = new List<Player>();
        //List of turtles
        List<Character> enemies = new List<Character>();
        //List of tower1's
        List<Tower1> tower1 = new List<Tower1>();
        //List of tower2's
        List<Tower2> tower2 = new List<Tower2>();
        //List of tower3's
        List<Tower3> tower3 = new List<Tower3>();
        //List of shots
        List<Shooting> shots = new List<Shooting>();
        //List of explosions
        List<Explosion> explosion = new List<Explosion>();
        //List of wind's
        List<wind> windlist = new List<wind>();    
                    
        Boolean escKeyDown = false; 
        Boolean tower1Click = false;        
        Boolean tower2Click = false;
        Boolean tower3Click = false;
        Boolean specialClick = false;
        Boolean destroyClick = false;

        Boolean storeUp = false;

        Boolean specialOn = false;
        Boolean lightingOn = false;

        Boolean upgradesAvailable = false;      

        double dist;
        //Calculates the distance betweent the tower1 and turtle
        int distan;
        //number of ticks that are expected for each shot to reach its target
        int ticks;
        public Form1()
        {
            InitializeComponent();
            //Runs the Splashscreen
            SplashScreen();
            //Loads highscore database
            LoadDB();
            //Runs the Reset Method
            Reset();            
        }

        #region keyup/down

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {               
                case Keys.Escape:
                    escKeyDown = true;                    
                    if (currentPage == 0)
                    {
                        this.Close();
                    }
                    if (currentPage == 2 || currentPage == 3 || currentPage == 5)
                    {
                        gameTimer.Start();
                        currentPage = 6;
                    }
                    this.Refresh();
                    break; 
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {               
                case Keys.Escape:
                    escKeyDown = false;
                    break;
                case Keys.R:
                    rKeyDown = false;
                    break;
                default:
                    break;
            }

        }

        #endregion

        private void gameTimer_Tick(object sender, EventArgs e)
        {   
            //tracks the mouse
            mouseX = MousePosition.X - this.Location.X;
            mouseY = MousePosition.Y - this.Location.Y;

            //gets new rand
            rand = randNum.Next(1, 7);
            
            #region Gives the tower1 a target and get it to face it
           
            //Loops through all the tower 1's
            for (int i = 0; i < tower1.Count(); i++)
            {
                //Gives the tower1 a target and get it to face it                 
                if (enemies.Count() != 0)
                {
                    tower1[i].targetX = enemies[0].x;
                    tower1[i].targetY = enemies[0].y;
                }                
                //the x difference between the two points
                int a = tower1[i].x - tower1[i].targetX;
                //the y difference between the two points
                int b = tower1[i].y - tower1[i].targetY;
                //the lenght of the hyp
                double c = Math.Abs(Math.Sqrt((a * a) + (b * b)));

                //if the cooldown timer is less then 1/8 it changes the image to one of the monkey shooting
                if (tower1[i].tower1Timer <= timer1 / 8)
                {
                    //when the target is down and left of the tower
                    if (tower1[i].x > tower1[i].targetX && tower1[i].y < tower1[i].targetY || tower1[i].x < tower1[i].targetX && tower1[i].y < tower1[i].targetY)
                    {
                        //does sin-1 (x difference / the hyp)
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].tower1Images = rotateImage(tower1hand, tower1[i].degree);
                    }
                    //when the target is up and right of the tower or the target is down and right of the tower
                    if (tower1[i].x < tower1[i].targetX && tower1[i].y > tower1[i].targetY)
                    {
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].degree = (tower1[i].degree * -1) + 180;
                        tower1[i].tower1Images = rotateImage(tower1hand, tower1[i].degree);
                    }
                    //when the target is up and left of the tower
                    if (tower1[i].x > tower1[i].targetX && tower1[i].y > tower1[i].targetY)
                    {
                        tower1[i].degree = tower1[i].degree + 90;
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].degree = 180 - tower1[i].degree;
                        tower1[i].tower1Images = rotateImage(tower1hand, tower1[i].degree);

                    }
                }
                //if the cooldown timer is more than 1/8 it changes the image to one of a static
                if (tower1[i].tower1Timer > timer1 / 8)
                {
                    //when the target is down and left of the tower
                    if (tower1[i].x > tower1[i].targetX && tower1[i].y < tower1[i].targetY || tower1[i].x < tower1[i].targetX && tower1[i].y < tower1[i].targetY)
                    {
                        //does sin-1 (x difference / the hyp)
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].tower1Images = rotateImage(tower1Images, tower1[i].degree);
                    }
                    //when the target is up and right of the tower or the target is down and right of the tower
                    if (tower1[i].x < tower1[i].targetX && tower1[i].y > tower1[i].targetY)
                    {
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].degree = (tower1[i].degree * -1) + 180;
                        tower1[i].tower1Images = rotateImage(tower1Images, tower1[i].degree);
                    }
                    //when the target is up and left of the tower
                    if (tower1[i].x > tower1[i].targetX && tower1[i].y > tower1[i].targetY)
                    {
                        tower1[i].degree = tower1[i].degree + 90;
                        tower1[i].degree = Convert.ToSingle((Math.Asin(a / c)) * (180 / Math.PI));
                        tower1[i].degree = 180 - tower1[i].degree;
                        tower1[i].tower1Images = rotateImage(tower1Images, tower1[i].degree);
                    }
                }
            }
            #endregion

            #region special cooldown timer
            //cooldown is decreased over time
            specialTimer--;
            specialCooldown = specialTimer / 32;
            //doesn't let the cooldown be lower than 0
            if (specialCooldown < 0)
            {
                specialCooldown = 0;
            }
            #endregion

            #region what special actually does
            //Triggers lighting, resets the special cooldown and ajusts totalGold
            if (specialClick == true)
            {
                SoundPlayer player2 = new SoundPlayer(Properties.Resources.lightning1);
                player2.Play();
                specialPaintTimer = 0;
                lightingOn = true;
                specialClick = false;
                specialTimer = 180 * 32;
                specialOn = true;
                totalGold = totalGold - specialCost;
            }
            //removes all Turtles from the screen
            if (specialOn == true)
            {                
                enemies.Clear();
                specialOn = false;
            }           
            #endregion

            #region triggers the lighting
            //lighting squence           
            if (lightingOn == true)
            {
                specialPaintTimer++;
            }
            if (specialPaintTimer >= 20)
            {
                lightingOn = false;
            }
            #endregion            

            #region tower shooting
            
            //calculates timer1 which is tower 1's shot delay
            timer1 = tower1ShotDelay / (tower1UpgradeClick + 1);

            if (enemies.Count() != 0)
            {
                //tower 1 shooting
                for (int i = 0; i < tower1.Count(); i++)
                {
                    tower1[i].tower1Timer++;

                    if (tower1[i].tower1Timer >= timer1)
                    {
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.tower11);
                        player1.Play();

                        //shoots
                        Shooting shot = new Shooting(tower1[i].x, tower1[i].y, shotSpeed, shootImages, 0, 0, tower1[i].targetX, tower1[i].targetY, tower1[i].x, tower1[i].y, 0, 0);
                        shots.Add(shot);

                        targeting();

                        tower1[i].tower1Timer = 0;
                    }
                }
            }
            for (int i = 0; i < shots.Count(); i++)
            {
                //Gives the shot a target and get it to face it                 
                if (enemies.Count() != 0)
                {
                    if (shots[i].targety != 0)
                    {
                        shots[i].targetx = enemies[0].x - 25;
                        shots[i].targety = enemies[0].y - 25;
                    }
                }
            }
            //calculates timer2 which is tower 2's shot delay
            timer2 = tower2ShotDelay / (tower2UpgradeClick + 1);

            //tower 2 shooting
            if (enemies.Count() != 0)
            {
                for (int i = 0; i < tower2.Count(); i++)
                {
                    tower2[i].tower2Timer++;

                    if (tower2[i].tower2Timer >= timer2)
                    {
                        SoundPlayer player = new SoundPlayer(Properties.Resources.tower2fix);
                        player.Play();

                        for (int d = 0; d < 8; d++)
                        {
                            //shoots in all 8 directions
                            Shooting shot = new Shooting(tower2[i].x - 5, tower2[i].y - 5, 10, shootImages, 0, d, 0, 0, tower2[i].x, tower2[i].y, 0, 0);
                            shots.Add(shot);
                        }
                        tower2[i].tower2Timer = 0;
                    }
                }
            }
            //spins tower 2 after it shoots
            for (int i = 0; i < tower2.Count(); i++)
            {
                if (tower2[i].tower2Timer <= timer2 / 20)
                {
                    tower2[i].degree = tower2[i].degree + 36;
                    tower2[i].tower2Image = rotateImage(tower2Image, tower2[i].degree);
                }
                if (enemies.Count() == 0)
                {
                    tower2[i].degree = 0;
                }
            }
            //loops movment of the shots
            for (int i = 0; i < shots.Count(); i++)
            {
                if (shots[i].targety != 0)
                { 
                    shots[i].x = shots[i].x - shots[i].horizontal;
                    shots[i].y = shots[i].y - shots[i].vertical;                     
                }
                if (shots[i].targety == 0)
                {
                    shots[i].Shoot(shots[i], shots[i].direction, this);
                }
            }                    
            #endregion

            #region spawns monsters in waves

            tempSeconds++;
            //spawns Turtles
            if (tempSeconds >= spawnRate && waveGo == true)
            {
                Character c = new Character(750, 50, monsterSpeed, enemyImages, 0, 0, monsterLives);
                enemies.Add(c);
                totalSpawns++;
                tempSeconds = 0;
                wave++;
            }

            //Determines how many Turtles will spawn in the wave
            waveToSpawn = waveNumber * waveNumber + 5;

            //Maxes the total number of Turtles each wave to 100
            if (waveToSpawn >= 100)
            {
                waveToSpawn = 100;
            }          
            //detects if the total number of Turtles to be spawned have been spawned then end the wave
            if (wave >= waveToSpawn)
            {  
                wave = 0;
                waveGo = false;                
            }
            //Detects if the wave is over
            if (enemies.Count() == 0 && waveGo == false)
            {
                waveReady = true;
            }

            #endregion           

            #region Direction of turtles path
            //Turtles turning logic
            for (int i = 0; i < enemies.Count(); i++)
            {
                if (enemies[i].x >= 150 && enemies[i].x <= 450 && enemies[i].y == 650 || enemies[i].x >= 450 && enemies[i].x <= 750 && enemies[i].y == 450)
                {
                    enemies[i].Move(enemies[i], "right", this);
                }
                if (enemies[i].x >= 0 && enemies[i].x <= 750 && enemies[i].y == 250)
                {
                    enemies[i].Move(enemies[i], "left", this);
                }
                if (enemies[i].x == 750 && enemies[i].y <= 250 || enemies[i].x == 150 && enemies[i].y >= 250 && enemies[i].y <= 650 || enemies[i].x == 750 && enemies[i].y >= 450)
                {
                    enemies[i].Move(enemies[i], "down", this);
                }
                if (enemies[i].x == 450 && enemies[i].y >= 450)
                {
                    enemies[i].Move(enemies[i], "up", this);
                }
            }
            #endregion

            #region time
            timer++;

            totalTime = timer / 32;
            #endregion

            #region de-selects tower if not enough money

            if (totalGold < tower1Cost)
            {
                tower1Click = false;
            }
            if (totalGold < tower2Cost)
            {
                tower2Click = false;
            }
            if (totalGold < tower3Cost)
            {
                tower3Click = false;
            }
            #endregion

            #region removes after collision and displays explosion

            for (int i = 0; i < shots.Count(); i++)
            {
                for (int j = 0; j < enemies.Count(); j++)
                {
                    if (shots[i].Collision(enemies[j], shots[i]))
                    {
                        if (enemies[j].lives == 1)
                        {
                            SoundPlayer player4 = new SoundPlayer(Properties.Resources.bang);
                            player4.Play();
                            Explosion ex = new Explosion(enemies[j].x, enemies[j].y, boom, 10);
                            explosion.Add(ex);
                            shots.RemoveAt(i);
                            enemies.RemoveAt(j);
                            totalGold = totalGold + lootValue;
                            totalScore = totalScore + 10;

                            break;
                        }

                        if (enemies[j].lives != 1)
                        {

                            SoundPlayer player3 = new SoundPlayer(Properties.Resources.wind1);
                            player3.Play();
                            wind wd = new wind(enemies[j].x, enemies[j].y, wind, 10);
                            windlist.Add(wd);
                            enemies[j].lives--;
                            shots.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            //removes explosions after they are finished
            for (int i = 0; i < explosion.Count(); i++)
            {
                explosion[i].explosionTimer--;
                if (explosion[i].explosionTimer == 0)
                {
                    explosion.RemoveAt(i);
                }
            }
            //removes explosions after they are finished
            for (int i = 0; i < windlist.Count(); i++)
            {
                windlist[i].windTimer--;
                if (windlist[i].windTimer == 0)
                {
                    windlist.RemoveAt(i);
                }
            }
            #endregion

            #region removes shots that fall off screen and turtles that have finished
            for (int i = 0; i < shots.Count(); i++)
            {
                //removes shots that hit no turtle
                if (shots[i].x > this.Width - 120 || shots[i].x <= 0 || shots[i].y > this.Height - 25 || shots[i].y < 100)
                {
                    shots.RemoveAt(i);
                }
            }
            //removes finished trutles
            for (int i = 0; i < enemies.Count(); i++)
            {
                if (enemies[i].y > this.Height)
                {
                    enemies.RemoveAt(i);
                    totalLives = totalLives - 1;

                }
            }
            #endregion

            #region Marks tower 3 as off limits if one is placed
            if (tower3.Count() != 0)
            {
                tower3Click = false;
                shotSpeed = 25;
                upgradesAvailable = true;
                storeUp = true;
            }
            else
            {
                storeUp = false;
                shotSpeed = 5;
            }
            #endregion

            //ends game goes to highscore page
            if (totalLives == 0)
            {
                gameOver = true;
                currentPage = 1;
                gameTimer.Stop();
            }

            //esc  press for deselect
            if (currentPage == 6 && escKeyDown == true)
            {
                tower1Click = false;
                tower2Click = false;
                tower3Click = false;
                destroyClick = false;
            }  
            this.Refresh();
        }       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = e.Graphics;

            #region Pens and such

            Pen gridPen = new Pen(Color.Gray, 1);
            Pen trackPen = new Pen(Color.SaddleBrown, 100);
            Pen menuPen = new Pen(Color.Silver, 100);
            Pen menuPen2 = new Pen(Color.LightGray, 10);
            Pen menuPen3 = new Pen(Color.LightGray, 6);
            Pen towerPen = new Pen(Color.Black, 2);
            Pen tower3Pen = new Pen(Color.Black, 10);
            SolidBrush grassBrush = new SolidBrush(Color.Green);
            SolidBrush scoreBrush = new SolidBrush(Color.Gold);
            SolidBrush menuBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font menuFont = new Font("Georgia", 32);
            Font veryStartFont = new Font("Motorwerk", 72);
            Font menuWordsFont = new Font("Ariel", 12);
            Font menuButtonFont = new Font("Ariel", 18);
            SolidBrush hoverBrush = new SolidBrush(Color.LightGreen);
            SolidBrush startBrush = new SolidBrush(Color.SaddleBrown);
            SolidBrush tower1NotBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));
            SolidBrush startBackroundBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            SolidBrush startBackroundBrushWhite = new SolidBrush(Color.FromArgb(200, 255, 255, 255));
            SolidBrush tower3Brush = new SolidBrush(Color.FromArgb(150, 255, 0, 0));
            SolidBrush towerBrush = new SolidBrush(Color.Red);
            SolidBrush dartBrush = new SolidBrush(Color.Red);
            SolidBrush hideBrush = new SolidBrush(Color.LightGray);            
            SolidBrush hide2Brush = new SolidBrush(Color.FromArgb(189, 189, 189));
            Pen hidePen = new Pen(Color.Black, 3);

            #endregion

            #region highscoreShow (current page = 7)
            
            if (currentPage == 7)
            {
                gameTimer.Stop();
                formGraphics.DrawImage(instructionBack, 0, 0, this.Width, this.Height);
                formGraphics.DrawImage(winner, 350, 100);
            }
            if (currentPage == 7)
            {
                playersLabel.Visible = true;
                top10Label.Visible = true;
                returnLabel.Visible = true;
            }
            else
            {
                playersLabel.Visible = false;
                top10Label.Visible = false;
                returnLabel.Visible = false;
            }
            #endregion

            #region gameScreen (current page = 6)

            if (currentPage == 6)
            {
                gameTimer.Start();

                #region graphics along the right side
                //Writing
                formGraphics.DrawString(" Selected", menuWordsFont, menuBrush, 920, 100);
                //Draws tower1 image + cost
                formGraphics.DrawImage(tower1Images, 925, 210);
                formGraphics.DrawString("Cost: " + tower1Cost, menuWordsFont, menuBrush, 920, 270);
                //Draws tower2 image + cost
                formGraphics.DrawImage(tower2Image, 918, 310, 80, 80);
                formGraphics.DrawString("Cost: " + tower2Cost, menuWordsFont, menuBrush, 920, 375);

                if (storeUp == false)
                {
                    //Draws tower3 + cost
                    formGraphics.DrawImage(tower3Image, 930, 415, 60, 60);
                    formGraphics.DrawString("Cost: " + tower3Cost, menuWordsFont, menuBrush, 920, 475);
                }
                if (tower3UpgradeClick == true)
                {
                    //Draws Lightning image
                    formGraphics.DrawImage(lightning, 930, 520, 60, 60);
                    formGraphics.DrawString("Cost: " + specialCost, menuWordsFont, menuBrush, 920, 580);
                }
                //Draws Destroy iamge
                formGraphics.DrawImage(destroy, 930, 630, 60, 60);

                #endregion

                #region values along the top
                //Draws values along the top(Time, Score, Gold, Lives, WaveNumber)
                formGraphics.DrawString("Time:", menuWordsFont, menuBrush, 15, 15);
                formGraphics.DrawString("" + totalTime, menuFont, menuBrush, 10, 40);
                formGraphics.DrawString("Score:", menuWordsFont, menuBrush, 215, 15);
                formGraphics.DrawString("" + totalScore, menuFont, menuBrush, 210, 40);
                formGraphics.DrawString("Gold:", menuWordsFont, menuBrush, 420, 15);
                formGraphics.DrawString("" + totalGold, menuFont, scoreBrush, 415, 40);
                formGraphics.DrawString("Lives:", menuWordsFont, menuBrush, 625, 15);
                formGraphics.DrawString("" + totalLives, menuFont, redBrush, 620, 40);
                formGraphics.DrawString("Wave: " + waveNumber, menuWordsFont, menuBrush, 830, 15);
                //Draws start wave image
                if (waveReady == true)
                {
                    formGraphics.DrawImage(startWave, 830, 55, 70, 30);
                }
                //Writing
                formGraphics.DrawString("Menu", menuButtonFont, menuBrush, 925, 10);

                #endregion

                //specialCooldown
                formGraphics.FillPie(startBackroundBrush, 920, 520, 80, 80, 360, specialCooldown * 2);                

                #region Draws images (enemies/towers/explosions/shots/wind) **includes turtle hide
                
                //Turtles
                for (int i = 0; i < enemies.Count(); i++)
                {
                    formGraphics.DrawImage(enemies[i].charImages[enemies[i].sprite], enemies[i].x - enemyImages[0].Width / 2, enemies[i].y - enemyImages[0].Height / 2);
                }
                //shots
                for (int i = 0; i < shots.Count(); i++)
                {
                    formGraphics.DrawImage(shots[i].bulletImages, shots[i].x, shots[i].y);
                }
                //tower1
                for (int i = 0; i < tower1.Count(); i++)
                {
                    formGraphics.DrawImage(tower1[i].tower1Images, tower1[i].x - 25, tower1[i].y - 25, 50, 50);
                }
                //tower2
                for (int i = 0; i < tower2.Count(); i++)
                {
                    formGraphics.DrawImage(tower2[i].tower2Image, tower2[i].x - 40, tower2[i].y - 40);
                }
                //tower3
                for (int i = 0; i < tower3.Count(); i++)
                {
                    formGraphics.DrawImage(tower3[i].tower3Image, tower3[i].x - 50, tower3[i].y - 50, 80, 80);
                }
                //explosion
                for (int i = 0; i < explosion.Count(); i++)
                {
                    formGraphics.DrawImage(explosion[i].boom, explosion[i].x - 25, explosion[i].y - 25, 50, 50);
                }
                //wind
                for (int i = 0; i < windlist.Count(); i++)
                {
                    formGraphics.DrawImage(windlist[i].Wind, windlist[i].x - 15, windlist[i].y - 15, 30, 30);
                }                
               
                //turtle hide top
                formGraphics.FillRectangle(hideBrush, 710, 0, 80, 101);
                formGraphics.FillRectangle(hide2Brush, 710, 10, 80, 82);
                formGraphics.DrawLine(hidePen, 710, 10, 790, 10);
                formGraphics.DrawLine(hidePen, 710, 91, 790, 91);   
                #endregion

                #region shows user if they can use the tower/button (image - nope) (image - store)
                if (totalGold < tower1Cost)
                {
                    formGraphics.DrawImage(nope, 930, 220, 60, 60);
                }
                if (totalGold < tower2Cost)
                {
                    formGraphics.DrawImage(nope, 930, 320, 60, 60);
                }
                //if store tower is used
                if (0 != tower3.Count())
                {
                    formGraphics.DrawImage(store, 930, 430, 60, 60);
                }
                //special
                if (tower3UpgradeClick == false || 0 == tower3.Count() && totalGold >= specialCost)
                {
                    formGraphics.DrawImage(nope, 930, 530, 60, 60);
                }
                if (tower3.Count() == 0 && totalGold < tower3Cost)
                {
                    formGraphics.DrawImage(nope, 930, 430, 60, 60);
                }
                #endregion

                #region displays the lighting
                if (lightingOn == true)
                {
                    if (rand <= 3)
                    {
                        formGraphics.FillRectangle(startBackroundBrush, 0, 0, this.Width, this.Height);
                    }
                    if (rand >= 4 && rand <= 6)
                    {
                        formGraphics.FillRectangle(whiteBrush, 0, 0, this.Width, this.Height);
                    }
                }
                #endregion

                #region Right side buttons select

                if (tower1Click == true)
                {
                    formGraphics.DrawImage(tower1Images, 925, 120);
                    formGraphics.FillEllipse(startBackroundBrushWhite, mouseX - 15, mouseY - 15, 30, 30);
                }
                if (tower2Click == true)
                {
                    formGraphics.DrawImage(tower2Image, 920, 120, 80, 80);
                    formGraphics.FillEllipse(startBackroundBrushWhite, mouseX - 20, mouseY - 20, 40, 40);
                }
                if (tower3Click == true)
                {
                    formGraphics.DrawImage(tower3Image, 920, 120, 80, 80);
                    formGraphics.FillEllipse(startBackroundBrushWhite, mouseX - 25, mouseY - 25, 50, 50);
                }
                if (destroyClick == true)
                {
                    formGraphics.DrawImage(destroy, 925, 125, 60, 60);
                }

                #endregion           
            }

            #endregion

            #region upgradeHome (current page = 5)

            if (currentPage == 5)
            {
                gameTimer.Start();

                formGraphics.FillRectangle(startBackroundBrush, 0, 0, 1000, 1000);
                formGraphics.DrawImage(shopBack, 200, 200);
                formGraphics.DrawString("(press esc to exit)", menuButtonFont, menuBrush, 350, 500);

                formGraphics.DrawImage(tower1Images, 300, 345, 100, 100);
                formGraphics.DrawString("Attacks faster ", menuWordsFont, menuBrush, 300, 425);
                formGraphics.DrawString("Level: " + tower1UpgradeClick, menuButtonFont, menuBrush, 300, 450);
                formGraphics.DrawString("Cost: " + tower1UpgradeCost, menuWordsFont, menuBrush, 300, 475);

                formGraphics.DrawImage(tower2Image, 464, 355, 70, 70);
                formGraphics.DrawString("Attacks faster ", menuWordsFont, menuBrush, 450, 425);
                formGraphics.DrawString("Level: " + tower2UpgradeClick, menuButtonFont, menuBrush, 450, 450);
                formGraphics.DrawString("Cost: " + tower2UpgradeCost, menuWordsFont, menuBrush, 450, 475);

                if (timer1 == 5)
                {
                    formGraphics.DrawString("Maxed Out!", menuFont, menuBrush, 380, 250);
                }
                else
                {
                    formGraphics.DrawString("Gold: " + totalGold, menuFont, menuBrush, 390, 250);
                }
                if (tower3UpgradeClick == true)
                {
                    formGraphics.DrawImage(lightning, 610, 360, 80, 80);
                    formGraphics.DrawString("Upgrade: Yes", menuButtonFont, menuBrush, 585, 450);
                    formGraphics.DrawString("Cost: " + tower3UpgradeCost, menuWordsFont, menuBrush, 585, 475);
                }
                else
                {
                    formGraphics.DrawString("Unknown ", menuWordsFont, menuBrush, 610, 425);
                    formGraphics.DrawString("?", menuFont, menuBrush, 630, 375);
                    formGraphics.DrawString("Upgrade: No", menuButtonFont, menuBrush, 585, 450);
                    formGraphics.DrawString("Cost: " + tower3UpgradeCost, menuWordsFont, menuBrush, 585, 475);
                }
            }
            //visible labels
            if (currentPage == 5)
            {
                tower1Upgrade.Visible = true;
                tower2Upgrade.Visible = true;
                tower3Upgrade.Visible = true;
            }
            else
            {
                tower1Upgrade.Visible = false;
                tower2Upgrade.Visible = false;
                tower3Upgrade.Visible = false;
            }

            #endregion

            #region startScreen (current page = 4)

            if (currentPage == 4)
            {
                gameTimer.Stop();
                formGraphics.FillRectangle(startBackroundBrush, 0, 0, 1000, 1000);
                formGraphics.DrawImage(startBackround, 200, 200);
                formGraphics.DrawString(introText, menuButtonFont, menuBrush, 250, 250);
            }
            if (currentPage == 4)
            {
                startLabel.Visible = true;
            }
            else
            {
                startLabel.Visible = false;
            }

            #endregion

            #region instructionClick (current page = 3)

            if (currentPage == 3)
            {
                gameTimer.Stop();
                formGraphics.FillRectangle(startBackroundBrush, 0, 0, 1000, 1000);
                formGraphics.DrawImage(instructionBack, 200, 200);
                formGraphics.DrawString(instructionsText, menuWordsFont, menuBrush, 250, 250);
            }

            if (currentPage == 3)
            {
                instructionsLabel.Visible = false;
                menu2Label.Visible = true;
            }
            else
            {
                menu2Label.Visible = false;
            }  
         
            #endregion

            #region menuClick (current page = 2)

            if (currentPage == 2)
            {
                gameTimer.Stop();
                formGraphics.FillRectangle(startBackroundBrush, 0, 0, 1000, 1000);
                formGraphics.DrawImage(menuBack, 200, 200);
                formGraphics.DrawString("(press esc to exit)", menuButtonFont, menuBrush, 250, 550);
            }
            if (currentPage == 2)
            {
                instructionsLabel.Visible = true;
                menu2Label.Visible = false;
                exitGameLabel.Visible = true;
            }
            else
            {
                instructionsLabel.Visible = false;
                exitGameLabel.Visible = false;
            }

            #endregion

            #region highscoreSubmit (current page = 1)
            
            if (currentPage == 1)
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            if (gameOver == true)
            {
                formGraphics.FillRectangle(startBackroundBrush, 0, 0, this.Width, this.Height);

                submitButton.Visible = true;
                inputBox.Visible = true;

            }
            else
            {
                submitButton.Visible = false;
                inputBox.Visible = false;
            }

            #endregion

            #region veryStart (current page = 0)

            if (currentPage == 0)
            {
                gameTimer.Stop();

                formGraphics.DrawImage(menuBack, 0, 0, this.Width, this.Height);
                formGraphics.DrawImage(overrun, 250, 450, 700, 200);
                formGraphics.DrawImage(tower3Image, 130, 470, 200, 200);
                formGraphics.DrawImage(tower1Images, 80, 110, 100, 100);
                formGraphics.DrawImage(enemyImages[3], 850, 140, 100, 50);

                formGraphics.DrawString("TURTLE DEFENSE", veryStartFont, menuBrush, 150, 100);
            }

            if (currentPage == 0)
            {
                startGameLabel.Visible = true;
                highscoresLabel.Visible = true;
                newPlayerLabel.Visible = true;
            }
            else
            {
                startGameLabel.Visible = false;
                highscoresLabel.Visible = false;
                newPlayerLabel.Visible = false;
            }

            #endregion        
        }

        private void menuLabel_MouseClick(object sender, MouseEventArgs e)
        {
            currentPage = 2;            
            menu2Label.Visible = false;
            tower1Click = false;
            tower2Click = false;
            tower3Click = false;
            destroyClick = false;            
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {            
            currentPage = 3;
                  
            this.Refresh();
        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            Reset();
            gameTimer.Enabled = true;
            gameTimer.Start();
            currentPage = 6;
        }

        #region tower button clicks
        private void tower1Label_Click(object sender, EventArgs e)
        {
            tower1Click = true;          
            tower2Click = false;
            tower3Click = false;
            destroyClick = false;
        }

        private void tower2Label_Click(object sender, EventArgs e)
        {
            tower2Click = true;
            tower1Click = false;
            tower3Click = false;
            destroyClick = false;
        }

        private void tower3Label_Click(object sender, EventArgs e)
        {

            if (upgradesAvailable == true && storeUp == true)
            {
                currentPage = 5;
            }

            if (storeUp == false)
            {
                tower3Click = true;
                tower2Click = false;
                tower1Click = false;
                destroyClick = false;
            }
        }



        private void destroyLabel_Click(object sender, EventArgs e)
        {
            destroyClick = true;
            tower2Click = false;
            tower1Click = false;
            tower3Click = false;
        }
        #endregion                    

        #region tower upgrade label clicks

        private void tower1Upgrade_Click(object sender, EventArgs e)
        {
            if (tower1UpgradeClick <= 2 && totalGold >= tower1UpgradeCost)
            {
                tower1UpgradeClick++;
                totalGold = totalGold - tower1UpgradeCost;
            }
        }

        private void tower2Upgrade_Click(object sender, EventArgs e)
        {
            if (tower2UpgradeClick <= 2 && totalGold >= tower2UpgradeCost)
            {
                tower2UpgradeClick++;
                totalGold = totalGold - tower2UpgradeCost;
            }
        }

        private void tower3Upgrade_Click(object sender, EventArgs e)
        {
            if (tower3UpgradeClick == false && totalGold >= tower3UpgradeCost)
            {
                tower3UpgradeClick = true;
                totalGold = totalGold - tower3UpgradeCost;
            }
        }

        #endregion

        //special label
        private void specialLabel_Click_1(object sender, EventArgs e)
        {
            if (specialCooldown == 0 && tower3.Count() != 0 && tower3UpgradeClick && totalGold >= specialCost)
            {
                specialClick = true;
                tower2Click = false;
                tower1Click = false;
                tower3Click = false;
                destroyClick = false;
            }
        }


        private void menu2Label_Click(object sender, EventArgs e)
        {          
            tower1Click = false;
            tower2Click = false;
            tower3Click = false;
            destroyClick = false;
            currentPage = 2;
            this.Refresh();
        }
        
        #region Targeting
        /// <summary>
        /// Predicts the movement of the Turtles and aims tower1's accordingly
        /// </summary>
        private void targeting()
        {
            for (int j = 0; j < shots.Count(); j++)
                {                                          
                    #region distan
                    //above and right
                    if (shots[j].targetx > shots[j].startx && shots[j].targety > shots[j].starty)
                    {
                        //gets distance between the enemy and tower
                        dist = Math.Abs(Math.Sqrt(Math.Pow(shots[j].targetx - shots[j].startx, 2) + Math.Pow(shots[j].targety - shots[j].starty, 2)));
                        distan = Convert.ToInt16(dist);
                    }
                    //above and left
                    if (shots[j].targetx < shots[j].startx && shots[j].targety > shots[j].starty)
                    {
                        //gets distance between the enemy and tower
                        dist = Math.Abs(Math.Sqrt(Math.Pow(shots[j].startx - shots[j].targetx, 2) + Math.Pow(shots[j].targety - shots[j].starty, 2)));
                        distan = Convert.ToInt16(dist);
                    }

                    //below and right
                    if (shots[j].targetx > shots[j].startx && shots[j].targety < shots[j].starty)
                    {
                        //gets distance between the enemy and tower
                        dist = Math.Abs(Math.Sqrt(Math.Pow(shots[j].targetx - shots[j].startx, 2) + Math.Pow(shots[j].starty - shots[j].targety, 2)));
                        distan = Convert.ToInt16(dist);
                    }

                    //below and left
                    if (shots[j].targetx < shots[j].startx && shots[j].targety < shots[j].starty)
                    {
                        //gets distance between the enemy and tower
                        dist = Math.Abs(Math.Sqrt(Math.Pow(shots[j].startx - shots[j].targetx, 2) + Math.Pow(shots[j].starty - shots[j].targety, 2)));
                        distan = Convert.ToInt16(dist);
                    }
                    #endregion

                    ticks = distan / 20;
                    
                    //down prediction
                    if (enemies[0].direction == 0)
                    {
                        shots[j].targety = shots[j].targety + enemies[0].speed * ticks;
                    }
                    //up prediction
                    if (enemies[0].direction == 3)
                    {
                        shots[j].targety = shots[j].targety - enemies[0].speed * ticks;
                    }
                    //left prediction
                    if (enemies[0].direction == 1)
                    {
                        shots[j].targetx = shots[j].targetx - enemies[0].speed * ticks;
                    }
                    //right prediction
                    if (enemies[0].direction == 2)
                    {
                        shots[j].targetx = shots[j].targetx + enemies[0].speed * ticks;
                    }

                    shots[j].vertical = shots[j].starty - shots[j].targety;
                    shots[j].horizontal = shots[j].startx - shots[j].targetx;

                    shots[j].vertical = shots[j].vertical / ticks;
                    shots[j].horizontal = shots[j].horizontal / ticks;                                                  
                }           
            }

        #endregion

        #region ss method
        /// <summary>
        /// Engeneering Central Spashscreen
        /// </summary>
        public void SplashScreen()
        {
            Form ss = new Form();

            ss.Size = new Size(400, 400);
            ss.FormBorderStyle = FormBorderStyle.None; //removes all borders around window 
            ss.StartPosition = FormStartPosition.CenterScreen;
            ss.BackColor = Color.Green;           

            Graphics ssGraphics = ss.CreateGraphics();
            SolidBrush ssBrush = new SolidBrush(Color.Red);
            Font ssFont = new Font("Impact", 30);

            ss.Show();
            
            ssGraphics.FillEllipse(ssBrush, 0, 0, 400, 400); //draw the green background 

            ssBrush.Color = Color.Black;
            ssGraphics.DrawImage(Properties.Resources.ramlogo, 100, 80);
            ssGraphics.DrawString("Engeneering Central", ssFont, ssBrush, 30, 300);
            for (int i = 50; i < 200; i++)
            {
                ssGraphics.FillRectangle(ssBrush, i, 330, 3, 3);
                ssGraphics.FillRectangle(ssBrush, 400 - i, 330, 3, 3);
                Thread.Sleep(5);
            }

            // Close this splash screen after 2s which causes the main form to show 
            Thread.Sleep(2000);
            ss.Close();
        }
        #endregion

        #region save/loadDB
        private void SaveDB()
        {
            XmlTextWriter writer = new XmlTextWriter("highscores.xml", null);       

            //Start "Highscores" element
            writer.WriteStartElement("Highscores");

            //saves each characteristic for each character
            for (int i = 0; i < play.Count(); i++)
            {
                writer.WriteStartElement("character");

                writer.WriteElementString("Name", play[i].name);
                writer.WriteElementString("Score", play[i].highscore);

                // end the "Highscores" element
                writer.WriteEndElement();
            }

            // end the "Highscores" element
            writer.WriteEndElement();
            writer.Close();
        }

        private void LoadDB()
        {
            //index lets the program know which type of information each kind is
            int index = 0;
            //declares the strings
            string name = "";
            string highscore = "";

            //reads from the file
            XmlTextReader reader = new XmlTextReader("highscores.xml");

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // If the currently read item is text then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    switch (index)
                    {
                        case (0):
                            name = reader.Value;
                            index++;
                            break;
                        case (1):
                            highscore = reader.Value;
                            index = 0;
                            //adds the character to the program
                            Player hs = new Player(name, highscore);
                            play.Add(hs);
                            break;
                    }
                }
            }
            // When done reading the file close it
            reader.Close();
        }
        #endregion

        #region Reset Method
        /// <summary>
        /// The reset method resets all needed parts of the game so that a new one can start. It runs before the start of each game
        /// </summary>
        private void Reset()
        {
            totalLives = 50;
            totalGold = 1000;
            enemies.Clear();
            tower1.Clear();
            tower2.Clear();
            tower3.Clear();
            shots.Clear();
            totalScore = 0;

            timer = 0;
            waveNumber = 0;
            totalSpawns = 0;
            monsterSpeed = 2;
            shotSpeed = 5;
            waveGo = false;

            tower1UpgradeClick = 0;
            tower2UpgradeClick = 0;
            tower3UpgradeClick = false;
        }
        #endregion

        #region HighscoreMethod
        /// <summary>
        /// Displays the highscores and sorts them
        /// </summary>
        private void HighscoreMethod()
        {
            play.Clear();
            LoadDB();

            playersLabel.Text = "";
            for (int j = 0; j < play.Count(); j++)
            {
                for (int i = 0; i < play.Count(); i++)
                {
                    string score1, score2; string name1, name2;

                    if (i != 0)
                    {
                        if (Convert.ToInt16(play[i].highscore) > Convert.ToInt16(play[i - 1].highscore))
                        {
                            //Holds the first players information
                            name1 = play[i].name;
                            score1 = play[i].highscore;
                            //Holds the second players information
                            name2 = play[i - 1].name;
                            score2 = play[i - 1].highscore;
                            //Swaps the 2 players information
                            play[i - 1].name = name1;
                            play[i - 1].highscore = score1;
                            //Swaps the 1 players information
                            play[i].name = name2;
                            play[i].highscore = score2;
                        }
                    }
                }
            }
            //Limits the total number of highscores shown to 10
            if (play.Count() < 10)
            {
                for (int i = 0; i < play.Count(); i++)
                {
                    playersLabel.Text += "\n" + (i + 1) + ".  " + play[i].name + "     " + play[i].highscore;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    playersLabel.Text += "\n" + (i + 1) + ".  " + play[i].name + "     " + play[i].highscore;
                }
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDB();
        }      

        private void inputBox_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void startGameLabel_Click(object sender, EventArgs e)
        {
            currentPage = 4;
            Refresh();
        }

        private void highscoresLabel_Click(object sender, EventArgs e)
        {        
            HighscoreMethod();

            currentPage = 7;

            this.Refresh();
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            scoreString = Convert.ToString(totalScore);

            Player hs = new Player(inputBox.Text, scoreString);
            play.Add(hs);

            SaveDB();      

            Thread.Sleep(500);

            currentPage = 0;

            inputBox.Text = "Enter Your Name";
            this.Refresh();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            currentPage = 0;

            this.Refresh();
        }

        private void exitGameLabel_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            gameTimer.Stop();
            Reset();
            this.Refresh();
        }

        #region StartWaveLabelClick
        private void startWaveLabel_Click(object sender, EventArgs e)
        {
            if (waveReady == true)
            {
                if (waveNumber <= 20)
                {
                    //rewards player for starting the next round
                    totalGold = totalGold + 200 - waveNumber * 10;
                }
                //clears the list of shots
                shots.Clear();
                
                waveNumber++;
                waveGo = true;

                //makes the game harder as it goes on
                if (waveNumber <= 2)
                {
                    spawnRate = 30;
                    monsterSpeed = 2;
                }
                if (waveNumber == 3)
                {
                    spawnRate = 25;
                    monsterLives = 2;
                }
                if (waveNumber == 4)
                {
                    spawnRate = 15;
                    monsterSpeed = 5;
                }
                if (waveNumber == 5)
                {
                    spawnRate = 10;
                }
                if (waveNumber == 6)
                {
                    spawnRate = 5;
                    monsterLives = 3;
                }
                if (waveNumber == 7)
                {
                    spawnRate = 4;
                    monsterSpeed = 10;
                }
                if (waveNumber == 8)
                {
                    spawnRate = 3;
                    monsterLives = 3;
                }
                if (waveNumber == 10)
                {
                    spawnRate = 3;
                }
                if (waveNumber >= 11 && waveNumber <= 12)
                {
                    monsterLives = 5;
                    monsterSpeed = 25;
                }
                if (waveNumber >= 13 && waveNumber <= 14)
                {
                    monsterLives = 6;
                }
                if (waveNumber >= 15 && waveNumber <= 16)
                {
                    monsterLives = 7;                    
                }
                if (waveNumber >= 17)
                {
                    monsterLives = waveNumber - 10;
                }
                //spawns Turtle
                Character c = new Character(750, 50, monsterSpeed, enemyImages, 0, 0, monsterLives);
                enemies.Add(c);
                totalSpawns++;
                tempSeconds = 0;
                wave++;
                waveReady = false;                
            }
        }
        #endregion

        #region clicks make towers
        private void Form1_Click(object sender, EventArgs e)
        {
            Boolean occupied1 = false;
            Boolean occupied2 = false;
            Boolean occupied3 = false;
            Boolean track = false;

            //this area is of the top and right of the screen
            if (mouseY <= 125 || mouseX >= 875)
            {
                track = true;
            }
            if (mouseX >= 675 && mouseX <= 825 && mouseY >= 75 && mouseY <= 300)
            {
                track = true;
            }
            if (mouseX >= 100 && mouseX <= 800 && mouseY >= 175 && mouseY <= 325)
            {
                track = true;
            }
            if (mouseX >= 75 && mouseX <= 225 && mouseY >= 185 && mouseY <= 725)
            {
                track = true;
            }
            if (mouseX >= 175 && mouseX <= 425 && mouseY >= 600 && mouseY <= 725)
            {
                track = true;
            }
            if (mouseX >= 375 && mouseX <= 525 && mouseY >= 410 && mouseY <= 725)
            {
                track = true;
            }
            if (mouseX >= 380 && mouseX <= 825 && mouseY >= 380 && mouseY <= 525)
            {
                track = true;
            }
            if (mouseX >= 680 && mouseX <= 825 && mouseY >= 380 && mouseY <= 725)
            {
                track = true;
            } 
      

            for (int i = 0; i < tower1.Count(); i++)
            {
                int dist = ((mouseX - tower1[i].x) * (mouseX - tower1[i].x)) + ((mouseY - tower1[i].y) * (mouseY - tower1[i].y));
                double dist2 = Math.Sqrt(dist);
                if (dist2 <= 30)
                {
                    occupied1 = true;
                }
            }
            for (int i = 0; i < tower2.Count(); i++)
            {
                int dist = ((mouseX - tower2[i].x) * (mouseX - tower2[i].x)) + ((mouseY - tower2[i].y) * (mouseY - tower2[i].y));
                double dist2 = Math.Sqrt(dist);
                if (dist2 <= 40)
                {
                    occupied2 = true;
                }
            }
            for (int i = 0; i < tower3.Count(); i++)
            {
                int dist = ((mouseX - tower3[i].x) * (mouseX - tower3[i].x)) + ((mouseY - tower3[i].y) * (mouseY - tower3[i].y));
                double dist2 = Math.Sqrt(dist);
                if (dist2 <= 50)
                {
                    occupied3 = true;
                }
            }

            if (occupied1 == false && occupied2 == false && occupied3 == false && track == false)
            {
                if (tower1Click == true)
                {
                    Tower1 t1 = new Tower1(mouseX, mouseY, tower1Images, timer1, 0, 0, 0, 5);
                    tower1.Add(t1);
                    totalGold = totalGold - tower1Cost;                  
                }
                if (tower2Click == true)
                {
                    Tower2 t2 = new Tower2(mouseX, mouseY, tower2Image, timer2, 0);
                    tower2.Add(t2);
                    totalGold = totalGold - tower2Cost;                   
                }
                if (tower3Click == true)
                {
                    Tower3 t3 = new Tower3(mouseX, mouseY, tower3Image);
                    tower3.Add(t3);
                    totalGold = totalGold - tower3Cost;
                    tower3Click = false;
                }
            }
            int desrange = 10;
            if (destroyClick == true)
            {
                if (occupied1 == true)
                {
                    for (int i = 0; i < tower1.Count(); i++)
                    {
                        if (tower1[i].x >= mouseX - desrange && tower1[i].x <= mouseX + desrange && tower1[i].y >= mouseY - desrange && tower1[i].y <= mouseY + desrange)
                        {
                            tower1.RemoveAt(i);
                        }
                    }               
                }
                if (occupied2 == true)
                {
                    for (int i = 0; i < tower2.Count(); i++)
                    {
                        if (tower2[i].x >= mouseX - desrange && tower2[i].x <= mouseX + desrange && tower2[i].y >= mouseY - desrange && tower2[i].y <= mouseY + desrange)
                        {
                            tower2.RemoveAt(i);
                        }
                    }
                }
                if (occupied3 == true)
                {
                    for (int i = 0; i < tower3.Count(); i++)
                    {
                        if (tower3[i].x >= mouseX - desrange && tower3[i].x <= mouseX + desrange && tower3[i].y >= mouseY - desrange && tower3[i].y <= mouseY + desrange)
                        {
                            tower3.RemoveAt(i);
                        }
                    }
                }
            }
            
        }

        
        #endregion        

        #region rotateImage Method
        /// <summary>
        /// Gets an Image and angle and turns the Image accordingly
        /// </summary>
        /// <param name="b">The Image being changed</param>
        /// <param name="angle">At which angle it is being changed</param>
        /// <returns>Returns the rotated image</returns>
        private Bitmap rotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            //Bitmap returnBitmap = new Bitmap(b.Width, b.Height);       
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(returnBitmap);

            //move rotation point to center of image            
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);

            //rotate
            g.RotateTransform(angle);

            //move image back
            g.TranslateTransform(-(float)b.Width / 8, -(float)b.Height / 8);

            //draw passed in image onto graphics object

            g.DrawImage(b, new Point(-b.Width / 2, -b.Height / 2));
            //returns rotated 
            return returnBitmap;
        }
        #endregion

        private void newPlayerLabel_Click(object sender, EventArgs e)
        {
            Tutorial T = new Tutorial();
            T.Show();
        }
    } 
}  