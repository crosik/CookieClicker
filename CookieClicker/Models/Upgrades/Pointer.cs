namespace CookieClicker.Models.Upgrades
{
    public class Pointer : IUpgrade
    {
        public int Level { get; set; } = 0;
        public double Cost { get; set; } = 70;
        public double Cps { get; set; } = UpgradeMath.DerrivedCps(0);
        public double CpsToLabel { get; set; } = UpgradeMath.DerrivedCpc(1) + 1;
        public double Cpc { get; set; } = 0;
        public void LevelUp()
        {
            Level += 1;
            Cost = UpgradeMath.DerrivedCostPointer(Level);
            Cps += UpgradeMath.DerrivedCps(Level);
            CpsToLabel += UpgradeMath.DerrivedCps(Level + 1);
        }
    }
}