using HarmonyLib;
using UnityEngine;

namespace OcbLightEnablerPOI.Patches
{
    [HarmonyPatch(typeof(BlockLight))]
    [HarmonyPatch(nameof(BlockLight.GetBlockActivationCommands))]
    internal class BlockLightActivationCommandsPatch
    {
        static void Postfix(
            WorldBase _world,
            ref BlockActivationCommand[] __result)
        {
            Debug.Log("[OcbLightEnablerPOI] GetBlockActivationCommands called");

            if (__result == null)
                return;

            if (__result.Length > 0)
                __result[0].enabled = true;
        }
    }
}