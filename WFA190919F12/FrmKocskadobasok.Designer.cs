namespace WFA190919F12
{
    partial class FrmKocskadobasok
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
            this.tbDb = new System.Windows.Forms.TextBox();
            this.btnDobas = new System.Windows.Forms.Button();
            this.rtbDobasok = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány kockadobást kérsz?";
            // 
            // tbDb
            // 
            this.tbDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDb.Location = new System.Drawing.Point(241, 12);
            this.tbDb.Name = "tbDb";
            this.tbDb.Size = new System.Drawing.Size(150, 29);
            this.tbDb.TabIndex = 2;
            // 
            // btnDobas
            // 
            this.btnDobas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDobas.Location = new System.Drawing.Point(16, 332);
            this.btnDobas.Name = "btnDobas";
            this.btnDobas.Size = new System.Drawing.Size(375, 45);
            this.btnDobas.TabIndex = 3;
            this.btnDobas.Text = "Dobás";
            this.btnDobas.UseVisualStyleBackColor = true;
            this.btnDobas.Click += new System.EventHandler(this.BtnDobas_Click);
            // 
            // rtbDobasok
            // 
            this.rtbDobasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbDobasok.Location = new System.Drawing.Point(16, 48);
            this.rtbDobasok.Name = "rtbDobasok";
            this.rtbDobasok.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDobasok.Size = new System.Drawing.Size(375, 278);
            this.rtbDobasok.TabIndex = 4;
            this.rtbDobasok.Text = "";
            // 
            // FrmKocskadobasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 389);
            this.Controls.Add(this.rtbDobasok);
            this.Controls.Add(this.btnDobas);
            this.Controls.Add(this.tbDb);
            this.Controls.Add(this.label1);
            this.Name = "FrmKocskadobasok";
            this.Text = "FrmKocskadobasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDb;
        private System.Windows.Forms.Button btnDobas;
        private System.Windows.Forms.RichTextBox rtbDobasok;
    }
}