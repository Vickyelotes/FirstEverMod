using BepInEx;
using BepInEx.Logging;
using FirstEverMod.Patches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEverMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Nomodfirst : BaseUnityPlugin
    {
        private const string modGUID = "Vickyelotes.FirstEverMod";
        private const string modName = "TestingMod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Nomodfirst Instance;

        internal ManualLogSource mls;


        void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("There is no mod lmao");

            harmony.PatchAll(typeof(Nomodfirst));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
