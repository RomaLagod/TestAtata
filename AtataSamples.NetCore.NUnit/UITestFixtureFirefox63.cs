using Atata;
using Microsoft.DotNet.InternalAbstractions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using Platform = OpenQA.Selenium.Platform;

namespace AtataSamples.NetCore.NUnit
{
    [TestFixture]
    public class UITestFixtureFirefox63
    {
        string baseUrl = "https://app.fluxday.io/users/sign_in";
        string nodeUrl = "http://172.22.84.113:4444/wd/hub";

        [SetUp]
        public void SetUp()
        {
            var capabilities = new DesiredCapabilities("firefox", "63.0", new Platform(PlatformType.Any));
            capabilities.SetCapability("enableVNC", true);

            AtataContext.Configure().
                UseRemoteDriver().
                    WithCapabilities(capabilities).
                    WithRemoteAddress(new Uri(nodeUrl)).
                UseBaseUrl(baseUrl).
                UseWaitingTimeout(new TimeSpan(0, 0, 10)).
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                Build();

            AtataContext.Current.Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
