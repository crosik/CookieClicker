namespace CookieClicker.Models.Upgrades
{
    public interface IUpgrade
    {
        int Level { get; set; }
        double Cost { get; set; }
        double Cps { get; set; }
        double Cpc { get; set; }
        void LevelUp();
    }
}