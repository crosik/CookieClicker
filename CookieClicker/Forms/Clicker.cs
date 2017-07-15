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
        BackgroundWorker _bw = new BackgroundWorker();
        public ClickerGame()
        {
            InitializeComponent();
            _bw.DoWork += backgroundWorker1_DoWork;
            if (!_bw.IsBusy)
            {
                _bw.RunWorkerAsync();
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
            System.Timers.Timer cpsTimer = new System.Timers.Timer();
            cpsTimer.Elapsed += DisplayTimeEvent;
            cpsTimer.Interval = 1000; // 1000 ms is one second
            cpsTimer.Start();

            System.Timers.Timer buttonsTimer = new System.Timers.Timer();
            buttonsTimer.Elapsed += DisplayTimeEvent2;
            buttonsTimer.Interval = 200; 
            buttonsTimer.Start();
        }

        /// <summary>
        /// Unlocking upgrades buttons player has enough cookies.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void DisplayTimeEvent2(object source, ElapsedEventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.StrongClick.Cost)
            {
                ThreadHelperClass.Enabled(this, StrongClickButton, true);
            }
            if (_clickerGame.CookiesColected >= _clickerGame.Pointer.Cost)
            {
                ThreadHelperClass.Enabled(this, PointerButton, true);
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
            ThreadHelperClass.SetText(this,CookieColectedLabel,_clickerGame.CookiesColected.ToString("F"));
            ThreadHelperClass.SetText(this,CPCLabel,_clickerGame.CookiesPerClick.ToString("F"));
            ThreadHelperClass.SetText(this,CPSLabel, _clickerGame.CookiesPerSecond.ToString("F"));
            ThreadHelperClass.SetText(this,StrongClickButton,_clickerGame.StrongClick.Cost.ToString("F"));
            ThreadHelperClass.SetText(this,PointerButton,_clickerGame.Pointer.Cost.ToString("F"));
            ThreadHelperClass.SetText(this,StrongClickLevelLabel,_clickerGame.StrongClick.Level.ToString("D"));
            ThreadHelperClass.SetText(this,StrongClickCPCLabel, _clickerGame.StrongClick.CpcToLabel.ToString("F"));
            ThreadHelperClass.SetText(this,PointerLevelLabel,_clickerGame.Pointer.Level.ToString("D"));
            ThreadHelperClass.SetText(this,PointerCPSLabel,_clickerGame.Pointer.CpsToLabel.ToString("F"));
        }

        /// <summary>
        /// Opening statistics form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatisticsForm_Click(object sender, System.EventArgs e)
        {
            var form = new Statistics(_clickerGame);
            form.Show();
        }

        /// <summary>
        /// Upgrading Stronk Click by Level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrongClickButton_Click(object sender, System.EventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.StrongClick.Cost)
            {
                StrongClickButton.Enabled = false;
                PointerButton.Enabled = false;
                _clickerGame.CookiesColected -= _clickerGame.StrongClick.Cost;
                _clickerGame.StrongClick.LevelUp();
                _clickerGame.CookiesPerClick += _clickerGame.StrongClick.Cpc;
            }
            StrongClickButton.Enabled = false;
            PointerButton.Enabled = false;
        }

        /// <summary>
        /// Upgrading Pointer by level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointerButton_Click(object sender, System.EventArgs e)
        {
            if (_clickerGame.CookiesColected >= _clickerGame.Pointer.Cost)
            {
                PointerButton.Enabled = false;
                StrongClickButton.Enabled = false;
                _clickerGame.CookiesColected -= _clickerGame.Pointer.Cost;
                _clickerGame.Pointer.LevelUp();
                _clickerGame.CookiesPerSecond += _clickerGame.Pointer.Cps;
            }
            StrongClickButton.Enabled = false;
            PointerButton.Enabled = false;
        }

        /// <summary>
        /// Clickng on picture gives Cookies equals to CPC(CookiesPerClick)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CookiePictureBox_Click(object sender, System.EventArgs e)
        {
            _clickerGame.CookiesColected += _clickerGame.CookiesPerClick;
            _clickerGame.CookiesOverallyCollected += _clickerGame.CookiesPerClick;
            _clickerGame.ClicksDone += 1;
            ReloadLabels();
        }
    }
}
