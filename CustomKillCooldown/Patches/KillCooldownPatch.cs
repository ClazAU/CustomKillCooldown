using AmongUs.GameOptions;
using CustomKillCooldown.Options;
using HarmonyLib;
using MiraAPI.GameOptions;
using Reactor.Utilities;

namespace CustomKillCooldown.Patches;

[HarmonyPatch(typeof(NormalGameOptionsV10), nameof(NormalGameOptionsV10.GetFloat))]
public class KillCooldownPatch
{
    public static bool Prefix(ref float __result, FloatOptionNames optionName)
    {
        Logger<CustomKillCooldownPlugin>.Info("Patching IGameOptions.GetFloat");
        if (optionName != FloatOptionNames.KillCooldown) return true;
        Logger<CustomKillCooldownPlugin>.Info("Patching FloatOptionNames.KillCooldown");
        if (!OptionGroupSingleton<CustomKillCooldownOptions>.Instance.Enabled) return true;
        Logger<CustomKillCooldownPlugin>.Info("Setting CustomKillCooldownOptions.KillCooldown");
        __result = OptionGroupSingleton<CustomKillCooldownOptions>.Instance.KillCooldown;
        return false;
    }
}