using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace OcbLightEnablerPOI
{
    public class OcbLightEnablerPOI : IModApi
    {
        public void InitMod(Mod mod)
        {
            Debug.Log("[OcbLightEnablerPOI] InitMod called");

            var harmony = new HarmonyLib.Harmony("ocb.lightenablerpoi");
            harmony.PatchAll();

            Debug.Log($"[OcbLightEnablerPOI] Patched methods: {harmony.GetPatchedMethods().Count()}");

            Debug.Log("[OcbLightEnablerPOI] Harmony patches applied");
        }
    }
}