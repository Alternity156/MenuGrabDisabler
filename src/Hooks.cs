using Harmony;
using System;
using UnityEngine;

namespace AudicaModding
{
    internal static class Hooks
    {
        [HarmonyPatch(typeof(GrabScroll), "OnGrab", new Type[] { typeof(Gun), typeof(Vector3) })]
        private static class PatchSetState
        {
            private static bool Prefix(GrabScroll __instance, Gun gun, Vector3 grabPos)
            {
                return false;
            }
        }
    }
}