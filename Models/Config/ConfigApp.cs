using AutoClicker.Enums;
using System.Text.Json.Serialization;

namespace AutoClicker.Models.Config
{
    public class ConfigApp
    {
        [JsonPropertyName("keystart")]
        public int keyStart { get; set; } = (int)KeysAndMouseButtons.Z;
        [JsonPropertyName("keywillpress")]
        public int keyWillPress { get; set; } = (int)KeysAndMouseButtons.LBUTTON;
        [JsonPropertyName("amountClicks")]
        public int amoutClicks { get; set; } = 100000;
        [JsonPropertyName("delayMs")]
        public int delayMs { get; set; } = 100;
        [JsonPropertyName("infinnityClicks")]
        public bool infinnityClicks { get; set; } = true;
        [JsonPropertyName("linkRepo")]
        public string LinkRepo { get; set; } = "https://github.com/Holan21/AutoClicker";
        [JsonPropertyName("linkCreator")]
        public string LinkCreator { get; set; } = "https://github.com/Holan21";
        [JsonPropertyName("linkGitHub")]
        public string LinkGitHub { get; set; } = "https://github.com/";
    }
}
