# Among Us Mod Template

A template for creating Among Us mods using MiraAPI, BepInEx, and Reactor.

## Usage

### As GitHub Template
1. Click "Use this template" to create a new repository
2. Clone your new repository
3. Rename `CustomKillCooldown` folder and update namespaces to your mod name
4. Run `dotnet restore` then `dotnet build`

### As dotnet new Template
```bash
# Install template (one-time)
git clone https://github.com/ClazAU/AmongUsCustomKillCooldown
dotnet new install ./AmongUsCustomKillCooldown

# Create new project
dotnet new aumod -n MyModName

# Uninstall template
dotnet new uninstall ClazAU.AmongUsMod
```

## Project Structure

```
CustomKillCooldown/
├── Buttons/       # CustomActionButton classes
├── Scripts/       # MonoBehaviour scripts
├── Events/        # Event handlers
├── Options/       # Game option configurations
├── Patches/       # HarmonyLib patches
├── Resources/     # Embedded assets (sprites, bundles)
├── Roles/         # Custom role definitions
└── Utils/         # Helper utilities
```

## Dependencies

- [MiraAPI](https://github.com/All-Of-Us-Mods/MiraAPI) - Custom roles and options framework
- [Reactor](https://github.com/NuclearPowered/Reactor) - Networking and utilities
- [BepInEx](https://github.com/BepInEx/BepInEx) - Game modding framework

## Building

```bash
dotnet restore
dotnet build --configuration Release
```

Output: `CustomKillCooldown/bin/Release/net6.0/CustomKillCooldown.dll`
