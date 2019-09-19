namespace WFA190919F12
{
    partial class FrmColorz
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
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.btnAlap = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSzoveg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.Location = new System.Drawing.Point(12, 100);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(339, 52);
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Green;
            this.pbGreen.Location = new System.Drawing.Point(12, 190);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(339, 52);
            this.pbGreen.TabIndex = 0;
            this.pbGreen.TabStop = false;
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.Blue;
            this.pbBlue.Location = new System.Drawing.Point(12, 280);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(339, 52);
            this.pbBlue.TabIndex = 0;
            this.pbBlue.TabStop = false;
            // 
            // pbYellow
            // 
            this.pbYellow.BackColor = System.Drawing.Color.Yellow;
            this.pbYellow.Location = new System.Drawing.Point(12, 370);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(339, 52);
            this.pbYellow.TabIndex = 0;
            this.pbYellow.TabStop = false;
            // 
            // btnAlap
            // 
            this.btnAlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlap.Location = new System.Drawing.Point(12, 465);
            this.btnAlap.Name = "btnAlap";
            this.btnAlap.Size = new System.Drawing.Size(148, 55);
            this.btnAlap.TabIndex = 1;
            this.btnAlap.Text = "Alaphelyzet";
            this.btnAlap.UseVisualStyleBackColor = true;
            this.btnAlap.Click += new System.EventHandler(this.BtnAlap_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(203, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblSzoveg
            // 
            this.lblSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzoveg.Location = new System.Drawing.Point(12, 24);
            this.lblSzoveg.Name = "lblSzoveg";
            this.lblSzoveg.Size = new System.Drawing.Size(339, 52);
            this.lblSzoveg.TabIndex = 2;
            this.lblSzoveg.Text = "Kattints valamelyik színes téglalapra!";
            this.lblSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmColorz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 558);
            this.Controls.Add(this.lblSzoveg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAlap);
            this.Controls.Add(this.pbYellow);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Name = "FrmColorz";
            this.Text = "FrmColorz";
            this.BackColorChanged += new System.EventHandler(this.FrmColorz_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.Button btnAlap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSzoveg;
    }
}