namespace AutoClickBOT
{
    partial class mForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftCBox = new System.Windows.Forms.CheckBox();
            this.rightCBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.howOftenClickMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.infinityCBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.howManySecMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delayTMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome. Your mouse is ready to transform into a robot!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select mouse clicks:";
            // 
            // leftCBox
            // 
            this.leftCBox.AutoSize = true;
            this.leftCBox.Location = new System.Drawing.Point(122, 33);
            this.leftCBox.Name = "leftCBox";
            this.leftCBox.Size = new System.Drawing.Size(75, 19);
            this.leftCBox.TabIndex = 2;
            this.leftCBox.Text = "Left Click";
            this.leftCBox.UseVisualStyleBackColor = true;
            this.leftCBox.CheckedChanged += new System.EventHandler(this.leftCBox_CheckedChanged);
            // 
            // rightCBox
            // 
            this.rightCBox.AutoSize = true;
            this.rightCBox.Location = new System.Drawing.Point(203, 33);
            this.rightCBox.Name = "rightCBox";
            this.rightCBox.Size = new System.Drawing.Size(83, 19);
            this.rightCBox.TabIndex = 3;
            this.rightCBox.Text = "Right Click";
            this.rightCBox.UseVisualStyleBackColor = true;
            this.rightCBox.CheckedChanged += new System.EventHandler(this.rightCBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "How often it will click:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(176, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "MilliSecond (Min. 250)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // howOftenClickMaskedBox
            // 
            this.howOftenClickMaskedBox.Location = new System.Drawing.Point(134, 62);
            this.howOftenClickMaskedBox.Mask = "00000";
            this.howOftenClickMaskedBox.Name = "howOftenClickMaskedBox";
            this.howOftenClickMaskedBox.Size = new System.Drawing.Size(36, 23);
            this.howOftenClickMaskedBox.TabIndex = 7;
            this.howOftenClickMaskedBox.ValidatingType = typeof(int);
            this.howOftenClickMaskedBox.TextChanged += new System.EventHandler(this.howOftenClickMaskedBox_TextChanged);
            // 
            // infinityCBox
            // 
            this.infinityCBox.AutoEllipsis = true;
            this.infinityCBox.Location = new System.Drawing.Point(4, 91);
            this.infinityCBox.Name = "infinityCBox";
            this.infinityCBox.Size = new System.Drawing.Size(309, 41);
            this.infinityCBox.TabIndex = 8;
            this.infinityCBox.Text = "Infinity Mode: I want the mouse to click forever. (As long as the app is open)";
            this.infinityCBox.UseVisualStyleBackColor = true;
            this.infinityCBox.CheckedChanged += new System.EventHandler(this.infinityCBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "How many seconds should it take:";
            // 
            // howManySecMaskedBox
            // 
            this.howManySecMaskedBox.Location = new System.Drawing.Point(198, 132);
            this.howManySecMaskedBox.Mask = "0000";
            this.howManySecMaskedBox.Name = "howManySecMaskedBox";
            this.howManySecMaskedBox.Size = new System.Drawing.Size(32, 23);
            this.howManySecMaskedBox.TabIndex = 10;
            this.howManySecMaskedBox.ValidatingType = typeof(int);
            this.howManySecMaskedBox.TextChanged += new System.EventHandler(this.howManySecMaskedBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(4, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "How many seconds should AutoClickBOT wait before running:";
            // 
            // delayTMaskedBox
            // 
            this.delayTMaskedBox.Location = new System.Drawing.Point(275, 167);
            this.delayTMaskedBox.Mask = "0000";
            this.delayTMaskedBox.Name = "delayTMaskedBox";
            this.delayTMaskedBox.Size = new System.Drawing.Size(32, 23);
            this.delayTMaskedBox.TabIndex = 12;
            this.delayTMaskedBox.ValidatingType = typeof(int);
            this.delayTMaskedBox.TextChanged += new System.EventHandler(this.delayTMaskedBox_TextChanged);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(4, 199);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(309, 39);
            this.runBtn.TabIndex = 13;
            this.runBtn.Text = "Run the AutoClickBOT process!";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 240);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.delayTMaskedBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.howManySecMaskedBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infinityCBox);
            this.Controls.Add(this.howOftenClickMaskedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightCBox);
            this.Controls.Add(this.leftCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClickBOT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mForm_FormClosed);
            this.Load += new System.EventHandler(this.mForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox leftCBox;
        private CheckBox rightCBox;
        private Label label3;
        private Label label4;
        private MaskedTextBox howOftenClickMaskedBox;
        private CheckBox infinityCBox;
        private Label label5;
        private MaskedTextBox howManySecMaskedBox;
        private Label label6;
        private MaskedTextBox delayTMaskedBox;
        private Button runBtn;
    }
}