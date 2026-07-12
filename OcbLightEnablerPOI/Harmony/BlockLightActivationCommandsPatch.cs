using HarmonyLib;

namespace OcbLightEnablerPOI.Patches
{
    [HarmonyPatch(typeof(BlockLight), nameof(BlockLight.GetBlockActivationCommands))]
    internal class BlockLightActivationCommandsPatch
    {
        static void Prefix(BlockLight __instance)
        {
            __instance.isRuntimeSwitch = true;
        }
    }
}