namespace WFA190919F12
{
    partial class FrmMuveletek
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnK = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.btnSz = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbA.Location = new System.Drawing.Point(12, 12);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(71, 68);
            this.tbA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(262, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnK.Location = new System.Drawing.Point(89, 48);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(42, 32);
            this.btnK.TabIndex = 2;
            this.btnK.Text = "-";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbB.Location = new System.Drawing.Point(185, 12);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(71, 68);
            this.tbB.TabIndex = 0;
            // 
            // tbE
            // 
            this.tbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbE.Location = new System.Drawing.Point(327, 12);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(172, 68);
            this.tbE.TabIndex = 0;
            // 
            // btnSz
            // 
            this.btnSz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSz.Location = new System.Drawing.Point(137, 12);
            this.btnSz.Name = "btnSz";
            this.btnSz.Size = new System.Drawing.Size(42, 32);
            this.btnSz.TabIndex = 2;
            this.btnSz.Text = "*";
            this.btnSz.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD.Location = new System.Drawing.Point(137, 48);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(42, 32);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "/";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnO.Location = new System.Drawing.Point(89, 12);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(42, 32);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "+";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDel.Location = new System.Drawing.Point(12, 86);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(487, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Törlés";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // FrmMuveletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 130);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnSz);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "FrmMuveletek";
            this.Text = "Muveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Button btnSz;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnDel;
    }
}