using HarmonyLib;
using UnityEngine;

namespace OcbLightEnablerPOI.Harmony
{
    [HarmonyPatch(typeof(BlockLight), nameof(BlockLight.OnBlockActivated))]
    internal class BlockLightActivatedPatch
    {
        static bool Prefix(
            BlockLight __instance,
            string _commandName,
            WorldBase _world,
            Vector3i _blockPos,
            BlockValue _blockValue,
            EntityPlayerLocal _player,
            ref bool __result)
        {
            // Let vanilla handle every other command
            if (_commandName != "light")
                return true;

            Debug.Log("[OcbLightEnablerPOI] Intercepted light activation");

            __result = __instance.updateLightState(
                _world,
                _blockPos,
                _blockValue,
                true,
                false);

            return false; // Skip the original method
        }
    }
}