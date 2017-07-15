using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;
using CookieClicker.Models;
using CookieClicker.Models.Helpers;

namespace CookieClicker.Forms
{
    public partial class ClickerGame : Form
    {
        private Game _clickerGame = new Game();
        BackgroundWorker bw = new BackgroundWorker();
        public ClickerGame()
        {
            InitializeComponent();
            bw.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
            ReloadLabels();
        }

        /// <summary>
        /// 2nd Thread for farming CPS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += DisplayTimeEvent;
            myTimer.Interval = 1000; // 1000 ms is one second
            myTimer.Start();

            System.Timers.Timer myTimer2 = new System.Timers.Timer();
            myTimer2.Elapsed += DisplayTimeEvent2;
            myTimer2.Interval = 200; 
            myTimer2.Start();
        }

        private void DisplayTimeEvent2(object source, ElapsedEventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.StrongClick.Cost)
            {
                ThreadHelperClass.Enabled(this, button2, true);
            }
            if (_clickerGame.CookiesColected >= _clickerGame.Pointer.Cost)
            {
                ThreadHelperClass.Enabled(this, button3, true);
            }
            ReloadLabels();
        }
        /// <summary>
        /// Passive Farmer of Cookies
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            _clickerGame.CookiesColected += _clickerGame.CookiesPerSecond;
            _clickerGame.CookiesOverallyCollected += _clickerGame.CookiesPerSecond;
        }

        /// <summary>
        /// Reloading all labels with Game data
        /// </summary>
        private void ReloadLabels()
        {
            ThreadHelperClass.SetText(this,label2,_clickerGame.CookiesColected.ToString("F"));
            ThreadHelperClass.SetText(this,label3,_clickerGame.CookiesPerClick.ToString("F"));
            ThreadHelperClass.SetText(this,label5, _clickerGame.CookiesPerSecond.ToString("F"));
            ThreadHelperClass.SetText(this,button2,_clickerGame.StrongClick.Cost.ToString("F"));
            ThreadHelperClass.SetText(this,button3,_clickerGame.Pointer.Cost.ToString("F"));
            ThreadHelperClass.SetText(this,label8,_clickerGame.StrongClick.Level.ToString("D"));
            ThreadHelperClass.SetText(this, label9, _clickerGame.StrongClick.CpcToLabel.ToString("F"));
            ThreadHelperClass.SetText(this,label14,_clickerGame.Pointer.Level.ToString("D"));
            ThreadHelperClass.SetText(this,label11,_clickerGame.Pointer.CpsToLabel.ToString("F"));
        }

        /// <summary>
        /// Opening statistics form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            var form = new Statistics(_clickerGame);
            form.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.StrongClick.Cost)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                _clickerGame.CookiesColected -= _clickerGame.StrongClick.Cost;
                _clickerGame.StrongClick.LevelUp();
                _clickerGame.CookiesPerClick += _clickerGame.StrongClick.Cpc;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.Pointer.Cost)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                _clickerGame.CookiesColected -= _clickerGame.Pointer.Cost;
                _clickerGame.Pointer.LevelUp();
                _clickerGame.CookiesPerSecond += _clickerGame.Pointer.Cps;
            }
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            _clickerGame.CookiesColected += _clickerGame.CookiesPerClick;
            _clickerGame.CookiesOverallyCollected += _clickerGame.CookiesPerClick;
            _clickerGame.ClicksDone += 1;
            ReloadLabels();
        }
    }
}
