namespace AutoClickBOT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.starterInfo = new System.Windows.Forms.Label();
            this.termsOfUse = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // starterInfo
            // 
            this.starterInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.starterInfo.AutoEllipsis = true;
            this.starterInfo.Location = new System.Drawing.Point(12, 9);
            this.starterInfo.Name = "starterInfo";
            this.starterInfo.Size = new System.Drawing.Size(356, 34);
            this.starterInfo.TabIndex = 0;
            this.starterInfo.Text = "Starting AutoClickBOT...";
            this.starterInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // termsOfUse
            // 
            this.termsOfUse.Location = new System.Drawing.Point(12, 46);
            this.termsOfUse.Multiline = true;
            this.termsOfUse.Name = "termsOfUse";
            this.termsOfUse.ReadOnly = true;
            this.termsOfUse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.termsOfUse.Size = new System.Drawing.Size(356, 231);
            this.termsOfUse.TabIndex = 1;
            this.termsOfUse.Text = resources.GetString("termsOfUse.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoEllipsis = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(356, 27);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "I accept the AutoClickBOT Terms of Use.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 317);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.termsOfUse);
            this.Controls.Add(this.starterInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClickBOT Starter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label starterInfo;
        private TextBox termsOfUse;
        private CheckBox checkBox1;
    }
}