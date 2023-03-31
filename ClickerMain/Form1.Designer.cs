namespace ClickerMain
{
    partial class DefeatClickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefeatClickerForm));
            attackButton = new Custom_Buttons.RoundedButton();
            upgradePowerAttackButton = new Custom_Buttons.RoundedButton();
            getTimeButton = new Custom_Buttons.RoundedButton();
            upgradeAttackButton = new Custom_Buttons.RoundedButton();
            undoButton = new Custom_Buttons.RoundedButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            healthBar = new ProgressBar();
            moneyBox = new Label();
            roundedButton5 = new Custom_Buttons.RoundedButton();
            pictureBox3 = new PictureBox();
            roundedButton6 = new Custom_Buttons.RoundedButton();
            roundedButton7 = new Custom_Buttons.RoundedButton();
            upgradeAttackCost = new Label();
            upgradePowerAttackCost = new Label();
            getTimeCost = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            replayContinueButton = new Custom_Buttons.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // attackButton
            // 
            attackButton.Anchor = AnchorStyles.None;
            attackButton.BackColor = Color.DarkGreen;
            attackButton.BackgroundColor = Color.DarkGreen;
            attackButton.BorderColor = Color.Black;
            attackButton.BorderRadius = 50;
            attackButton.BorderSize = 2;
            attackButton.FlatAppearance.BorderSize = 0;
            attackButton.FlatStyle = FlatStyle.Flat;
            attackButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            attackButton.ForeColor = Color.WhiteSmoke;
            attackButton.Location = new Point(540, 208);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(200, 200);
            attackButton.TabIndex = 1;
            attackButton.Text = "ATTACK";
            attackButton.TextColor = Color.WhiteSmoke;
            attackButton.UseVisualStyleBackColor = false;
            attackButton.Click += attackButton_Click;
            // 
            // upgradePowerAttackButton
            // 
            upgradePowerAttackButton.BackColor = Color.Orange;
            upgradePowerAttackButton.BackgroundColor = Color.Orange;
            upgradePowerAttackButton.BorderColor = Color.Black;
            upgradePowerAttackButton.BorderRadius = 20;
            upgradePowerAttackButton.BorderSize = 2;
            upgradePowerAttackButton.FlatAppearance.BorderSize = 0;
            upgradePowerAttackButton.FlatStyle = FlatStyle.Flat;
            upgradePowerAttackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            upgradePowerAttackButton.ForeColor = Color.WhiteSmoke;
            upgradePowerAttackButton.Image = Properties.Resources.coins;
            upgradePowerAttackButton.ImageAlign = ContentAlignment.MiddleRight;
            upgradePowerAttackButton.Location = new Point(515, 560);
            upgradePowerAttackButton.Name = "upgradePowerAttackButton";
            upgradePowerAttackButton.Padding = new Padding(0, 0, 5, 0);
            upgradePowerAttackButton.Size = new Size(250, 75);
            upgradePowerAttackButton.TabIndex = 3;
            upgradePowerAttackButton.Text = "  Upgrade \r\n  Power \r\n  Attack";
            upgradePowerAttackButton.TextAlign = ContentAlignment.MiddleLeft;
            upgradePowerAttackButton.TextColor = Color.WhiteSmoke;
            upgradePowerAttackButton.UseVisualStyleBackColor = false;
            upgradePowerAttackButton.Click += upgradePowerAttackButton_Click;
            // 
            // getTimeButton
            // 
            getTimeButton.BackColor = Color.Orange;
            getTimeButton.BackgroundColor = Color.Orange;
            getTimeButton.BorderColor = Color.Black;
            getTimeButton.BorderRadius = 20;
            getTimeButton.BorderSize = 2;
            getTimeButton.FlatAppearance.BorderSize = 0;
            getTimeButton.FlatStyle = FlatStyle.Flat;
            getTimeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            getTimeButton.ForeColor = Color.WhiteSmoke;
            getTimeButton.Image = Properties.Resources.coins;
            getTimeButton.ImageAlign = ContentAlignment.MiddleRight;
            getTimeButton.Location = new Point(930, 560);
            getTimeButton.Name = "getTimeButton";
            getTimeButton.Padding = new Padding(0, 0, 5, 0);
            getTimeButton.Size = new Size(250, 75);
            getTimeButton.TabIndex = 4;
            getTimeButton.Text = "  Get\r\n  Time";
            getTimeButton.TextAlign = ContentAlignment.MiddleLeft;
            getTimeButton.TextColor = Color.WhiteSmoke;
            getTimeButton.UseVisualStyleBackColor = false;
            getTimeButton.Click += getTimeButton_Click;
            // 
            // upgradeAttackButton
            // 
            upgradeAttackButton.BackColor = Color.Orange;
            upgradeAttackButton.BackgroundColor = Color.Orange;
            upgradeAttackButton.BorderColor = Color.Black;
            upgradeAttackButton.BorderRadius = 20;
            upgradeAttackButton.BorderSize = 2;
            upgradeAttackButton.FlatAppearance.BorderSize = 0;
            upgradeAttackButton.FlatStyle = FlatStyle.Flat;
            upgradeAttackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            upgradeAttackButton.ForeColor = Color.WhiteSmoke;
            upgradeAttackButton.Image = Properties.Resources.coins;
            upgradeAttackButton.ImageAlign = ContentAlignment.MiddleRight;
            upgradeAttackButton.Location = new Point(100, 560);
            upgradeAttackButton.Name = "upgradeAttackButton";
            upgradeAttackButton.Padding = new Padding(0, 0, 5, 0);
            upgradeAttackButton.Size = new Size(250, 75);
            upgradeAttackButton.TabIndex = 5;
            upgradeAttackButton.Text = "  Upgrade\r\n  Attack";
            upgradeAttackButton.TextAlign = ContentAlignment.MiddleLeft;
            upgradeAttackButton.TextColor = Color.WhiteSmoke;
            upgradeAttackButton.UseVisualStyleBackColor = false;
            upgradeAttackButton.Click += upgradeAttackButton_Click;
            // 
            // undoButton
            // 
            undoButton.BackColor = Color.Orange;
            undoButton.BackgroundColor = Color.Orange;
            undoButton.BorderColor = Color.Black;
            undoButton.BorderRadius = 20;
            undoButton.BorderSize = 2;
            undoButton.FlatAppearance.BorderSize = 0;
            undoButton.FlatStyle = FlatStyle.Flat;
            undoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            undoButton.ForeColor = Color.WhiteSmoke;
            undoButton.Location = new Point(515, 501);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(250, 40);
            undoButton.TabIndex = 6;
            undoButton.Text = "Undo Last Purchase";
            undoButton.TextColor = Color.WhiteSmoke;
            undoButton.UseVisualStyleBackColor = false;
            undoButton.Click += undoButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = Properties.Resources.Opponent;
            pictureBox1.InitialImage = Properties.Resources.Opponent;
            pictureBox1.Location = new Point(930, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 330);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.ErrorImage = Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            pictureBox2.InitialImage = Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            pictureBox2.Location = new Point(100, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 330);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.Red;
            healthBar.ForeColor = Color.White;
            healthBar.Location = new Point(1001, 55);
            healthBar.Name = "healthBar";
            healthBar.RightToLeft = RightToLeft.Yes;
            healthBar.Size = new Size(170, 30);
            healthBar.TabIndex = 9;
            // 
            // moneyBox
            // 
            moneyBox.AutoSize = true;
            moneyBox.BackColor = Color.Transparent;
            moneyBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            moneyBox.Location = new Point(185, 51);
            moneyBox.Name = "moneyBox";
            moneyBox.Size = new Size(157, 37);
            moneyBox.TabIndex = 11;
            moneyBox.Text = "                    ";
            moneyBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedButton5
            // 
            roundedButton5.BackColor = Color.Transparent;
            roundedButton5.BackgroundColor = Color.Transparent;
            roundedButton5.BorderColor = Color.Black;
            roundedButton5.BorderRadius = 20;
            roundedButton5.BorderSize = 2;
            roundedButton5.Enabled = false;
            roundedButton5.FlatAppearance.BorderSize = 0;
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton5.ForeColor = Color.WhiteSmoke;
            roundedButton5.Image = Properties.Resources.coins;
            roundedButton5.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton5.Location = new Point(100, 30);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Padding = new Padding(5, 0, 0, 0);
            roundedButton5.Size = new Size(250, 75);
            roundedButton5.TabIndex = 12;
            roundedButton5.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton5.TextColor = Color.WhiteSmoke;
            roundedButton5.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.heart;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(936, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 50);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // roundedButton6
            // 
            roundedButton6.BackColor = Color.Transparent;
            roundedButton6.BackgroundColor = Color.Transparent;
            roundedButton6.BorderColor = Color.Black;
            roundedButton6.BorderRadius = 20;
            roundedButton6.BorderSize = 2;
            roundedButton6.Enabled = false;
            roundedButton6.FlatAppearance.BorderSize = 0;
            roundedButton6.FlatStyle = FlatStyle.Flat;
            roundedButton6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton6.ForeColor = Color.WhiteSmoke;
            roundedButton6.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton6.Location = new Point(930, 30);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(250, 75);
            roundedButton6.TabIndex = 14;
            roundedButton6.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton6.TextColor = Color.WhiteSmoke;
            roundedButton6.UseVisualStyleBackColor = false;
            // 
            // roundedButton7
            // 
            roundedButton7.BackColor = Color.Transparent;
            roundedButton7.BackgroundColor = Color.Transparent;
            roundedButton7.BorderColor = Color.Black;
            roundedButton7.BorderRadius = 20;
            roundedButton7.BorderSize = 2;
            roundedButton7.Enabled = false;
            roundedButton7.FlatAppearance.BorderSize = 0;
            roundedButton7.FlatStyle = FlatStyle.Flat;
            roundedButton7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton7.ForeColor = Color.WhiteSmoke;
            roundedButton7.Image = Properties.Resources.timer1;
            roundedButton7.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton7.Location = new Point(515, 30);
            roundedButton7.Margin = new Padding(15, 3, 3, 3);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Padding = new Padding(5, 0, 0, 0);
            roundedButton7.Size = new Size(250, 75);
            roundedButton7.TabIndex = 16;
            roundedButton7.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton7.TextColor = Color.WhiteSmoke;
            roundedButton7.UseVisualStyleBackColor = false;
            // 
            // upgradeAttackCost
            // 
            upgradeAttackCost.AutoSize = true;
            upgradeAttackCost.BackColor = Color.Orange;
            upgradeAttackCost.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            upgradeAttackCost.Location = new Point(187, 579);
            upgradeAttackCost.Name = "upgradeAttackCost";
            upgradeAttackCost.Size = new Size(73, 37);
            upgradeAttackCost.TabIndex = 17;
            upgradeAttackCost.Text = "        ";
            upgradeAttackCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upgradePowerAttackCost
            // 
            upgradePowerAttackCost.AutoSize = true;
            upgradePowerAttackCost.BackColor = Color.Orange;
            upgradePowerAttackCost.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            upgradePowerAttackCost.Location = new Point(606, 580);
            upgradePowerAttackCost.Name = "upgradePowerAttackCost";
            upgradePowerAttackCost.Size = new Size(73, 37);
            upgradePowerAttackCost.TabIndex = 18;
            upgradePowerAttackCost.Text = "        ";
            upgradePowerAttackCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // getTimeCost
            // 
            getTimeCost.AutoSize = true;
            getTimeCost.BackColor = Color.Orange;
            getTimeCost.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            getTimeCost.Location = new Point(1010, 579);
            getTimeCost.Name = "getTimeCost";
            getTimeCost.Size = new Size(73, 37);
            getTimeCost.TabIndex = 19;
            getTimeCost.Text = "        ";
            getTimeCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.Firebrick;
            timerLabel.Location = new Point(583, 51);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(157, 37);
            timerLabel.TabIndex = 20;
            timerLabel.Text = "                    ";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // replayContinueButton
            // 
            replayContinueButton.BackColor = Color.Lavender;
            replayContinueButton.BackgroundColor = Color.Lavender;
            replayContinueButton.BorderColor = Color.Black;
            replayContinueButton.BorderRadius = 20;
            replayContinueButton.BorderSize = 2;
            replayContinueButton.Enabled = false;
            replayContinueButton.FlatAppearance.BorderSize = 0;
            replayContinueButton.FlatStyle = FlatStyle.Flat;
            replayContinueButton.ForeColor = Color.White;
            replayContinueButton.Location = new Point(540, 437);
            replayContinueButton.Name = "replayContinueButton";
            replayContinueButton.Size = new Size(200, 40);
            replayContinueButton.TabIndex = 21;
            replayContinueButton.Text = "REPLAYBUTTON";
            replayContinueButton.TextColor = Color.White;
            replayContinueButton.UseVisualStyleBackColor = false;
            replayContinueButton.Visible = false;
            replayContinueButton.Click += replayContinueButton_Click;
            // 
            // DefeatClickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(replayContinueButton);
            Controls.Add(timerLabel);
            Controls.Add(getTimeCost);
            Controls.Add(upgradePowerAttackCost);
            Controls.Add(upgradeAttackCost);
            Controls.Add(roundedButton7);
            Controls.Add(pictureBox3);
            Controls.Add(moneyBox);
            Controls.Add(healthBar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(undoButton);
            Controls.Add(upgradeAttackButton);
            Controls.Add(getTimeButton);
            Controls.Add(upgradePowerAttackButton);
            Controls.Add(attackButton);
            Controls.Add(roundedButton5);
            Controls.Add(roundedButton6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DefeatClickerForm";
            Text = "DEFEAT CLICKER";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Custom_Buttons.RoundedButton attackButton;
        private Custom_Buttons.RoundedButton upgradePowerAttackButton;
        private Custom_Buttons.RoundedButton getTimeButton;
        private Custom_Buttons.RoundedButton upgradeAttackButton;
        private Custom_Buttons.RoundedButton undoButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ProgressBar healthBar;
        private Label moneyBox;
        private Custom_Buttons.RoundedButton roundedButton5;
        private PictureBox pictureBox3;
        private Custom_Buttons.RoundedButton roundedButton6;
        private Custom_Buttons.RoundedButton roundedButton7;
        private Label upgradeAttackCost;
        private Label upgradePowerAttackCost;
        private Label getTimeCost;
        private System.Windows.Forms.Timer timer1;
        private Label timerLabel;
        private Custom_Buttons.RoundedButton replayContinueButton;
    }
}