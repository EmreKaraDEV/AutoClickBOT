namespace AutoClickBOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.isTermsOfUseAccepted = false; Properties.Settings.Default.Save();
            if (Properties.Settings.Default.isTermsOfUseAccepted == false)
            {
                this.Size = new Size(396, 356);
                starterInfo.Text = "You must accept the following terms of use in order for AutoClickBOT to start.";
            }
            else
            {
                startACBOT();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Select YES to confirm that you accept the AutoClickBOT terms of use.\n\nYou can choose NO to reject the AutoClickBOT terms of use.\n\nYou can select the CANCEL option to close the application.\n\nAfter accepting the terms of use, the application will be started.", "AutoClickBOT Terms Of Use", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Properties.Settings.Default.isTermsOfUseAccepted = true;
                    Properties.Settings.Default.Save();
                    checkBox1.Checked = true;
                    startACBOT();
                    break;
                case DialogResult.No:
                    checkBox1.Checked = false;
                    break;
                case DialogResult.Cancel:
                    checkBox1.Checked = false;
                    Environment.Exit(0);
                    break;
            }
        }

        private void startACBOT()
        {
            checkBox1.Enabled = false;
            this.Size = new Size(396, 85);
            starterInfo.Text = "Welcome. You have accepted the AutoClickBOT terms of use. Starting AutoClickBOT...";
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }
        private int sec = 0;
        private void T_Tick(object? sender, EventArgs e)
        {
            sec++;
            if(sec == 2)
            {
                mForm mf = new mForm();
                mf.Show();
                this.Hide();
            }
        }
    }
}