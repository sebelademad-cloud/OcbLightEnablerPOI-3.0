using HarmonyLib;
using UnityEngine;

namespace OcbLightEnablerPOI
{
    public class OcbLightEnablerPOI : IModApi
    {
        public void InitMod(Mod mod)
        {
            Debug.Log("[OcbLightEnablerPOI] InitMod called");

            new HarmonyLib.Harmony("ocb.lightenablerpoi").PatchAll();

            Debug.Log("[OcbLightEnablerPOI] Harmony patches applied");
        }
    }
}