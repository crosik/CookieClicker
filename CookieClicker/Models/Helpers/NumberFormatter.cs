using System;

namespace CookieClicker.Models.Helpers
{
    public class NumberFormatter
    {
        public static string Double(double d)
        {
            var dec = 3;
            var suffixes = new[]
            {
                "", "k", "M", "B", "T", "Qa", "Qi", "Sx", "Sp", "Oc", "No", "De", "UnD", "DuD", "TrD", "QaD", "QiD",
                "SeD", "SpD", "OcD", "NoD", "Vi", "UnV"
            };
            var dbcalc = (Math.Floor(Math.Log(Math.Abs(d)) / Math.Log(10) / 3)).ToString();
            if (Int32.TryParse(dbcalc, out int xResult))
            {
                var suffix = suffixes[xResult];
                var rounded = Math.Round(d / (Math.Pow(10, xResult * 3 - dec))) / Math.Pow(10, dec);
                return $"{rounded} {suffix}";
            }
            else
            {
                return $"0";
            }
        }
    }
}
