using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace CustomKillCooldown;

[BepInAutoPlugin]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class CustomKillCooldownPlugin : BasePlugin, IMiraPlugin
{
    private Harmony Harmony { get; } = new(Id);

    public string OptionsTitleText => "CustomKillCooldown";

    public ConfigFile GetConfigFile() => Config;

    public override void Load()
    {
        Harmony.PatchAll();
    }
}