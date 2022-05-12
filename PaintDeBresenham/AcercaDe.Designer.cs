namespace PaintDeBresenham
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.iam = new System.Windows.Forms.PictureBox();
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iam)).BeginInit();
            this.SuspendLayout();
            // 
            // iam
            // 
            this.iam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iam.BackgroundImage")));
            this.iam.Image = ((System.Drawing.Image)(resources.GetObject("iam.Image")));
            this.iam.Location = new System.Drawing.Point(23, 19);
            this.iam.Name = "iam";
            this.iam.Size = new System.Drawing.Size(329, 442);
            this.iam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iam.TabIndex = 0;
            this.iam.TabStop = false;
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcercaDe.Location = new System.Drawing.Point(373, 187);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(300, 36);
            this.lblAcercaDe.TabIndex = 1;
            this.lblAcercaDe.Text = "Paint de Bresenham";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.Location = new System.Drawing.Point(492, 223);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(224, 36);
            this.lblBy.TabIndex = 2;
            this.lblBy.Text = "by Kevin Knight";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 482);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblAcercaDe);
            this.Controls.Add(this.iam);
            this.MaximizeBox = false;
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)(this.iam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iam;
        private System.Windows.Forms.Label lblAcercaDe;
        private System.Windows.Forms.Label lblBy;
    }
}