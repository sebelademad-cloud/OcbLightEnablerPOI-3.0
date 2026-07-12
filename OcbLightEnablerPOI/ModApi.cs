using HarmonyLib;

namespace OcbLightEnablerPOI
{
    public class OcbLightEnablerPOI : IModApi
    {
        public void InitMod(Mod mod)
        {
            var harmony = new HarmonyLib.Harmony("ocb.lightenablerpoi");
            harmony.PatchAll();
        }
    }
}