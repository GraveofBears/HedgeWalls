using System;
using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using PieceManager;
using ServerSync;
using UnityEngine;

//using ServerSync;

namespace HedgeWalls
{
    
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    //[BepInIncompatibility("org.bepinex.plugins.valheim_plus")]

    public class OdinsKingdom : BaseUnityPlugin
    {
        private const string ModName = "HedgeWalls";
        private const string ModVersion = "1.0.13";
        private const string ModGUID = "odinplus.plugins.hedgewalls";

        private static readonly ConfigSync configSync = new(ModName) { DisplayName = ModName, CurrentVersion = ModVersion, MinimumRequiredVersion = ModVersion };

        private static ConfigEntry<Toggle> serverConfigLocked = null!;


        private ConfigEntry<T> config<T>(string group, string name, T value, ConfigDescription description, bool synchronizedSetting = true)
        {
            ConfigEntry<T> configEntry = Config.Bind(group, name, value, description);

            SyncedConfigEntry<T> syncedConfigEntry = configSync.AddConfigEntry(configEntry);
            syncedConfigEntry.SynchronizedConfig = synchronizedSetting;

            return configEntry;
        }


        private ConfigEntry<T> config<T>(string group, string name, T value, string description, bool synchronizedSetting = true) => config(group, name, value, new ConfigDescription(description), synchronizedSetting);

        private enum Toggle
        {
            On = 1,
            Off = 0
        }


        private void Awake()
        {
            BuildPiece Hedge_Wall_2x1 = new("odinhedges", "Hedge_Wall_2x1");
            Hedge_Wall_2x1.Name.English("Hedge_Wall_2x1");
            Hedge_Wall_2x1.Description.English("A 2x1 hedge wall");
            Hedge_Wall_2x1.RequiredItems.Add("Wood", 2, true);
            Hedge_Wall_2x1.Category.Set("Hedgewalls");


            BuildPiece Hedge_Wall_4x2 = new("odinhedges", "Hedge_Wall_4x2");
            Hedge_Wall_4x2.Name.English("Hedge_Wall_4x2");
            Hedge_Wall_4x2.Description.English("A 4x2 hedge wall");
            Hedge_Wall_4x2.RequiredItems.Add("Wood", 4, true);
            Hedge_Wall_4x2.Category.Set("Hedgewalls");

            BuildPiece Hedge_Wall_1x1 = new("odinhedges", "Hedge_Wall_1x1");
            Hedge_Wall_1x1.Name.English("Hedge_Wall_1x1");
            Hedge_Wall_1x1.Description.English("A 1x1 hedge wall");
            Hedge_Wall_1x1.RequiredItems.Add("Wood", 1, true);
            Hedge_Wall_1x1.Category.Set("Hedgewalls");

            BuildPiece Hedge_Arch = new("odinhedges", "Hedge_Arch");
            Hedge_Arch.Name.English("Hedge_Arch");
            Hedge_Arch.Description.English("A hedge arch");
            Hedge_Arch.RequiredItems.Add("Wood", 1, true);
            Hedge_Arch.Category.Set("Hedgewalls");

            BuildPiece Hedge_Angle_1x1 = new("odinhedges", "Hedge_Angle_1x1");
            Hedge_Angle_1x1.Name.English("Hedge_Angle_1x1");
            Hedge_Angle_1x1.Description.English("A hedge angle");
            Hedge_Angle_1x1.RequiredItems.Add("Wood", 1, true);
            Hedge_Angle_1x1.Category.Set("Hedgewalls");

            BuildPiece Hedge_Pillar = new("odinhedges", "Hedge_Pillar");
            Hedge_Pillar.Name.English("Hedge_Pillar");
            Hedge_Pillar.Description.English("A hedge pillar");
            Hedge_Pillar.RequiredItems.Add("Wood", 1, true);
            Hedge_Pillar.Category.Set("Hedgewalls");

            BuildPiece Hedge_Beam = new("odinhedges", "Hedge_Beam");
            Hedge_Beam.Name.English("Hedge_Beam");
            Hedge_Beam.Description.English("A hedge beam");
            Hedge_Beam.RequiredItems.Add("Wood", 1, true);
            Hedge_Beam.Category.Set("Hedgewalls");

            BuildPiece Hedge_Beam_2 = new("odinhedges", "Hedge_Beam_2");
            Hedge_Beam_2.Name.English("Hedge_Beam_2");
            Hedge_Beam_2.Description.English("A hedge beam");
            Hedge_Beam_2.RequiredItems.Add("Wood", 1, true);
            Hedge_Beam_2.Category.Set("Hedgewalls");

            BuildPiece Hedge_Pole = new("odinhedges", "Hedge_Pole");
            Hedge_Pole.Name.English("Hedge_Pole");
            Hedge_Pole.Description.English("A hedge pole");
            Hedge_Pole.RequiredItems.Add("Wood", 1, true);
            Hedge_Pole.Category.Set("Hedgewalls");

            BuildPiece Hedge_Pole_2 = new("odinhedges", "Hedge_Pole_2");
            Hedge_Pole_2.Name.English("Hedge_Pole_2");
            Hedge_Pole_2.Description.English("A hedge pole");
            Hedge_Pole_2.RequiredItems.Add("Wood", 1, true);
            Hedge_Pole_2.Category.Set("Hedgewalls");

            BuildPiece Hedge_Inverted_Angle = new("odinhedges", "Hedge_Inverted_Angle");
            Hedge_Inverted_Angle.Name.English("Hedge_Inverted_Angle");
            Hedge_Inverted_Angle.Description.English("An inverted hedge angle");
            Hedge_Inverted_Angle.RequiredItems.Add("Wood", 1, true);
            Hedge_Inverted_Angle.Category.Set("Hedgewalls");

            Assembly assembly = Assembly.GetExecutingAssembly();
            Harmony harmony = new(ModGUID);
            harmony.PatchAll(assembly);
        }


    }
}