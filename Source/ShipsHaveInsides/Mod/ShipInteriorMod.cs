﻿using HugsLib;
using HugsLib.Settings;
using HugsLib.Utils;
using System.Collections.Generic;
using Verse;

namespace ShipsHaveInsides.Mod
{
    public class ShipInteriorMod : ModBase
    {
        public static ModLogger instLogger;
        public static bool saveShip;
        public static Building shipRoot;

        public static ShipInteriorMod instance;

        public override string ModIdentifier
        {
            get
            {
                return nameof(ShipInteriorMod);
            }
        }

        public override void Initialize()
        {
            ShipInteriorMod.instLogger = this.Logger;
            instance = this;
            
        }

        public static void Log(string toLog)
        {
            ShipInteriorMod.instLogger.Message(toLog, new object[0]);
        }

        public SettingHandle<float> shipSolarPanelOutput;
        public SettingHandle<int> minTravelTime;
        public SettingHandle<int> maxTravelTime;
        public SettingHandle<bool> leaveCryptosleepBug;

        public override void DefsLoaded()
        {
            base.DefsLoaded();

            shipSolarPanelOutput = Settings.GetHandle("shipSolarPanelOutput", "Ship Solar Panel Output", "Maximum ouptut of the folding solar panels, for your tweaking pleasure.", 800f);
            minTravelTime = Settings.GetHandle("minTravelTime", "Minimum Travel Time", "Minimum amount of years that pass when travelling via ship.", 1);
            maxTravelTime = Settings.GetHandle("maxTravelTime", "Maximum Travel Time", "Maximum amount of years that pass when travelling via ship.", 100);
            leaveCryptosleepBug = Settings.GetHandle("leaveCryptosleepBug", "Leave Cryptosleeps Bugged", "This one's for you, Nimble.", false);
        }
    }
}