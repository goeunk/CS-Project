namespace DieGuessGame_WindowsForms_
{
    partial class GameForm
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
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.rtxtGameInfo = new System.Windows.Forms.RichTextBox();
            this.lblNumPlayed = new System.Windows.Forms.Label();
            this.lblNumWon = new System.Windows.Forms.Label();
            this.lblNumLost = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtUserGuessNumber = new System.Windows.Forms.TextBox();
            this.pbDieImage = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtxtStat = new System.Windows.Forms.RichTextBox();
            this.lblNumPlayedCount = new System.Windows.Forms.Label();
            this.lblPlayedCount = new System.Windows.Forms.Label();
            this.lblWonCount = new System.Windows.Forms.Label();
            this.lblLostCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Location = new System.Drawing.Point(51, 30);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(130, 20);
            this.lblGameInfo.TabIndex = 0;
            this.lblGameInfo.Text = "Game Information";
            // 
            // rtxtGameInfo
            // 
            this.rtxtGameInfo.Location = new System.Drawing.Point(51, 63);
            this.rtxtGameInfo.Name = "rtxtGameInfo";
            this.rtxtGameInfo.Size = new System.Drawing.Size(299, 120);
            this.rtxtGameInfo.TabIndex = 1;
            this.rtxtGameInfo.Text = "";
            // 
            // lblNumPlayed
            // 
            this.lblNumPlayed.AutoSize = true;
            this.lblNumPlayed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumPlayed.Location = new System.Drawing.Point(66, 77);
            this.lblNumPlayed.Name = "lblNumPlayed";
            this.lblNumPlayed.Size = new System.Drawing.Size(186, 20);
            this.lblNumPlayed.TabIndex = 2;
            this.lblNumPlayed.Text = "Number of Times Played:";
            // 
            // lblNumWon
            // 
            this.lblNumWon.AutoSize = true;
            this.lblNumWon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumWon.Location = new System.Drawing.Point(66, 112);
            this.lblNumWon.Name = "lblNumWon";
            this.lblNumWon.Size = new System.Drawing.Size(173, 20);
            this.lblNumWon.TabIndex = 2;
            this.lblNumWon.Text = "Number of Times Won:";
            // 
            // lblNumLost
            // 
            this.lblNumLost.AutoSize = true;
            this.lblNumLost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumLost.Location = new System.Drawing.Point(66, 146);
            this.lblNumLost.Name = "lblNumLost";
            this.lblNumLost.Size = new System.Drawing.Size(170, 20);
            this.lblNumLost.TabIndex = 2;
            this.lblNumLost.Text = "Number of Times Lost:";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGuess.Location = new System.Drawing.Point(51, 210);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(166, 20);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Text = "Enter your guess(1-6):";
            // 
            // txtUserGuessNumber
            // 
            this.txtUserGuessNumber.Location = new System.Drawing.Point(225, 207);
            this.txtUserGuessNumber.Name = "txtUserGuessNumber";
            this.txtUserGuessNumber.Size = new System.Drawing.Size(125, 27);
            this.txtUserGuessNumber.TabIndex = 4;
            this.txtUserGuessNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserGuessNumber_KeyPress);
            // 
            // pbDieImage
            // 
            this.pbDieImage.Location = new System.Drawing.Point(81, 256);
            this.pbDieImage.Name = "pbDieImage";
            this.pbDieImage.Size = new System.Drawing.Size(100, 100);
            this.pbDieImage.TabIndex = 5;
            this.pbDieImage.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Enabled = false;
            this.btnRoll.Location = new System.Drawing.Point(243, 266);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(94, 29);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.cmdRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(243, 327);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // rtxtStat
            // 
            this.rtxtStat.Location = new System.Drawing.Point(51, 385);
            this.rtxtStat.Name = "rtxtStat";
            this.rtxtStat.Size = new System.Drawing.Size(700, 227);
            this.rtxtStat.TabIndex = 7;
            this.rtxtStat.Text = "";
            this.rtxtStat.TextChanged += new System.EventHandler(this.rtxtStat_TextChanged);
            // 
            // lblNumPlayedCount
            // 
            this.lblNumPlayedCount.AutoSize = true;
            this.lblNumPlayedCount.Location = new System.Drawing.Point(-25, -124);
            this.lblNumPlayedCount.Name = "lblNumPlayedCount";
            this.lblNumPlayedCount.Size = new System.Drawing.Size(0, 20);
            this.lblNumPlayedCount.TabIndex = 8;
            // 
            // lblPlayedCount
            // 
            this.lblPlayedCount.AutoSize = true;
            this.lblPlayedCount.Location = new System.Drawing.Point(258, 77);
            this.lblPlayedCount.Name = "lblPlayedCount";
            this.lblPlayedCount.Size = new System.Drawing.Size(17, 20);
            this.lblPlayedCount.TabIndex = 9;
            this.lblPlayedCount.Text = "0";
            // 
            // lblWonCount
            // 
            this.lblWonCount.AutoSize = true;
            this.lblWonCount.Location = new System.Drawing.Point(258, 112);
            this.lblWonCount.Name = "lblWonCount";
            this.lblWonCount.Size = new System.Drawing.Size(17, 20);
            this.lblWonCount.TabIndex = 9;
            this.lblWonCount.Text = "0";
            // 
            // lblLostCount
            // 
            this.lblLostCount.AutoSize = true;
            this.lblLostCount.Location = new System.Drawing.Point(258, 146);
            this.lblLostCount.Name = "lblLostCount";
            this.lblLostCount.Size = new System.Drawing.Size(17, 20);
            this.lblLostCount.TabIndex = 9;
            this.lblLostCount.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.lblLostCount);
            this.Controls.Add(this.lblWonCount);
            this.Controls.Add(this.lblPlayedCount);
            this.Controls.Add(this.lblNumPlayedCount);
            this.Controls.Add(this.rtxtStat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pbDieImage);
            this.Controls.Add(this.txtUserGuessNumber);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblNumLost);
            this.Controls.Add(this.lblNumWon);
            this.Controls.Add(this.lblNumPlayed);
            this.Controls.Add(this.rtxtGameInfo);
            this.Controls.Add(this.lblGameInfo);
            this.Name = "GameForm";
            this.Text = "Die Guess Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbDieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.RichTextBox rtxtGameInfo;
        private System.Windows.Forms.Label lblNumPlayed;
        private System.Windows.Forms.Label lblNumWon;
        private System.Windows.Forms.Label lblNumLost;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtUserGuessNumber;
        private System.Windows.Forms.PictureBox pbDieImage;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtxtStat;
        private System.Windows.Forms.Label lblNumPlayedCount;
        private System.Windows.Forms.Label lblPlayedCount;
        private System.Windows.Forms.Label lblWonCount;
        private System.Windows.Forms.Label lblLostCount;
    }
}

