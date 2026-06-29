namespace StashUtility
{
    using GameHelper.Plugin;
    using System.Collections.Generic;
    using System.Numerics;

    public sealed class StashUtilitySettings : IPSettings
    {
        // General
        public bool EnableWaystoneManager = true;
        public bool ShowOverlayInBackground = false;

        // UI path for the waystone stash tab
        public string PathString = "2,0,0,0,1,1,45,0,1";

        // Filter Criteria
        public int MinTier = 1;
        public bool FilterMaxRevives = false;
        public int MaxRevivesAvailable = 0;
        public bool FilterMinItemRarity = false;
        public int MinItemRarity = 0;
        public bool FilterMinPackSize = false;
        public int MinPackSize = 0;
        public bool FilterMinMonsterRarity = false;
        public int MinMonsterRarity = 0;
        public bool FilterMinMonsterEffectiveness = false;
        public int MinMonsterEffectiveness = 0;
        public bool FilterMinWaystoneDropChance = false;
        public int MinWaystoneDropChance = 0;

        // Colors (RGBA)
        public Vector4 GoodColor = new(0f, 1f, 0f, 1f);       // Green
        public Vector4 BadColor = new(1f, 0f, 0f, 1f);        // Red
        public Vector4 NeutralColor = new(1f, 1f, 0f, 0.7f);   // Yellow
        public Vector4 NormalRarityColor = new(0.8f, 0.8f, 0.8f, 1f);
        public Vector4 MagicRarityColor = new(0.4f, 0.6f, 1f, 1f);
        public Vector4 RareRarityColor = new(1f, 0.85f, 0f, 1f);

        // Visuals
        public float BorderThickness = 3f;
        public float RarityIndicatorSize = 10f;
        public bool ShowRarityBorder = true;
        public bool ShowModBorder = true;
        public bool HideNormalWaystones = false;

        public int ScanStartOffset = 0x20;
        public int ScanEndOffset = 0x600;

        // Mod matching config
        public bool RedTakesPriority = true;
        public bool RequireAllGoodMods = false; // false = ANY good mod matches

        // Mods lists (populated / loaded from JSON)
        public List<string> GoodModPatterns = new();
        public List<string> BadModPatterns = new();

        // Debug Probe Mode
        public bool EnableDebugProbe = false;
    }
}
