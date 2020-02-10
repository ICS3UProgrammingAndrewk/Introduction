namespace HelloWorldAndrew
{
    partial class frmHelloWorld
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
            this.lblHelloworld = new System.Windows.Forms.Label();
            this.picNeymar = new System.Windows.Forms.PictureBox();
            this.lblAndrewK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNeymar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloworld
            // 
            this.lblHelloworld.AutoSize = true;
            this.lblHelloworld.BackColor = System.Drawing.Color.Crimson;
            this.lblHelloworld.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloworld.ForeColor = System.Drawing.Color.Orange;
            this.lblHelloworld.Location = new System.Drawing.Point(231, 85);
            this.lblHelloworld.Name = "lblHelloworld";
            this.lblHelloworld.Size = new System.Drawing.Size(310, 55);
            this.lblHelloworld.TabIndex = 0;
            this.lblHelloworld.Text = "Hello, World!";
            this.lblHelloworld.Click += new System.EventHandler(this.LblHelloworld_Click);
            // 
            // picNeymar
            // 
            this.picNeymar.Image = global::HelloWorldAndrew.Properties.Resources.neymar;
            this.picNeymar.Location = new System.Drawing.Point(241, 185);
            this.picNeymar.Name = "picNeymar";
            this.picNeymar.Size = new System.Drawing.Size(258, 162);
            this.picNeymar.TabIndex = 1;
            this.picNeymar.TabStop = false;
            // 
            // lblAndrewK
            // 
            this.lblAndrewK.AutoSize = true;
            this.lblAndrewK.Font = new System.Drawing.Font("CommercialScript BT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndrewK.ForeColor = System.Drawing.Color.Yellow;
            this.lblAndrewK.Location = new System.Drawing.Point(231, 386);
            this.lblAndrewK.Name = "lblAndrewK";
            this.lblAndrewK.Size = new System.Drawing.Size(297, 55);
            this.lblAndrewK.TabIndex = 2;
            this.lblAndrewK.Text = "By Andrew k.";
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAndrewK);
            this.Controls.Add(this.picNeymar);
            this.Controls.Add(this.lblHelloworld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World by Andre K.";
            ((System.ComponentModel.ISupportInitialize)(this.picNeymar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloworld;
        private System.Windows.Forms.PictureBox picNeymar;
        private System.Windows.Forms.Label lblAndrewK;
    }
}

