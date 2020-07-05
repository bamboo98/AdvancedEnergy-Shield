using HarmonyLib;
using RimWorld;
using Verse;
using zhuzi.AdvancedEnergy.Shields.Shields;
namespace zhuzi.AdvancedEnergy.Shields.Patch
{

    [HarmonyPatch(typeof(StatWorker), "ShouldShowFor")]
    static class StatWorker_ShouldShowFor
    {
        static bool Prefix(StatWorker __instance, StatRequest req, ref bool __result, ref StatDef ___stat)
        {
            if (___stat.category == Resources.StatCategory.zzShield_stat && req.Thing is Building_Shield)
            {
                __result = true;
                return false;
            }
            return true;
        }
    }
}
