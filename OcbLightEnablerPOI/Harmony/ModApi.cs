using HarmonyLib;

namespace OcbLightEnablerPOI
{
    public class OcbLightEnablerPOI : IModApi
    {
        public void InitMod(Mod mod)
        {
            Harmony harmony = new Harmony("ocb.lightenablerpoi");
            harmony.PatchAll();
        }
    }
}