using HarmonyLib;

namespace OcbLightEnablerPOI.Patches
{
    /// <summary>
    /// Enables runtime interaction with vanilla POI lights.
    ///
    /// Vanilla only allows the "light" activation command while
    /// World Editor mode is active. This patch invokes the same
    /// internal light-switching logic without requiring editor mode.
    /// </summary>
    [HarmonyPatch(typeof(BlockLight), nameof(BlockLight.OnBlockActivated))]
    internal class BlockLightOnBlockActivatedPatch
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
            // Only intercept the runtime light toggle.
            // All other activation commands use the vanilla implementation.
            if (_commandName != "light")
                return true;

            __result = __instance.updateLightState(
                _world,
                _blockPos,
                _blockValue,
                true,
                false);

            // Prevent the original implementation from running,
            // as it only allows activation while in World Editor mode.
            return false;
        }
    }
}