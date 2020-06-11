namespace Soccer.Common.Models
{
    public class TeamResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
            ? "https://soccerwebutcipa4.azurewebsites.net//images/noimage.png"
            : $"https://soccerwebutcipa4.azurewebsites.net{LogoPath.Substring(1)}";
    }
}

