namespace CookieClicker.Models.Upgrades
{
    public class StrongClick : IUpgrade
    {
        
        public int Level { get; set; } = 0;
        public double Cost { get; set; } = 10;
        public double Cps { get; set; } = 0;
        public double Cpc { get; set; } = UpgradeMath.DerrivedCpc(0);
        public double CpcToLabel { get; set; } = UpgradeMath.DerrivedCpc(1) + 1;
        public void LevelUp()
        {
            Level += 1;
            Cost = UpgradeMath.DerrivedCostStrongClick(Level);
            Cpc += UpgradeMath.DerrivedCpc(Level);
            CpcToLabel += UpgradeMath.DerrivedCpc(Level + 1);
        }
    }
}
