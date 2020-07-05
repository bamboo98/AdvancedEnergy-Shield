using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using HugsLib;
using HugsLib.Settings;
using HugsLib.Utils;
using RimWorld;
using UnityEngine;
using UnityEngine.SceneManagement;
using Verse;
using zhuzi.AdvancedEnergy.Shields.Patch;

namespace zhuzi.AdvancedEnergy.Shields.Shields
{
    class Manager : ModBase
    {
        public static Manager Instance { get; private set; }
        public override string ModIdentifier
        {
            get { return "zzShield"; }
        }
        public Manager()
        {
            Instance = this;
        }
    }
}
