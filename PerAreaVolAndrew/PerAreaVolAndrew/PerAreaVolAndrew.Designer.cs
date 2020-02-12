namespace PerAreaVolAndrew
{
    partial class PerAreaVolAndrew
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
            this.btnPer = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(98, 61);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(244, 86);
            this.btnPer.TabIndex = 0;
            this.btnPer.Text = "Calculate the perimeter of a rectangle with length 8cm and width 2cm";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(98, 179);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(244, 97);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "This Calculate the Area of a radius of 6cm";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calculate the Volume of a sphere with aradius of 20m";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(501, 88);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(25, 13);
            this.lblPer.TabIndex = 3;
            this.lblPer.Text = "???";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(504, 219);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "???";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(504, 351);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(25, 13);
            this.lblVol.TabIndex = 5;
            this.lblVol.Text = "???";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(38, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PerAreaVolAndrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PerAreaVolAndrew";
            this.Text = "Perimeter, Area,Volume";
            this.Load += new System.EventHandler(this.PerAreaVolAndrew_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

