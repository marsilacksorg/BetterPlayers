using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppSystem;
using Il2CppSystem.IO;
using MelonLoader;
using static BetterPlayers.Plugin;

namespace BetterPlayers.Patches
{
    public class Folder
    {
        public static void CreateBetterPlayersFolder()
        {
            if (!Directory.Exists("BetterPlayers"))
            {
                Directory.CreateDirectory("BetterPlayers");
            }
        }

        public static void DoAllChecks()
        {
            CheckForAllModsEnabled();
            DisableImJustFastBro();
            DisableImNotUsingPSA();
            DisableICanGetOutTheMap();
        }

        public static void CheckForAllModsEnabled()
        {
            string path = Path.Combine(System.Environment.CurrentDirectory, "BetterPlayers");
            string File = "AllMods.txt";
            string FullPath = Path.Combine(path, File);

            if (Il2CppSystem.IO.File.Exists(FullPath))
            {
                Plugin.ImJustFastBro = true;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = true;
            }
        }

        public static void DisableImJustFastBro()
        {
            string path = Path.Combine(System.Environment.CurrentDirectory, "BetterPlayers");
            string File = "NoSpeedBoost.txt";
            string FullPath = Path.Combine(path, File);
            
            string FileV2 = "NoPSA.txt";
            string FullPathV2 = Path.Combine(path, FileV2);

            string FileV3 = "NoPlatforms.txt";
            string FullPathV3 = Path.Combine(path, FileV3);

            if (Il2CppSystem.IO.File.Exists(FullPath))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = true;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV2))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = false;
                Plugin.ICanGetOutTheMap = true;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV3))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = false;
            }
        }

        public static void DisableImNotUsingPSA()
        {
            string path = Path.Combine(System.Environment.CurrentDirectory, "BetterPlayers");
            string File = "NoPSA.txt";
            string FullPath = Path.Combine(path, File);

            string FileV2 = "NoSpeedBoost.txt";
            string FullPathV2 = Path.Combine(path, FileV2);

            string FileV3 = "NoPlatforms.txt";
            string FullPathV3 = Path.Combine(path, FileV3);

            if (Il2CppSystem.IO.File.Exists(FullPath))
            {
                Plugin.ImJustFastBro = true;
                Plugin.ImNotUsingPSA = false;
                Plugin.ICanGetOutTheMap = true;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV2))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = false;
                Plugin.ICanGetOutTheMap = true;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV3))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = false;
            }
        }

        public static void DisableICanGetOutTheMap()
        {
            string path = Path.Combine(System.Environment.CurrentDirectory, "BetterPlayers");
            string File = "NoPlatforms.txt";
            string FullPath = Path.Combine(path, File);

            string FileV2 = "NoPSA.txt";
            string FullPathV2 = Path.Combine(path, FileV2);

            string FileV3 = "NoSpeedBoost.txt";
            string FullPathV3 = Path.Combine(path, FileV3);

            if (Il2CppSystem.IO.File.Exists(FullPath))
            {
                Plugin.ImJustFastBro = true;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = false;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV2))
            {
                Plugin.ImJustFastBro = true;
                Plugin.ImNotUsingPSA = false;
                Plugin.ICanGetOutTheMap = false;
            }
            else if (Il2CppSystem.IO.File.Exists(FullPath) && Il2CppSystem.IO.File.Exists(FullPathV3))
            {
                Plugin.ImJustFastBro = false;
                Plugin.ImNotUsingPSA = true;
                Plugin.ICanGetOutTheMap = false;
            }
        }
    }
}
