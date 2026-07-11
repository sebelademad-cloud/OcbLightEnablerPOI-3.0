using HarmonyLib;

namespace OcbLightEnablerPOI
{
    public class OcbLightEnablerPOI : IModApi
    {
        public void InitMod(Mod mod)
        {
            new Harmony("ocb.lightenablerpoi").PatchAll();
        }
    }
}