using AutoClicker.Enums;
using System.Text.Json.Serialization;

namespace AutoClicker.Models.Config
{
    public class ConfigApp
    {
        [JsonPropertyName("keystart")]
        public int KeyStart { get; set; } = (int)KeysAndMouseButtons.Z;
        [JsonPropertyName("keywillpress")]
        public int KeyWillPress { get; set; } = (int)KeysAndMouseButtons.LBUTTON;
        [JsonPropertyName("amountClicks")]
        public int AmoutClicks { get; set; } = 100000;
        [JsonPropertyName("delayMs")]
        public int DelayMs { get; set; } = 100;
        [JsonPropertyName("infinnityClicks")]
        public bool InfinnityClicks { get; set; } = true;
        [JsonPropertyName("linkRepo")]
        public string LinkRepo { get; set; } = "https://github.com/Holan21/AutoClicker";
        [JsonPropertyName("linkCreator")]
        public string LinkCreator { get; set; } = "https://github.com/Holan21";
        [JsonPropertyName("linkDesigner")]
        public string LinkDesigner { get; set; } = @"https://steamcommunity.com/id/masarte/";
    }
}
