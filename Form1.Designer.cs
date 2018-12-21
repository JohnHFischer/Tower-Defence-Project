namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuLabel = new System.Windows.Forms.Label();
            this.destroyLabel = new System.Windows.Forms.Label();
            this.tower2Label = new System.Windows.Forms.Label();
            this.tower1Label = new System.Windows.Forms.Label();
            this.tower3Label = new System.Windows.Forms.Label();
            this.showLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.menu2Label = new System.Windows.Forms.Label();
            this.tower2Upgrade = new System.Windows.Forms.Label();
            this.tower3Upgrade = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.highscoresLabel = new System.Windows.Forms.Label();
            this.startGameLabel = new System.Windows.Forms.Label();
            this.exitGameLabel = new System.Windows.Forms.Label();
            this.startWaveLabel = new System.Windows.Forms.Label();
            this.tower1Upgrade = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.newPlayerLabel = new System.Windows.Forms.Label();
            this.top10Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Location = new System.Drawing.Point(910, 10);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(100, 85);
            this.menuLabel.TabIndex = 32;
            this.menuLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuLabel_MouseClick);
            // 
            // destroyLabel
            // 
            this.destroyLabel.BackColor = System.Drawing.Color.Transparent;
            this.destroyLabel.Location = new System.Drawing.Point(910, 600);
            this.destroyLabel.Name = "destroyLabel";
            this.destroyLabel.Size = new System.Drawing.Size(100, 100);
            this.destroyLabel.TabIndex = 33;
            this.destroyLabel.Click += new System.EventHandler(this.destroyLabel_Click);
            // 
            // tower2Label
            // 
            this.tower2Label.BackColor = System.Drawing.Color.Transparent;
            this.tower2Label.Location = new System.Drawing.Point(910, 312);
            this.tower2Label.Name = "tower2Label";
            this.tower2Label.Size = new System.Drawing.Size(100, 100);
            this.tower2Label.TabIndex = 34;
            this.tower2Label.Click += new System.EventHandler(this.tower2Label_Click);
            // 
            // tower1Label
            // 
            this.tower1Label.BackColor = System.Drawing.Color.Transparent;
            this.tower1Label.Location = new System.Drawing.Point(910, 200);
            this.tower1Label.Name = "tower1Label";
            this.tower1Label.Size = new System.Drawing.Size(100, 100);
            this.tower1Label.TabIndex = 35;
            this.tower1Label.Click += new System.EventHandler(this.tower1Label_Click);
            // 
            // tower3Label
            // 
            this.tower3Label.BackColor = System.Drawing.Color.Transparent;
            this.tower3Label.Location = new System.Drawing.Point(910, 400);
            this.tower3Label.Name = "tower3Label";
            this.tower3Label.Size = new System.Drawing.Size(100, 100);
            this.tower3Label.TabIndex = 36;
            this.tower3Label.Click += new System.EventHandler(this.tower3Label_Click);
            // 
            // showLabel
            // 
            this.showLabel.BackColor = System.Drawing.Color.Transparent;
            this.showLabel.Location = new System.Drawing.Point(910, 100);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(100, 100);
            this.showLabel.TabIndex = 37;
            // 
            // specialLabel
            // 
            this.specialLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialLabel.Location = new System.Drawing.Point(910, 500);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(100, 100);
            this.specialLabel.TabIndex = 38;
            this.specialLabel.Click += new System.EventHandler(this.specialLabel_Click_1);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(460, 510);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(85, 37);
            this.startLabel.TabIndex = 39;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(400, 340);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(200, 50);
            this.instructionsLabel.TabIndex = 40;
            this.instructionsLabel.Text = "       Instructions";
            this.instructionsLabel.Visible = false;
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // menu2Label
            // 
            this.menu2Label.BackColor = System.Drawing.Color.Transparent;
            this.menu2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2Label.Location = new System.Drawing.Point(450, 505);
            this.menu2Label.Name = "menu2Label";
            this.menu2Label.Size = new System.Drawing.Size(100, 50);
            this.menu2Label.TabIndex = 42;
            this.menu2Label.Text = " Menu";
            this.menu2Label.Visible = false;
            this.menu2Label.Click += new System.EventHandler(this.menu2Label_Click);
            // 
            // tower2Upgrade
            // 
            this.tower2Upgrade.BackColor = System.Drawing.Color.Transparent;
            this.tower2Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tower2Upgrade.Location = new System.Drawing.Point(450, 350);
            this.tower2Upgrade.Name = "tower2Upgrade";
            this.tower2Upgrade.Size = new System.Drawing.Size(100, 100);
            this.tower2Upgrade.TabIndex = 44;
            this.tower2Upgrade.Visible = false;
            this.tower2Upgrade.Click += new System.EventHandler(this.tower2Upgrade_Click);
            // 
            // tower3Upgrade
            // 
            this.tower3Upgrade.BackColor = System.Drawing.Color.Transparent;
            this.tower3Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tower3Upgrade.Location = new System.Drawing.Point(600, 350);
            this.tower3Upgrade.Name = "tower3Upgrade";
            this.tower3Upgrade.Size = new System.Drawing.Size(100, 100);
            this.tower3Upgrade.TabIndex = 45;
            this.tower3Upgrade.Visible = false;
            this.tower3Upgrade.Click += new System.EventHandler(this.tower3Upgrade_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(406, 197);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(209, 20);
            this.inputBox.TabIndex = 46;
            this.inputBox.Text = "Enter Your Name";
            this.inputBox.Visible = false;
            this.inputBox.Click += new System.EventHandler(this.inputBox_Click);
            // 
            // returnLabel
            // 
            this.returnLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnLabel.Font = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(405, 530);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(200, 100);
            this.returnLabel.TabIndex = 49;
            this.returnLabel.Text = "Return To Menu";
            this.returnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnLabel.Visible = false;
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(442, 232);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(145, 24);
            this.submitButton.TabIndex = 53;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // highscoresLabel
            // 
            this.highscoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresLabel.Location = new System.Drawing.Point(340, 350);
            this.highscoresLabel.Name = "highscoresLabel";
            this.highscoresLabel.Size = new System.Drawing.Size(320, 90);
            this.highscoresLabel.TabIndex = 54;
            this.highscoresLabel.Text = "Highscores";
            this.highscoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.highscoresLabel.Click += new System.EventHandler(this.highscoresLabel_Click);
            // 
            // startGameLabel
            // 
            this.startGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.startGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameLabel.Location = new System.Drawing.Point(340, 230);
            this.startGameLabel.Name = "startGameLabel";
            this.startGameLabel.Size = new System.Drawing.Size(320, 90);
            this.startGameLabel.TabIndex = 55;
            this.startGameLabel.Text = "Start";
            this.startGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startGameLabel.Click += new System.EventHandler(this.startGameLabel_Click);
            // 
            // exitGameLabel
            // 
            this.exitGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameLabel.Location = new System.Drawing.Point(400, 399);
            this.exitGameLabel.Name = "exitGameLabel";
            this.exitGameLabel.Size = new System.Drawing.Size(200, 50);
            this.exitGameLabel.TabIndex = 58;
            this.exitGameLabel.Text = "Exit Game";
            this.exitGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitGameLabel.Click += new System.EventHandler(this.exitGameLabel_Click);
            // 
            // startWaveLabel
            // 
            this.startWaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.startWaveLabel.Location = new System.Drawing.Point(817, 12);
            this.startWaveLabel.Name = "startWaveLabel";
            this.startWaveLabel.Size = new System.Drawing.Size(83, 83);
            this.startWaveLabel.TabIndex = 59;
            this.startWaveLabel.Click += new System.EventHandler(this.startWaveLabel_Click);
            // 
            // tower1Upgrade
            // 
            this.tower1Upgrade.BackColor = System.Drawing.Color.Transparent;
            this.tower1Upgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tower1Upgrade.Location = new System.Drawing.Point(300, 350);
            this.tower1Upgrade.Name = "tower1Upgrade";
            this.tower1Upgrade.Size = new System.Drawing.Size(100, 100);
            this.tower1Upgrade.TabIndex = 43;
            this.tower1Upgrade.Visible = false;
            this.tower1Upgrade.Click += new System.EventHandler(this.tower1Upgrade_Click);
            // 
            // playersLabel
            // 
            this.playersLabel.BackColor = System.Drawing.Color.Transparent;
            this.playersLabel.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersLabel.ForeColor = System.Drawing.Color.Black;
            this.playersLabel.Location = new System.Drawing.Point(33, 227);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(339, 319);
            this.playersLabel.TabIndex = 60;
            this.playersLabel.Text = "text";
            this.playersLabel.Visible = false;
            // 
            // newPlayerLabel
            // 
            this.newPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerLabel.Font = new System.Drawing.Font("Miramonte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerLabel.Location = new System.Drawing.Point(637, 50);
            this.newPlayerLabel.Name = "newPlayerLabel";
            this.newPlayerLabel.Size = new System.Drawing.Size(342, 45);
            this.newPlayerLabel.TabIndex = 61;
            this.newPlayerLabel.Text = "New Player? Click here!";
            this.newPlayerLabel.Click += new System.EventHandler(this.newPlayerLabel_Click);
            // 
            // top10Label
            // 
            this.top10Label.AutoSize = true;
            this.top10Label.BackColor = System.Drawing.Color.Transparent;
            this.top10Label.Font = new System.Drawing.Font("Miramonte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top10Label.Location = new System.Drawing.Point(34, 169);
            this.top10Label.Name = "top10Label";
            this.top10Label.Size = new System.Drawing.Size(117, 39);
            this.top10Label.TabIndex = 62;
            this.top10Label.Text = "Top 10!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.backroundBase;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.top10Label);
            this.Controls.Add(this.newPlayerLabel);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.startWaveLabel);
            this.Controls.Add(this.exitGameLabel);
            this.Controls.Add(this.startGameLabel);
            this.Controls.Add(this.highscoresLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.tower3Upgrade);
            this.Controls.Add(this.tower2Upgrade);
            this.Controls.Add(this.tower1Upgrade);
            this.Controls.Add(this.menu2Label);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.tower3Label);
            this.Controls.Add(this.tower1Label);
            this.Controls.Add(this.tower2Label);
            this.Controls.Add(this.destroyLabel);
            this.Controls.Add(this.menuLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label destroyLabel;
        private System.Windows.Forms.Label tower2Label;
        private System.Windows.Forms.Label tower1Label;
        private System.Windows.Forms.Label tower3Label;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label menu2Label;
        private System.Windows.Forms.Label tower2Upgrade;
        private System.Windows.Forms.Label tower3Upgrade;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label highscoresLabel;
        private System.Windows.Forms.Label startGameLabel;
        private System.Windows.Forms.Label exitGameLabel;
        private System.Windows.Forms.Label startWaveLabel;
        private System.Windows.Forms.Label tower1Upgrade;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label newPlayerLabel;
        private System.Windows.Forms.Label top10Label;
    }
}

