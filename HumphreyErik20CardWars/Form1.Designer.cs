namespace HumphreyErik20CardWars
{
    partial class frmCardWars
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
            this.btnNewGameNextCard = new System.Windows.Forms.Button();
            this.btnQuitStop = new System.Windows.Forms.Button();
            this.lblScoreCPUTitle = new System.Windows.Forms.Label();
            this.lblScoreUserTitle = new System.Windows.Forms.Label();
            this.lblScoreCPU = new System.Windows.Forms.Label();
            this.lblScoreUser = new System.Windows.Forms.Label();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGameNextCard
            // 
            this.btnNewGameNextCard.Location = new System.Drawing.Point(434, 440);
            this.btnNewGameNextCard.Name = "btnNewGameNextCard";
            this.btnNewGameNextCard.Size = new System.Drawing.Size(75, 23);
            this.btnNewGameNextCard.TabIndex = 0;
            this.btnNewGameNextCard.Text = "New game";
            this.btnNewGameNextCard.UseVisualStyleBackColor = true;
            this.btnNewGameNextCard.Click += new System.EventHandler(this.btnNewGameNextCard_Click);
            // 
            // btnQuitStop
            // 
            this.btnQuitStop.Location = new System.Drawing.Point(434, 469);
            this.btnQuitStop.Name = "btnQuitStop";
            this.btnQuitStop.Size = new System.Drawing.Size(75, 23);
            this.btnQuitStop.TabIndex = 1;
            this.btnQuitStop.Text = "Quit game";
            this.btnQuitStop.UseVisualStyleBackColor = true;
            this.btnQuitStop.Click += new System.EventHandler(this.btnQuitStop_Click);
            // 
            // lblScoreCPUTitle
            // 
            this.lblScoreCPUTitle.AutoSize = true;
            this.lblScoreCPUTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreCPUTitle.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCPUTitle.Location = new System.Drawing.Point(163, 45);
            this.lblScoreCPUTitle.Name = "lblScoreCPUTitle";
            this.lblScoreCPUTitle.Size = new System.Drawing.Size(41, 29);
            this.lblScoreCPUTitle.TabIndex = 3;
            this.lblScoreCPUTitle.Text = "CPU";
            // 
            // lblScoreUserTitle
            // 
            this.lblScoreUserTitle.AutoSize = true;
            this.lblScoreUserTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreUserTitle.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreUserTitle.Location = new System.Drawing.Point(46, 45);
            this.lblScoreUserTitle.Name = "lblScoreUserTitle";
            this.lblScoreUserTitle.Size = new System.Drawing.Size(43, 29);
            this.lblScoreUserTitle.TabIndex = 4;
            this.lblScoreUserTitle.Text = "YOU";
            // 
            // lblScoreCPU
            // 
            this.lblScoreCPU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblScoreCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCPU.Location = new System.Drawing.Point(156, 74);
            this.lblScoreCPU.Name = "lblScoreCPU";
            this.lblScoreCPU.Size = new System.Drawing.Size(54, 54);
            this.lblScoreCPU.TabIndex = 6;
            this.lblScoreCPU.Text = "0";
            this.lblScoreCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreUser
            // 
            this.lblScoreUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblScoreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreUser.Location = new System.Drawing.Point(41, 74);
            this.lblScoreUser.Name = "lblScoreUser";
            this.lblScoreUser.Size = new System.Drawing.Size(54, 54);
            this.lblScoreUser.TabIndex = 8;
            this.lblScoreUser.Text = "0";
            this.lblScoreUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMessage.Location = new System.Drawing.Point(21, 155);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(226, 30);
            this.lblStatusMessage.TabIndex = 9;
            this.lblStatusMessage.Text = "Click \"New game\" to begin.";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCardWars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 540);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.lblScoreUser);
            this.Controls.Add(this.lblScoreCPU);
            this.Controls.Add(this.lblScoreUserTitle);
            this.Controls.Add(this.lblScoreCPUTitle);
            this.Controls.Add(this.btnQuitStop);
            this.Controls.Add(this.btnNewGameNextCard);
            this.Name = "frmCardWars";
            this.Text = "Card Wars";
            this.Load += new System.EventHandler(this.frmCardWars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGameNextCard;
        private System.Windows.Forms.Button btnQuitStop;
        private System.Windows.Forms.Label lblScoreCPUTitle;
        private System.Windows.Forms.Label lblScoreUserTitle;
        private System.Windows.Forms.Label lblScoreCPU;
        private System.Windows.Forms.Label lblScoreUser;
        private System.Windows.Forms.Label lblStatusMessage;
    }
}

