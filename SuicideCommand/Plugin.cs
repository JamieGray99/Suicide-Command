using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace SuicideCommand
{
    public class Plugin 
    {
        public const string Author = "Jamie";
        public const string Name = "Suicide Command";
        public const string Version = "1.0.0";
        
        
        [PluginConfig] public static Config Config;

        [PluginPriority(LoadPriority.Medium)]
        [PluginEntryPoint(Name, Version, "A command so players can kill themself", Author)]
        private void LoadPlugin()
        {
            if (!Config.IsEnabled)
                return;
            
            Log.Info($"<color=red>Loading {Name} {Version} by {Author}</color>");
        }
    }
}