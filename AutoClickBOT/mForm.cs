using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickBOT
{
    public partial class mForm : Form
    {
        /*
         AutoClickBOT, Powered By Emreki.
         A Open Source Project.
         AutoClickBOT allows your mouse to automatically click as often as you want for as long as you want. 
         AutoClickBOT can do left click or right click or both. 
         You can also set the time to wait before this process starts.
         This is the main part of the AutoClickBOT application. AutoClickBOT completes the requested task here.
         */

        //Don't forget to visit the links below and support me!
        private string WebSite = "https://emreki.art.blog/";
        private string GitHub = "https://github.com/EmreKaraDEV";
        private string YouTube = "https://www.youtube.com/c/EmreKaraTV";
        public string getWebSite() { return WebSite; }
        public string getGitHub() { return GitHub; }
        public string getYouTube() { return YouTube; }

        public mForm()
        {
            InitializeComponent();
        }
        
        System.Windows.Forms.Timer timerMain = new System.Windows.Forms.Timer(); //timerMain manages the duration of the main process.
        System.Windows.Forms.Timer timerCore = new System.Windows.Forms.Timer(); //timerCore manages the mouse click frequency.
        private int sec = 0; //timerMain second
        private string version = "V1.0 BETA"; //version info

        private void mForm_Load(object sender, EventArgs e)
        {
            try {
                this.Text = "AutoClickBOT " + version; //updating title with version info
                //Saved settings are loaded at startup.
                leftCBox.Checked = Properties.Settings.Default.leftClick;
                rightCBox.Checked = Properties.Settings.Default.rightClick;
                infinityCBox.Checked = Properties.Settings.Default.infinityMode;
                howOftenClickMaskedBox.Text = Properties.Settings.Default.howOftenClick.ToString();
                howManySecMaskedBox.Text = Properties.Settings.Default.howManySecondWillRun.ToString();
                delayTMaskedBox.Text = Properties.Settings.Default.delayTime.ToString();
                //Timers are set.
                timerMain.Interval = 1000;
                timerMain.Tick += TimerMain_Tick;
                timerCore.Tick += TimerCore_Tick;
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT mPart load error"); //emrekiBugLogger logs the error to the text file and displays an error message box to the user.
            }
        }

        private void TimerMain_Tick(object? sender, EventArgs e)
        {   //timerMain manages the duration of the main process.
            try {
                sec++; //seconds increase every second
                if (sec > Properties.Settings.Default.delayTime)
                { //The mouse click task is started if the second exceeds the waiting time before running.
                    if(Properties.Settings.Default.infinityMode == false) { this.Text = "AutoClickBOT " + version + " is running! " + (Properties.Settings.Default.howManySecondWillRun - (sec - Properties.Settings.Default.delayTime)).ToString() + " seconds left!"; }
                    else { this.Text = "AutoClickBOT " + version + " is running! Infinity Mode Enabled!"; }
                    //The window title indicates how much time remains until the end of the process.
                    if ((sec - Properties.Settings.Default.delayTime) >= Properties.Settings.Default.howManySecondWillRun && Properties.Settings.Default.infinityMode == false) {
                        runACBOT(false);    //If the infinity mode is not turned on, the process ends when the time is up.
                        timerMain.Enabled = false;
                    }
                    else { timerCore.Start(); } //The timerCore is started, which will do the mouse click as long as the conditions are right.
                }
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT main time error");
            }
        }
        //Requirements for mouse click
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private void TimerCore_Tick(object? sender, EventArgs e)
        {
            try {
                if (Properties.Settings.Default.leftClick == true) { //If Left Click feature is selected, Left click is done.
                    mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                }
                if(Properties.Settings.Default.rightClick == true) { //If Right Click feature is selected, Right click is done.
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                }
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT Core Error");
            }
        }

        private void leftCBox_CheckedChanged(object sender, EventArgs e)
        {   //Turns the left click feature on and off.
            try {
                Properties.Settings.Default.leftClick = leftCBox.Checked;
                Properties.Settings.Default.Save(); //It saves the properties so it reload them again on startup.
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT left click option error");
            }
        }

        private void rightCBox_CheckedChanged(object sender, EventArgs e)
        {   //Turns the right click feature on and off.
            try {
                Properties.Settings.Default.rightClick = rightCBox.Checked;
                Properties.Settings.Default.Save();
            }catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT right click option error");
            }
        }

        private void infinityCBox_CheckedChanged(object sender, EventArgs e)
        {   //Turns the infinity mode feature on and off.
            try {
                howManySecMaskedBox.Enabled = !infinityCBox.Checked; //If infinity mode is turned on, the feature that sets how many seconds the process will end will be disabled.
                Properties.Settings.Default.infinityMode = infinityCBox.Checked;
                Properties.Settings.Default.Save();
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT Infinity Mode option error");
            }    
        }

        private void howOftenClickMaskedBox_TextChanged(object sender, EventArgs e)
        {   //Changes the mouse click frequency.
            try {
                if (howOftenClickMaskedBox.Text != "") {
                    Properties.Settings.Default.howOftenClick = Convert.ToInt32(howOftenClickMaskedBox.Text);
                    Properties.Settings.Default.Save();
                    timerCore.Interval = Properties.Settings.Default.howOftenClick; //The timerCore is adjusted according to the mouse click frequency.
                }
            }catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT mouse click frequency option error");
            }
        }

        private void howManySecMaskedBox_TextChanged(object sender, EventArgs e)
        {   //Sets how many seconds the process will end. Infinity mode can disable or enable this feature.
            try {
                if (howManySecMaskedBox.Text != "") {
                    if (Convert.ToInt32(howManySecMaskedBox.Text) > 0) {
                        Properties.Settings.Default.howManySecondWillRun = Convert.ToInt32(howManySecMaskedBox.Text);
                        Properties.Settings.Default.Save();
                    }
                    else {
                        MessageBox.Show("This value must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        howManySecMaskedBox.Text = Properties.Settings.Default.howManySecondWillRun.ToString();
                    }
                }
            }catch(Exception ex)
            {
                emrekiBugLogger(ex, "AutoClickBOT total run time second option error");
            }
        }

        private void delayTMaskedBox_TextChanged(object sender, EventArgs e)
        {   //Sets how many seconds to wait before AutoClickBOT runs the process.
            try {
                if (delayTMaskedBox.Text != "") {
                    if (Convert.ToInt32(delayTMaskedBox.Text) > 0) {
                        Properties.Settings.Default.delayTime = Convert.ToInt32(delayTMaskedBox.Text);
                        Properties.Settings.Default.Save();
                    }
                    else {
                        MessageBox.Show("This value must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        delayTMaskedBox.Text = Properties.Settings.Default.delayTime.ToString();
                    }
                }
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT delayTime option error");
            }
            
        }

        private void runBtn_Click(object sender, EventArgs e)
        {   //It can start and stop the AutoClickBOT process.
            try {
                if (runBtn.Text == "Run the AutoClickBOT process!") {   //If the AutoClickBOT process is not working
                    if (Properties.Settings.Default.leftClick == false && Properties.Settings.Default.rightClick == false) {
                        MessageBox.Show("Please choose between Left click and Right click! You can choose both.", "AutoClickBOT can not run!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Properties.Settings.Default.howManySecondWillRun <= 0) {
                        MessageBox.Show("How many seconds should it take: cannot be less than 1!", "AutoClickBOT can not run!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Properties.Settings.Default.delayTime <= 1) {
                        MessageBox.Show("How many seconds should AutoClickBOT wait before running: must be greater than 1!", "AutoClickBOT can not run!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Properties.Settings.Default.howOftenClick < 250 && Properties.Settings.Default.infinityMode == false) {
                        MessageBox.Show("How often it will click: cannot be less than 250! ", "AutoClickBOT can not run!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Properties.Settings.Default.howOftenClick < 2500 && Properties.Settings.Default.infinityMode == true) {
                        MessageBox.Show("How often it will click: cannot be less than 2500 in Infinity Mode!", "AutoClickBOT can not run!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {  //Necessary requirements are questioned at the top. If all requirements are met, the AutoClickBOT process is run. If there is a problem with the requirements, it is notified via the message box.
                        runACBOT(true);
                    }
                }
                else if (runBtn.Text == "Stop AutoClickBOT!") { //If the AutoClickBOT process is working
                    runACBOT(false);
                }
            }catch (Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT runBtn error");
            }
        }
        
        private void runACBOT(bool run)
        {   //It can start and stop the AutoClickBOT process.
            try {
                sec = 0; //The second are reset.
                if (run == true) { //AutoClickBOT is run.
                    timerMain.Start();
                    runBtn.Text = "Stop AutoClickBOT!";
                    this.Text = "AutoClickBOT " + version + " : Getting Ready...";
                }
                else if (run == false) { //AutoClickBOT is stop.
                    timerMain.Stop();
                    timerCore.Stop();
                    runBtn.Text = "Run the AutoClickBOT process!";
                    this.Text = "AutoClickBOT";
                }
                //Options are disabled while running the AutoClickBOT process.
                leftCBox.Enabled = !run;
                rightCBox.Enabled = !run;
                howOftenClickMaskedBox.Enabled = !run;
                infinityCBox.Enabled = !run;
                if (infinityCBox.Checked != true) { howManySecMaskedBox.Enabled = !run; }
                delayTMaskedBox.Enabled = !run;
            }catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT Run&StopACBOT Error");
            }
        }

        private void mForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try{
                Environment.Exit(0); //Closes the application completely.
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "AutoClickBOT mPart can't close!");
            }
        }

        /*
         Emreki Bug Logger First Version
         By sending the errors caught by the Try Catch method here, 
         a bug log file is created. In this way, the saved of the errors encountered 
         can be sent to Emreki.
         */

        private void emrekiBugLogger(Exception exception, string specialDescription = "AutoClickBOT Error")
        {
            runACBOT(false); //The AutoClickBOT process is be stopped.
            StreamWriter sw;
            try {
                sw = new StreamWriter(Application.StartupPath + "\\AutoClickBOT_Bug_Logs.txt", true); //The file where the errors will be saved is added to the file location of the application and selected.
                sw.WriteLine("NEW BUG REPORT\nPlease help fix the errors by submitting this error file to this site: " + getWebSite() + "\nApplication Version: " + version + "\nTime to encounter the bug: " + DateTime.Now.ToString() + "\nException: " + exception.Message + "\nSpecial description: " + specialDescription);
                sw.Flush();
                sw.Close(); //After the error is saved, the user is informed via a message box.
                MessageBox.Show("An error was encountered while running the application. That's why we created a file where you can report the error to Emreki. Please forward the file indicating the error to Emreki. The application will continue to work if possible, but it is best to restart the application.\nName of the file where the error is logged: WriterBOT_Bug_Logs\nThis file is located in the application's file location.", "Something went wrong :) Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch {
                MessageBox.Show("An error occurred, but another error occurred while preparing to report that error.", "Error upon error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         Example Bug Log: Application File Location/ AutoClickBOT_Bug_Logs.txt
         
         NEW BUG REPORT
         Please help fix the errors by submitting this site: https://emreki.art.blog/
         Application Version: V1.0 BETA
         Time to encounter the bug: Date Time Now
         Exception: exception message
         Special Description: AutoClickBOT Error
         NEW BUG REPORT
         Every new bug report continues to be added to this file like this.
         */
    }
}
