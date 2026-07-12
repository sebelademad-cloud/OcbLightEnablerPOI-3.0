using System.Linq;
using System.Reflection;
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

            harmony.PatchAll(Assembly.GetExecutingAssembly());

            foreach (var method in harmony.GetPatchedMethods())
            {
                Debug.Log($"[OcbLightEnablerPOI] Patched: {method.DeclaringType}.{method.Name}");
            }
        }
    }
}