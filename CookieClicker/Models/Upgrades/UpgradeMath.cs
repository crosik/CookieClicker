using System;

namespace CookieClicker.Models.Upgrades
{
    public class UpgradeMath
    { 
        //UPGRADES COST
        public static readonly double Base = 2;
        public static readonly double BaseCostPointer = 100;
        public static readonly double BaseCostStrongClick = 20;
        public static double DerrivedCps(int level) => Math.Pow(Base,level);
        public static double DerrivedCpc(int level) => Math.Log(Base, level);
        public static double DerrivedCostPointer(int level) => BaseCostPointer * Math.Pow(Base, level);
        public static double DerrivedCostStrongClick(int level) => BaseCostStrongClick * Math.Pow(Base, level);
    }
}
