using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterPlayers.Patches;
using MelonLoader;

namespace BetterPlayers
{
    public class Plugin : MelonMod
    {
        public override void OnEarlyInitializeMelon()
        {
            base.OnEarlyInitializeMelon();
            Folder.CreateBetterPlayersFolder(); // Creates the BetterPlayers folder
            Folder.DoAllChecks(); // Checks for mods enabled or disabled
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            Main.ImJustFastBro(); // Loads the mod to be used
            Main.ImNotUsingPSA(); // Loads the mod to be used
            Main.ICanGetOutTheMap(); // Loads the mod to be used
        }


        // Bools
        public static bool ImJustFastBro = false;
        public static bool ImNotUsingPSA = false;
        public static bool ICanGetOutTheMap = false;
    }
}
