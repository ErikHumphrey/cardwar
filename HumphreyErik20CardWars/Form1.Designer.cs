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
            this.lblTitleCPU = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblScoreCPU = new System.Windows.Forms.Label();
            this.lblScoreUser = new System.Windows.Forms.Label();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.picCardUser = new System.Windows.Forms.PictureBox();
            this.picCardCPU = new System.Windows.Forms.PictureBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblCard2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCardUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGameNextCard
            // 
            this.btnNewGameNextCard.Location = new System.Drawing.Point(124, 304);
            this.btnNewGameNextCard.Name = "btnNewGameNextCard";
            this.btnNewGameNextCard.Size = new System.Drawing.Size(75, 23);
            this.btnNewGameNextCard.TabIndex = 0;
            this.btnNewGameNextCard.Text = "New game";
            this.btnNewGameNextCard.UseVisualStyleBackColor = true;
            this.btnNewGameNextCard.Click += new System.EventHandler(this.btnNewGameNextCard_Click);
            // 
            // btnQuitStop
            // 
            this.btnQuitStop.Location = new System.Drawing.Point(124, 333);
            this.btnQuitStop.Name = "btnQuitStop";
            this.btnQuitStop.Size = new System.Drawing.Size(75, 23);
            this.btnQuitStop.TabIndex = 1;
            this.btnQuitStop.Text = "Quit game";
            this.btnQuitStop.UseVisualStyleBackColor = true;
            this.btnQuitStop.Click += new System.EventHandler(this.btnQuitStop_Click);
            // 
            // lblTitleCPU
            // 
            this.lblTitleCPU.AutoSize = true;
            this.lblTitleCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCPU.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCPU.Location = new System.Drawing.Point(203, 13);
            this.lblTitleCPU.Name = "lblTitleCPU";
            this.lblTitleCPU.Size = new System.Drawing.Size(41, 29);
            this.lblTitleCPU.TabIndex = 3;
            this.lblTitleCPU.Text = "CPU";
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleUser.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUser.Location = new System.Drawing.Point(65, 13);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(43, 29);
            this.lblTitleUser.TabIndex = 4;
            this.lblTitleUser.Text = "YOU";
            // 
            // lblScoreCPU
            // 
            this.lblScoreCPU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblScoreCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCPU.Location = new System.Drawing.Point(196, 42);
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
            this.lblScoreUser.Location = new System.Drawing.Point(60, 42);
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
            this.lblStatusMessage.Location = new System.Drawing.Point(40, 263);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(226, 30);
            this.lblStatusMessage.TabIndex = 9;
            this.lblStatusMessage.Text = "Click \"New game\" to begin.";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCardUser
            // 
            this.picCardUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCardUser.Image = global::HumphreyErik20CardWars.Properties.Resources.BlueBack;
            this.picCardUser.Location = new System.Drawing.Point(21, 106);
            this.picCardUser.Name = "picCardUser";
            this.picCardUser.Size = new System.Drawing.Size(135, 143);
            this.picCardUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardUser.TabIndex = 10;
            this.picCardUser.TabStop = false;
            this.picCardUser.Click += new System.EventHandler(this.picCardUser_Click);
            // 
            // picCardCPU
            // 
            this.picCardCPU.Image = global::HumphreyErik20CardWars.Properties.Resources.RedBack;
            this.picCardCPU.Location = new System.Drawing.Point(157, 106);
            this.picCardCPU.Name = "picCardCPU";
            this.picCardCPU.Size = new System.Drawing.Size(135, 143);
            this.picCardCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardCPU.TabIndex = 11;
            this.picCardCPU.TabStop = false;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(231, 309);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(35, 13);
            this.lblCard.TabIndex = 12;
            this.lblCard.Text = "label1";
            // 
            // lblCard2
            // 
            this.lblCard2.AutoSize = true;
            this.lblCard2.Location = new System.Drawing.Point(231, 333);
            this.lblCard2.Name = "lblCard2";
            this.lblCard2.Size = new System.Drawing.Size(35, 13);
            this.lblCard2.TabIndex = 13;
            this.lblCard2.Text = "label1";
            // 
            // frmCardWars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 368);
            this.Controls.Add(this.lblCard2);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.picCardUser);
            this.Controls.Add(this.picCardCPU);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.lblScoreUser);
            this.Controls.Add(this.lblScoreCPU);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.lblTitleCPU);
            this.Controls.Add(this.btnQuitStop);
            this.Controls.Add(this.btnNewGameNextCard);
            this.Name = "frmCardWars";
            this.Text = "Card Wars";
            this.Load += new System.EventHandler(this.frmCardWars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCardUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGameNextCard;
        private System.Windows.Forms.Button btnQuitStop;
        private System.Windows.Forms.Label lblTitleCPU;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.Label lblScoreCPU;
        private System.Windows.Forms.Label lblScoreUser;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.PictureBox picCardUser;
        private System.Windows.Forms.PictureBox picCardCPU;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblCard2;
    }
}

