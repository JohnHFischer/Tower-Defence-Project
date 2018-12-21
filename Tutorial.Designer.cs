namespace WindowsFormsApplication1
{
    partial class Tutorial
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
            this.tutorialWelcomeLabel = new System.Windows.Forms.Label();
            this.explainingLabel = new System.Windows.Forms.Label();
            this.tower1Box = new System.Windows.Forms.PictureBox();
            this.tower2Box = new System.Windows.Forms.PictureBox();
            this.tower3Box = new System.Windows.Forms.PictureBox();
            this.specialBox = new System.Windows.Forms.PictureBox();
            this.turtleBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoScreen = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tower1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tower2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tower3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turtleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialWelcomeLabel
            // 
            this.tutorialWelcomeLabel.Font = new System.Drawing.Font("Miramonte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialWelcomeLabel.Location = new System.Drawing.Point(86, 32);
            this.tutorialWelcomeLabel.Name = "tutorialWelcomeLabel";
            this.tutorialWelcomeLabel.Size = new System.Drawing.Size(838, 103);
            this.tutorialWelcomeLabel.TabIndex = 0;
            this.tutorialWelcomeLabel.Text = "Welcome to the Turtle Defence Tutorial";
            // 
            // explainingLabel
            // 
            this.explainingLabel.Font = new System.Drawing.Font("Miramonte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainingLabel.Location = new System.Drawing.Point(180, 135);
            this.explainingLabel.Name = "explainingLabel";
            this.explainingLabel.Size = new System.Drawing.Size(648, 67);
            this.explainingLabel.TabIndex = 1;
            this.explainingLabel.Text = "Click on whatever you want to learn about";
            // 
            // tower1Box
            // 
            this.tower1Box.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tower1bitmapFIXEDSIZEandcolour;
            this.tower1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tower1Box.Location = new System.Drawing.Point(100, 250);
            this.tower1Box.Name = "tower1Box";
            this.tower1Box.Size = new System.Drawing.Size(100, 100);
            this.tower1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tower1Box.TabIndex = 2;
            this.tower1Box.TabStop = false;
            this.tower1Box.Click += new System.EventHandler(this.tower1Box_Click);
            // 
            // tower2Box
            // 
            this.tower2Box.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.owl80by80;
            this.tower2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tower2Box.Location = new System.Drawing.Point(300, 250);
            this.tower2Box.Name = "tower2Box";
            this.tower2Box.Size = new System.Drawing.Size(100, 100);
            this.tower2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tower2Box.TabIndex = 3;
            this.tower2Box.TabStop = false;
            this.tower2Box.Click += new System.EventHandler(this.tower2Box_Click);
            // 
            // tower3Box
            // 
            this.tower3Box.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tower3;
            this.tower3Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tower3Box.Location = new System.Drawing.Point(500, 250);
            this.tower3Box.Name = "tower3Box";
            this.tower3Box.Size = new System.Drawing.Size(100, 100);
            this.tower3Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tower3Box.TabIndex = 4;
            this.tower3Box.TabStop = false;
            this.tower3Box.Click += new System.EventHandler(this.tower3Box_Click);
            // 
            // specialBox
            // 
            this.specialBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.lightning;
            this.specialBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.specialBox.Location = new System.Drawing.Point(700, 250);
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(100, 100);
            this.specialBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specialBox.TabIndex = 5;
            this.specialBox.TabStop = false;
            this.specialBox.Click += new System.EventHandler(this.specialBox_Click);
            // 
            // turtleBox
            // 
            this.turtleBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.turtleRight;
            this.turtleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turtleBox.Location = new System.Drawing.Point(400, 529);
            this.turtleBox.Name = "turtleBox";
            this.turtleBox.Size = new System.Drawing.Size(112, 67);
            this.turtleBox.TabIndex = 6;
            this.turtleBox.TabStop = false;
            this.turtleBox.Click += new System.EventHandler(this.turtleBox_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "General";
            // 
            // infoScreen
            // 
            this.infoScreen.Font = new System.Drawing.Font("Miramonte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoScreen.Location = new System.Drawing.Point(0, 0);
            this.infoScreen.Name = "infoScreen";
            this.infoScreen.Size = new System.Drawing.Size(1000, 700);
            this.infoScreen.TabIndex = 8;
            this.infoScreen.Text = "label2";
            this.infoScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoScreen.Click += new System.EventHandler(this.infoScreen_Click);
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Miramonte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(726, 613);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(234, 39);
            this.returnLabel.TabIndex = 9;
            this.returnLabel.Text = "Return to Game";
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.infoScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turtleBox);
            this.Controls.Add(this.specialBox);
            this.Controls.Add(this.tower3Box);
            this.Controls.Add(this.tower2Box);
            this.Controls.Add(this.tower1Box);
            this.Controls.Add(this.explainingLabel);
            this.Controls.Add(this.tutorialWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.tower1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tower2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tower3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turtleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutorialWelcomeLabel;
        private System.Windows.Forms.Label explainingLabel;
        private System.Windows.Forms.PictureBox tower1Box;
        private System.Windows.Forms.PictureBox tower2Box;
        private System.Windows.Forms.PictureBox tower3Box;
        private System.Windows.Forms.PictureBox specialBox;
        private System.Windows.Forms.PictureBox turtleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoScreen;
        private System.Windows.Forms.Label returnLabel;
    }
}