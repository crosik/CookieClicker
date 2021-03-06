﻿using System.ComponentModel;
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
            bw.DoWork += backgroundWorker1_DoWork;
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }
        /// <summary>
        /// Thread running to update every 200ms labels in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += LabelsTimeEvent;
            myTimer.Interval = 200; 
            myTimer.Start();
        }
        private void LabelsTimeEvent(object source, ElapsedEventArgs e)
        {
            ReloadLabels();
        }

        /// <summary>
        /// Reloading all labels with Game data statistics
        /// </summary>
        private void ReloadLabels()
        {
            ThreadHelperClass.SetText(this, label2, NumberFormatter.Double(_clickerGame.CookiesOverallyCollected));
            ThreadHelperClass.SetText(this, label4, NumberFormatter.Double(_clickerGame.CookiesOverallySpent));
            ThreadHelperClass.SetText(this,label6,_clickerGame.ClicksDone.ToString());
            ThreadHelperClass.SetText(this,label8,_clickerGame.GameStarted.ToLongDateString());
        }
    }
}
