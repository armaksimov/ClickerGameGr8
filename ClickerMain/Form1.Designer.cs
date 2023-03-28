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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefeatClickerForm));
            this.attackButton = new ClickerMain.Custom_Buttons.RoundedButton();
            this.upgradePowerAttackButton = new ClickerMain.Custom_Buttons.RoundedButton();
            this.getTimeButton = new ClickerMain.Custom_Buttons.RoundedButton();
            this.upgradeAttackButton = new ClickerMain.Custom_Buttons.RoundedButton();
            this.undoButton = new ClickerMain.Custom_Buttons.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.moneyBox = new System.Windows.Forms.Label();
            this.roundedButton5 = new ClickerMain.Custom_Buttons.RoundedButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundedButton6 = new ClickerMain.Custom_Buttons.RoundedButton();
            this.timerBox = new System.Windows.Forms.Label();
            this.roundedButton7 = new ClickerMain.Custom_Buttons.RoundedButton();
            this.upgradeAttackCost = new System.Windows.Forms.Label();
            this.upgradePowerAttackCost = new System.Windows.Forms.Label();
            this.getTimeCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackButton.BackColor = System.Drawing.Color.DarkGreen;
            this.attackButton.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.attackButton.BorderColor = System.Drawing.Color.Black;
            this.attackButton.BorderRadius = 50;
            this.attackButton.BorderSize = 2;
            this.attackButton.FlatAppearance.BorderSize = 0;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.attackButton.Location = new System.Drawing.Point(540, 208);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(200, 200);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "ATTACK";
            this.attackButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // upgradePowerAttackButton
            // 
            this.upgradePowerAttackButton.BackColor = System.Drawing.Color.Orange;
            this.upgradePowerAttackButton.BackgroundColor = System.Drawing.Color.Orange;
            this.upgradePowerAttackButton.BorderColor = System.Drawing.Color.Black;
            this.upgradePowerAttackButton.BorderRadius = 20;
            this.upgradePowerAttackButton.BorderSize = 2;
            this.upgradePowerAttackButton.FlatAppearance.BorderSize = 0;
            this.upgradePowerAttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradePowerAttackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upgradePowerAttackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.upgradePowerAttackButton.Image = global::ClickerMain.Properties.Resources.coins;
            this.upgradePowerAttackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upgradePowerAttackButton.Location = new System.Drawing.Point(515, 560);
            this.upgradePowerAttackButton.Name = "upgradePowerAttackButton";
            this.upgradePowerAttackButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.upgradePowerAttackButton.Size = new System.Drawing.Size(250, 75);
            this.upgradePowerAttackButton.TabIndex = 3;
            this.upgradePowerAttackButton.Text = "  Upgrade \r\n  Power \r\n  Attack";
            this.upgradePowerAttackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upgradePowerAttackButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.upgradePowerAttackButton.UseVisualStyleBackColor = false;
            this.upgradePowerAttackButton.Click += new System.EventHandler(this.upgradePowerAttackButton_Click);
            // 
            // getTimeButton
            // 
            this.getTimeButton.BackColor = System.Drawing.Color.Orange;
            this.getTimeButton.BackgroundColor = System.Drawing.Color.Orange;
            this.getTimeButton.BorderColor = System.Drawing.Color.Black;
            this.getTimeButton.BorderRadius = 20;
            this.getTimeButton.BorderSize = 2;
            this.getTimeButton.FlatAppearance.BorderSize = 0;
            this.getTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTimeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getTimeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.getTimeButton.Image = global::ClickerMain.Properties.Resources.coins;
            this.getTimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.getTimeButton.Location = new System.Drawing.Point(930, 560);
            this.getTimeButton.Name = "getTimeButton";
            this.getTimeButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.getTimeButton.Size = new System.Drawing.Size(250, 75);
            this.getTimeButton.TabIndex = 4;
            this.getTimeButton.Text = "  Get\r\n  Time";
            this.getTimeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getTimeButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.getTimeButton.UseVisualStyleBackColor = false;
            this.getTimeButton.Click += new System.EventHandler(this.getTimeButton_Click);
            // 
            // upgradeAttackButton
            // 
            this.upgradeAttackButton.BackColor = System.Drawing.Color.Orange;
            this.upgradeAttackButton.BackgroundColor = System.Drawing.Color.Orange;
            this.upgradeAttackButton.BorderColor = System.Drawing.Color.Black;
            this.upgradeAttackButton.BorderRadius = 20;
            this.upgradeAttackButton.BorderSize = 2;
            this.upgradeAttackButton.FlatAppearance.BorderSize = 0;
            this.upgradeAttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeAttackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upgradeAttackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.upgradeAttackButton.Image = global::ClickerMain.Properties.Resources.coins;
            this.upgradeAttackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upgradeAttackButton.Location = new System.Drawing.Point(100, 560);
            this.upgradeAttackButton.Name = "upgradeAttackButton";
            this.upgradeAttackButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.upgradeAttackButton.Size = new System.Drawing.Size(250, 75);
            this.upgradeAttackButton.TabIndex = 5;
            this.upgradeAttackButton.Text = "  Upgrade\r\n  Attack";
            this.upgradeAttackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upgradeAttackButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.upgradeAttackButton.UseVisualStyleBackColor = false;
            this.upgradeAttackButton.Click += new System.EventHandler(this.upgradeAttackButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Orange;
            this.undoButton.BackgroundColor = System.Drawing.Color.Orange;
            this.undoButton.BorderColor = System.Drawing.Color.Black;
            this.undoButton.BorderRadius = 20;
            this.undoButton.BorderSize = 2;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.undoButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.undoButton.Location = new System.Drawing.Point(515, 501);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(250, 40);
            this.undoButton.TabIndex = 6;
            this.undoButton.Text = "Undo Last Purchase";
            this.undoButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::ClickerMain.Properties.Resources.Opponent;
            this.pictureBox1.InitialImage = global::ClickerMain.Properties.Resources.Opponent;
            this.pictureBox1.Location = new System.Drawing.Point(930, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 330);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClickerMain.Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = global::ClickerMain.Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            this.pictureBox2.InitialImage = global::ClickerMain.Properties.Resources._5f2100e27b0f099410ee48ff11c9838d;
            this.pictureBox2.Location = new System.Drawing.Point(100, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 330);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Red;
            this.healthBar.ForeColor = System.Drawing.Color.White;
            this.healthBar.Location = new System.Drawing.Point(1001, 55);
            this.healthBar.Name = "healthBar";
            this.healthBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.healthBar.Size = new System.Drawing.Size(170, 30);
            this.healthBar.TabIndex = 9;
            // 
            // moneyBox
            // 
            this.moneyBox.AutoSize = true;
            this.moneyBox.BackColor = System.Drawing.Color.Transparent;
            this.moneyBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moneyBox.Location = new System.Drawing.Point(185, 51);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(157, 37);
            this.moneyBox.TabIndex = 11;
            this.moneyBox.Text = "                    ";
            this.moneyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButton5.BorderColor = System.Drawing.Color.Black;
            this.roundedButton5.BorderRadius = 20;
            this.roundedButton5.BorderSize = 2;
            this.roundedButton5.Enabled = false;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton5.Image = global::ClickerMain.Properties.Resources.coins;
            this.roundedButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton5.Location = new System.Drawing.Point(100, 30);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.roundedButton5.Size = new System.Drawing.Size(250, 75);
            this.roundedButton5.TabIndex = 12;
            this.roundedButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton5.TextColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton5.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::ClickerMain.Properties.Resources.heart;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(936, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton6.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButton6.BorderColor = System.Drawing.Color.Black;
            this.roundedButton6.BorderRadius = 20;
            this.roundedButton6.BorderSize = 2;
            this.roundedButton6.Enabled = false;
            this.roundedButton6.FlatAppearance.BorderSize = 0;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.Location = new System.Drawing.Point(930, 30);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Size = new System.Drawing.Size(250, 75);
            this.roundedButton6.TabIndex = 14;
            this.roundedButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.TextColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton6.UseVisualStyleBackColor = false;
            // 
            // timerBox
            // 
            this.timerBox.AutoSize = true;
            this.timerBox.BackColor = System.Drawing.Color.Transparent;
            this.timerBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.timerBox.Location = new System.Drawing.Point(594, 51);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(157, 37);
            this.timerBox.TabIndex = 15;
            this.timerBox.Text = "                    ";
            this.timerBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton7.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButton7.BorderColor = System.Drawing.Color.Black;
            this.roundedButton7.BorderRadius = 20;
            this.roundedButton7.BorderSize = 2;
            this.roundedButton7.Enabled = false;
            this.roundedButton7.FlatAppearance.BorderSize = 0;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton7.Image = global::ClickerMain.Properties.Resources.timer1;
            this.roundedButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton7.Location = new System.Drawing.Point(515, 30);
            this.roundedButton7.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.roundedButton7.Size = new System.Drawing.Size(250, 75);
            this.roundedButton7.TabIndex = 16;
            this.roundedButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton7.TextColor = System.Drawing.Color.WhiteSmoke;
            this.roundedButton7.UseVisualStyleBackColor = false;
            // 
            // upgradeAttackCost
            // 
            this.upgradeAttackCost.AutoSize = true;
            this.upgradeAttackCost.BackColor = System.Drawing.Color.Orange;
            this.upgradeAttackCost.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upgradeAttackCost.Location = new System.Drawing.Point(187, 579);
            this.upgradeAttackCost.Name = "upgradeAttackCost";
            this.upgradeAttackCost.Size = new System.Drawing.Size(73, 37);
            this.upgradeAttackCost.TabIndex = 17;
            this.upgradeAttackCost.Text = "        ";
            this.upgradeAttackCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradePowerAttackCost
            // 
            this.upgradePowerAttackCost.AutoSize = true;
            this.upgradePowerAttackCost.BackColor = System.Drawing.Color.Orange;
            this.upgradePowerAttackCost.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upgradePowerAttackCost.Location = new System.Drawing.Point(606, 580);
            this.upgradePowerAttackCost.Name = "upgradePowerAttackCost";
            this.upgradePowerAttackCost.Size = new System.Drawing.Size(73, 37);
            this.upgradePowerAttackCost.TabIndex = 18;
            this.upgradePowerAttackCost.Text = "        ";
            this.upgradePowerAttackCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getTimeCost
            // 
            this.getTimeCost.AutoSize = true;
            this.getTimeCost.BackColor = System.Drawing.Color.Orange;
            this.getTimeCost.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getTimeCost.Location = new System.Drawing.Point(1010, 579);
            this.getTimeCost.Name = "getTimeCost";
            this.getTimeCost.Size = new System.Drawing.Size(73, 37);
            this.getTimeCost.TabIndex = 19;
            this.getTimeCost.Text = "        ";
            this.getTimeCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefeatClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.getTimeCost);
            this.Controls.Add(this.upgradePowerAttackCost);
            this.Controls.Add(this.upgradeAttackCost);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.roundedButton7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.upgradeAttackButton);
            this.Controls.Add(this.getTimeButton);
            this.Controls.Add(this.upgradePowerAttackButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.roundedButton5);
            this.Controls.Add(this.roundedButton6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefeatClickerForm";
            this.Text = "DEFEAT CLICKER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label timerBox;
        private Custom_Buttons.RoundedButton roundedButton7;
        private Label upgradeAttackCost;
        private Label upgradePowerAttackCost;
        private Label getTimeCost;
    }
}