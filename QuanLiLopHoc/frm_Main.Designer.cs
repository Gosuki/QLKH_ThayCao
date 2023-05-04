
namespace QuanLiLopHoc
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíKhóaHọcToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLíGiảngViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíKhóaHọcToolStripMenuItem
            // 
            this.quảnLíKhóaHọcToolStripMenuItem.Name = "quảnLíKhóaHọcToolStripMenuItem";
            this.quảnLíKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.quảnLíKhóaHọcToolStripMenuItem.Text = "Quản lí khóa học";
            this.quảnLíKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíKhóaHọcToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // quảnLíGiảngViênToolStripMenuItem
            // 
            this.quảnLíGiảngViênToolStripMenuItem.Name = "quảnLíGiảngViênToolStripMenuItem";
            this.quảnLíGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLíGiảngViênToolStripMenuItem.Text = "Quản lí giảng viên";
            // 
            // Main_pnl
            // 
            this.Main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.Main_pnl.Location = new System.Drawing.Point(0, 28);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(800, 423);
            this.Main_pnl.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_pnl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Quản lí lớp học thầy Cáo";
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíGiảngViênToolStripMenuItem;
        private System.Windows.Forms.Panel Main_pnl;
    }
}

