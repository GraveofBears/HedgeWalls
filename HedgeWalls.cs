using System.IO;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using PieceManager;

//using ServerSync;

namespace HedgeWalls
{
    [BepInPlugin(HGUIDLower, ModName, version)]
    public class HedgeWallsPlugin : BaseUnityPlugin
    {
        public const string version = "1.0.3";
        public const string ModName = "HedgeWalls";
        internal const string Author = "Gravebear";
        internal const string HGUID = Author + "." + "HedgeWalls";
        internal const string HGUIDLower = "gravebear.hedgewalls";
        private const string HarmonyGUID = "Harmony." + Author + "." + ModName;
        private static string ConfigFileName = HGUIDLower + ".cfg";
        private static string ConfigFileFullPath = Paths.ConfigPath + Path.DirectorySeparatorChar + ConfigFileName;
        public static string ConnectionError = "";


        private void Awake()
        {
            BuildPiece Hedge_Wall_2x1 = new("odinhedges", "Hedge_Wall_2x1");
            Hedge_Wall_2x1.Name.English("Hedge_Wall_2x1");
            Hedge_Wall_2x1.Description.English("A 2x1 hedge wall");
            Hedge_Wall_2x1.RequiredItems.Add("Wood", 2, true);

            BuildPiece Hedge_Wall_4x2 = new("odinhedges", "Hedge_Wall_4x2");
            Hedge_Wall_4x2.Name.English("Hedge_Wall_4x2");
            Hedge_Wall_4x2.Description.English("A 4x2 hedge wall");
            Hedge_Wall_4x2.RequiredItems.Add("Wood", 4, true);

            BuildPiece Hedge_Wall_1x1 = new("odinhedges", "Hedge_Wall_1x1");
            Hedge_Wall_1x1.Name.English("Hedge_Wall_1x1");
            Hedge_Wall_1x1.Description.English("A 1x1 hedge wall");
            Hedge_Wall_1x1.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Arch = new("odinhedges", "Hedge_Arch");
            Hedge_Arch.Name.English("Hedge_Arch");
            Hedge_Arch.Description.English("A hedge arch");
            Hedge_Arch.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Angle_1x1 = new("odinhedges", "Hedge_Angle_1x1");
            Hedge_Angle_1x1.Name.English("Hedge_Angle_1x1");
            Hedge_Angle_1x1.Description.English("A hedge angle");
            Hedge_Angle_1x1.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Pillar = new("odinhedges", "Hedge_Pillar");
            Hedge_Pillar.Name.English("Hedge_Pillar");
            Hedge_Pillar.Description.English("A hedge pillar");
            Hedge_Pillar.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Beam = new("odinhedges", "Hedge_Beam");
            Hedge_Beam.Name.English("Hedge_Beam");
            Hedge_Beam.Description.English("A hedge beam");
            Hedge_Beam.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Beam_2 = new("odinhedges", "Hedge_Beam_2");
            Hedge_Beam_2.Name.English("Hedge_Beam_2");
            Hedge_Beam_2.Description.English("A hedge beam");
            Hedge_Beam_2.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Pole = new("odinhedges", "Hedge_Pole");
            Hedge_Pole.Name.English("Hedge_Pole");
            Hedge_Pole.Description.English("A hedge pole");
            Hedge_Pole.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Pole_2 = new("odinhedges", "Hedge_Pole_2");
            Hedge_Pole_2.Name.English("Hedge_Pole_2");
            Hedge_Pole_2.Description.English("A hedge pole");
            Hedge_Pole_2.RequiredItems.Add("Wood", 1, true);

            BuildPiece Hedge_Inverted_Angle = new("odinhedges", "Hedge_Inverted_Angle");
            Hedge_Inverted_Angle.Name.English("Hedge_Inverted_Angle");
            Hedge_Inverted_Angle.Description.English("A hedge angle");
            Hedge_Inverted_Angle.RequiredItems.Add("Wood", 1, true);


        }


    }
}