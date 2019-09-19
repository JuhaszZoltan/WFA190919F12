namespace WFA190919F12
{
    partial class FrmBtnEvents
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn.Location = new System.Drawing.Point(87, 78);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(337, 170);
            this.btn.TabIndex = 0;
            this.btn.Text = "Ez EgY GoMb";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            this.btn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseMove);
            // 
            // FrmBtnEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 325);
            this.Controls.Add(this.btn);
            this.Name = "FrmBtnEvents";
            this.Text = "-- EZ ITT A CÍMSOR --";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
    }
}