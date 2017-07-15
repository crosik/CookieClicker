using System;
using CookieClicker.Models.Upgrades;

namespace CookieClicker.Models
{
    public class Game
    {
        /// ///////////
        /// Important Game Values
        /// //////////
        public double CookiesPerClick { get; set; } = 1;
        public double CookiesPerSecond { get; set; } = 0;
        public double CookiesColected { get; set; } = 0;
        /// ///////////
        /// Statistics
        /// ///////////
        public double CookiesOverallyCollected { get; set; } = 0;
        public double CookiesOverallySpent { get; set; } = 0;
        public DateTime GameStarted { get; set; } = DateTime.Now;
        public double GoldenCookiesColected { get; set; } = 0;
        public double SilverCookiesColected { get; set; } = 0;
        public int ClicksDone { get; set; } = 0;
        /// ///////////
        /// Upgrades
        /// ///////////
        public Pointer Pointer { get; set; } = new Pointer();
        public StrongClick StrongClick { get; set; } = new StrongClick();
    }
}