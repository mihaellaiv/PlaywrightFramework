﻿using PlaywrightFramework.Base;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestsUI.Base;

namespace TestsUI.Hooks
{
    [Binding]
    class InitializeHooks : PlaywrightDriver
    {
        [BeforeFeature]
        public static async Task BeforeFeature()
        {
            Page = await InitalizePlaywright(SettingsConfiguration.Browser);
        }
    }
}