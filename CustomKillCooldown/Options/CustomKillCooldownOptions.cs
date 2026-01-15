using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;

namespace CustomKillCooldown.Options;

public sealed class CustomKillCooldownOptions : AbstractOptionGroup
{
    public override string GroupName => "Custom Kill Cooldown";

    [ModdedToggleOption("Enabled")]
    public bool Enabled { get; set; } = true;
    
    [ModdedNumberOption("Kill Cooldown", 0f, 30f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float KillCooldown { get; set; } = 0f;
}