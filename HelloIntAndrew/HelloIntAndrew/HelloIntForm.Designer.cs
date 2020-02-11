namespace HelloIntAndrew
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbLanguage = new System.Windows.Forms.GroupBox();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.grbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Red;
            this.lblGreeting.Location = new System.Drawing.Point(220, 190);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(283, 58);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(52, 60);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 2;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // grbLanguage
            // 
            this.grbLanguage.Controls.Add(this.radGerman);
            this.grbLanguage.Controls.Add(this.radSpanish);
            this.grbLanguage.Controls.Add(this.radFrench);
            this.grbLanguage.Controls.Add(this.radEnglish);
            this.grbLanguage.Location = new System.Drawing.Point(64, 306);
            this.grbLanguage.Name = "grbLanguage";
            this.grbLanguage.Size = new System.Drawing.Size(702, 132);
            this.grbLanguage.TabIndex = 3;
            this.grbLanguage.TabStop = false;
            this.grbLanguage.Text = "Language";
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(543, 60);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 5;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadGerman_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(384, 60);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 4;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(207, 60);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(65, 17);
            this.radFrench.TabIndex = 3;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Francais";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbLanguage);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello World International by Andrew";
            this.grbLanguage.ResumeLayout(false);
            this.grbLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.GroupBox grbLanguage;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radFrench;
    }
}

