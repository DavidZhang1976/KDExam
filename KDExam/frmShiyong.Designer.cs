namespace KDExam
{
    partial class frmShiyong
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
            this.btnCeshi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCeshi
            // 
            this.btnCeshi.Location = new System.Drawing.Point(174, 236);
            this.btnCeshi.Name = "btnCeshi";
            this.btnCeshi.Size = new System.Drawing.Size(120, 44);
            this.btnCeshi.TabIndex = 0;
            this.btnCeshi.Text = "免费测试";
            this.btnCeshi.UseVisualStyleBackColor = true;
            // 
            // frmShiyong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 352);
            this.Controls.Add(this.btnCeshi);
            this.Name = "frmShiyong";
            this.Text = "frmShiyong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCeshi;
    }
}