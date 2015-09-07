namespace KDExam
{
    partial class frmDagang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDagang = new System.Windows.Forms.Button();
            this.btnZhinan = new System.Windows.Forms.Button();
            this.btnJingyan = new System.Windows.Forms.Button();
            this.btnWenku = new System.Windows.Forms.Button();
            this.btnZixun = new System.Windows.Forms.Button();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnZixun);
            this.panel1.Controls.Add(this.btnWenku);
            this.panel1.Controls.Add(this.btnJingyan);
            this.panel1.Controls.Add(this.btnZhinan);
            this.panel1.Controls.Add(this.btnDagang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 311);
            this.panel1.TabIndex = 0;
            // 
            // btnDagang
            // 
            this.btnDagang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDagang.Location = new System.Drawing.Point(0, 1);
            this.btnDagang.Name = "btnDagang";
            this.btnDagang.Size = new System.Drawing.Size(154, 53);
            this.btnDagang.TabIndex = 0;
            this.btnDagang.Text = "考试大纲";
            this.btnDagang.UseVisualStyleBackColor = true;
            this.btnDagang.Click += new System.EventHandler(this.btnDagang_Click);
            // 
            // btnZhinan
            // 
            this.btnZhinan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZhinan.Location = new System.Drawing.Point(0, 60);
            this.btnZhinan.Name = "btnZhinan";
            this.btnZhinan.Size = new System.Drawing.Size(154, 53);
            this.btnZhinan.TabIndex = 1;
            this.btnZhinan.Text = "报考指南";
            this.btnZhinan.UseVisualStyleBackColor = true;
            this.btnZhinan.Click += new System.EventHandler(this.btnZhinan_Click);
            // 
            // btnJingyan
            // 
            this.btnJingyan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJingyan.Location = new System.Drawing.Point(0, 119);
            this.btnJingyan.Name = "btnJingyan";
            this.btnJingyan.Size = new System.Drawing.Size(154, 53);
            this.btnJingyan.TabIndex = 2;
            this.btnJingyan.Text = "过关经验";
            this.btnJingyan.UseVisualStyleBackColor = true;
            this.btnJingyan.Click += new System.EventHandler(this.btnJingyan_Click);
            // 
            // btnWenku
            // 
            this.btnWenku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWenku.Location = new System.Drawing.Point(0, 178);
            this.btnWenku.Name = "btnWenku";
            this.btnWenku.Size = new System.Drawing.Size(154, 53);
            this.btnWenku.TabIndex = 3;
            this.btnWenku.Text = "考试文库";
            this.btnWenku.UseVisualStyleBackColor = true;
            this.btnWenku.Click += new System.EventHandler(this.btnWenku_Click);
            // 
            // btnZixun
            // 
            this.btnZixun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZixun.Location = new System.Drawing.Point(0, 237);
            this.btnZixun.Name = "btnZixun";
            this.btnZixun.Size = new System.Drawing.Size(154, 53);
            this.btnZixun.TabIndex = 4;
            this.btnZixun.Text = "考试资讯";
            this.btnZixun.UseVisualStyleBackColor = true;
            this.btnZixun.Click += new System.EventHandler(this.btnZixun_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMain.Location = new System.Drawing.Point(156, 2);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(455, 308);
            this.rtbMain.TabIndex = 1;
            this.rtbMain.Text = "";
            // 
            // frmDagang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(612, 313);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.panel1);
            this.Name = "frmDagang";
            this.Text = "frmDagang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDagang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDagang;
        private System.Windows.Forms.Button btnZixun;
        private System.Windows.Forms.Button btnWenku;
        private System.Windows.Forms.Button btnJingyan;
        private System.Windows.Forms.Button btnZhinan;
        private System.Windows.Forms.RichTextBox rtbMain;
    }
}