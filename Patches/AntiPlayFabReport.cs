using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using PlayFab;

namespace BetterPlayers.Patches
{
    [HarmonyPatch(typeof(PlayFabClientInstanceAPI), "ReportPlayer")]
    internal class AntiPlayFabReport
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            return false;
        }
    }
}
