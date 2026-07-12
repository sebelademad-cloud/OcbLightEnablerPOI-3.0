using HarmonyLib;

namespace OcbLightEnablerPOI
{
    [HarmonyPatch(typeof(GameManager))]
    [HarmonyPatch("StartGame")]
    internal class TestPatch
    {
        static void Postfix()
        {
            UnityEngine.Debug.Log("[OcbLightEnablerPOI] Harmony is working!");
        }
    }
}