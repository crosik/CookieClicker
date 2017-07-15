using System;

namespace CookieClicker.Models.Upgrades
{
    public class UpgradeMath
    { 
        //UPGRADES COST
        public static readonly double Base = 2;
        public static readonly double BaseCostPointer = 100;
        public static readonly double BaseCostStrongClick = 20;
        public static readonly double Sqrt = 1 / 2;
        public static double DerrivedCps(int level) => Math.Pow(level,(1+Sqrt));
        public static double DerrivedCpc(int level) => Math.Pow(level, (1+ 3/4));
        public static double DerrivedCostPointer(int level) => BaseCostPointer * Math.Pow(level,2);
        public static double DerrivedCostStrongClick(int level) => BaseCostStrongClick * Math.Pow(level,2);
    }
}
