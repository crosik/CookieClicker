using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using CookieClicker.Models;
using CookieClicker.Models.Helpers;

namespace CookieClicker.Forms
{
    public partial class ClickerGame : Form
    {
        private Game _clickerGame;
        BackgroundWorker _bw = new BackgroundWorker();
        public ClickerGame()
        {
            InitializeComponent();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\save.xml"))
            {
                LoadGame();
            }
            else
            {
                _clickerGame = new Game();
            }
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
            cpsTimer.Elapsed += FarmingCookiesTimeEvent;
            cpsTimer.Interval = 1000;
            cpsTimer.Start();

            System.Timers.Timer buttonsTimer = new System.Timers.Timer();
            buttonsTimer.Elapsed += ButtonsTimeEvent;
            buttonsTimer.Interval = 200; 
            buttonsTimer.Start();
        }

        /// <summary>
        /// Unlocking upgrades buttons player has enough cookies.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void ButtonsTimeEvent(object source, ElapsedEventArgs e)
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
        private void FarmingCookiesTimeEvent(object source, ElapsedEventArgs e)
        {
            _clickerGame.CookiesColected += _clickerGame.CookiesPerSecond;
            _clickerGame.CookiesOverallyCollected += _clickerGame.CookiesPerSecond;
        }

        /// <summary>
        /// Reloading all labels with Game data
        /// </summary>
        private void ReloadLabels()
        {
            ThreadHelperClass.SetText(this,CookieColectedLabel,NumberFormatter.Double(_clickerGame.CookiesColected));
            ThreadHelperClass.SetText(this,CPCLabel,NumberFormatter.Double(_clickerGame.CookiesPerClick));
            ThreadHelperClass.SetText(this,CPSLabel, NumberFormatter.Double(_clickerGame.CookiesPerSecond));
            ThreadHelperClass.SetText(this,StrongClickButton, NumberFormatter.Double(_clickerGame.StrongClick.Cost));
            ThreadHelperClass.SetText(this,PointerButton, NumberFormatter.Double(_clickerGame.Pointer.Cost));
            ThreadHelperClass.SetText(this,StrongClickLevelLabel, NumberFormatter.Double(_clickerGame.StrongClick.Level));
            ThreadHelperClass.SetText(this,StrongClickCPCLabel, NumberFormatter.Double(_clickerGame.StrongClick.CpcToLabel));
            ThreadHelperClass.SetText(this,PointerLevelLabel, NumberFormatter.Double(_clickerGame.Pointer.Level));
            ThreadHelperClass.SetText(this,PointerCPSLabel, NumberFormatter.Double(_clickerGame.Pointer.CpsToLabel));
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
                _clickerGame.CookiesOverallySpent += _clickerGame.StrongClick.Cost;
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
                _clickerGame.CookiesOverallySpent += _clickerGame.Pointer.Cost;
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

        /// <summary>
        /// Saves game progress in xml format to save.xml
        /// </summary>
        private void SaveGame()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\save.xml";
            FileStream outFile = File.Create(path);
            XmlSerializer formatter = new XmlSerializer(typeof(Game));
            formatter.Serialize(outFile, _clickerGame);
        }


        /// <summary>
        /// Loads game from xml format file save.xml
        /// </summary>
        private void LoadGame()
        {
            string file = AppDomain.CurrentDomain.BaseDirectory + @"\save.xml";
            XmlSerializer formatter = new XmlSerializer(typeof(Game));
            FileStream aFile = new FileStream(file, FileMode.Open);
            byte[] buffer = new byte[aFile.Length];
            aFile.Read(buffer, 0, (int)aFile.Length);
            MemoryStream stream = new MemoryStream(buffer);
            _clickerGame = (Game)formatter.Deserialize(stream);
        }

        private void ClickerGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGame();
        }
    }
}
