namespace WFA190919F12
{
    partial class FrmHelloWorld
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
            this.lblHW = new System.Windows.Forms.Label();
            this.btnCims = new System.Windows.Forms.Button();
            this.btnMB = new System.Windows.Forms.Button();
            this.btnFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHW
            // 
            this.lblHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHW.Location = new System.Drawing.Point(12, 9);
            this.lblHW.Name = "lblHW";
            this.lblHW.Size = new System.Drawing.Size(357, 63);
            this.lblHW.TabIndex = 0;
            this.lblHW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCims
            // 
            this.btnCims.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCims.Location = new System.Drawing.Point(12, 75);
            this.btnCims.Name = "btnCims";
            this.btnCims.Size = new System.Drawing.Size(357, 50);
            this.btnCims.TabIndex = 1;
            this.btnCims.Text = "Címsor";
            this.btnCims.UseVisualStyleBackColor = true;
            this.btnCims.Click += new System.EventHandler(this.BtnHW_Click);
            // 
            // btnMB
            // 
            this.btnMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMB.Location = new System.Drawing.Point(12, 187);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(357, 50);
            this.btnMB.TabIndex = 1;
            this.btnMB.Text = "Üzenet";
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.BtnMB_Click);
            // 
            // btnFrm
            // 
            this.btnFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrm.Location = new System.Drawing.Point(12, 131);
            this.btnFrm.Name = "btnFrm";
            this.btnFrm.Size = new System.Drawing.Size(357, 50);
            this.btnFrm.TabIndex = 1;
            this.btnFrm.Text = "Form";
            this.btnFrm.UseVisualStyleBackColor = true;
            this.btnFrm.Click += new System.EventHandler(this.BtnFrm_Click);
            // 
            // FrmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 253);
            this.Controls.Add(this.btnFrm);
            this.Controls.Add(this.btnMB);
            this.Controls.Add(this.btnCims);
            this.Controls.Add(this.lblHW);
            this.Name = "FrmHelloWorld";
            this.Text = "-- EZ ITT A CÍMSOR --";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHW;
        private System.Windows.Forms.Button btnCims;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Button btnFrm;
    }
}