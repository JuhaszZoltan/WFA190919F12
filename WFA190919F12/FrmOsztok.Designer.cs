namespace WFA190919F12
{
    partial class FrmOsztok
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSzam = new System.Windows.Forms.TextBox();
            this.btnOsztok = new System.Windows.Forms.Button();
            this.lbOsztok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám:";
            // 
            // tbSzam
            // 
            this.tbSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzam.Location = new System.Drawing.Point(124, 12);
            this.tbSzam.Name = "tbSzam";
            this.tbSzam.Size = new System.Drawing.Size(153, 29);
            this.tbSzam.TabIndex = 1;
            // 
            // btnOsztok
            // 
            this.btnOsztok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsztok.Location = new System.Drawing.Point(16, 47);
            this.btnOsztok.Name = "btnOsztok";
            this.btnOsztok.Size = new System.Drawing.Size(261, 45);
            this.btnOsztok.TabIndex = 2;
            this.btnOsztok.Text = "Osztók";
            this.btnOsztok.UseVisualStyleBackColor = true;
            this.btnOsztok.Click += new System.EventHandler(this.BtnOsztok_Click);
            // 
            // lbOsztok
            // 
            this.lbOsztok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOsztok.FormattingEnabled = true;
            this.lbOsztok.ItemHeight = 24;
            this.lbOsztok.Location = new System.Drawing.Point(16, 98);
            this.lbOsztok.Name = "lbOsztok";
            this.lbOsztok.Size = new System.Drawing.Size(261, 268);
            this.lbOsztok.TabIndex = 3;
            // 
            // FrmOsztok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 388);
            this.Controls.Add(this.lbOsztok);
            this.Controls.Add(this.btnOsztok);
            this.Controls.Add(this.tbSzam);
            this.Controls.Add(this.label1);
            this.Name = "FrmOsztok";
            this.Text = "FrmOsztok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSzam;
        private System.Windows.Forms.Button btnOsztok;
        private System.Windows.Forms.ListBox lbOsztok;
    }
}