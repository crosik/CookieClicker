using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;
using CookieClicker.Models;
using CookieClicker.Models.Helpers;

namespace CookieClicker.Forms
{
    public partial class Statistics : Form
    {
        private Game _clickerGame;
        BackgroundWorker bw = new BackgroundWorker();
        public Statistics(Game game)
        {
            InitializeComponent();
            _clickerGame = game;
            bw.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += DisplayTimeEvent;
            myTimer.Interval = 200; // 1000 ms is one second
            myTimer.Start();
        }
        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            ReloadLabels();
        }

        /// <summary>
        /// Reloading all labels with Game data
        /// </summary>
        private void ReloadLabels()
        {
            ThreadHelperClass.SetText(this, label2, _clickerGame.CookiesOverallyCollected.ToString("F"));
            ThreadHelperClass.SetText(this, label4, _clickerGame.CookiesOverallySpent.ToString("F"));
            ThreadHelperClass.SetText(this,label6,_clickerGame.ClicksDone.ToString());
            ThreadHelperClass.SetText(this,label8,_clickerGame.GameStarted.ToLongDateString());
        }
    }
}
