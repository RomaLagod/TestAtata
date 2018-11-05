using Atata;
using NUnit.Framework;

namespace AtataSamples.NetCore.NUnit
{
    public class SignInTestChrome70 : UITestFixtureChrome70
    {
        [Test]
        public void NetCoreNUnit_SignInChrome70()
        {
            Go.To<SignInPage>().
               Email.Set("lead@fluxday.io").
               Wait(8).
               Password.Set("password").
               Wait(8).
               Login.Click().
               Wait(10).
               Task.Should.Equals("+Task");
        } 
    }

    public class SignInTestChrome69 : UITestFixtureChrome69
    {
        [Test]
        public void NetCoreNUnit_SignInChrome69()
        {
            Go.To<SignInPage>().
               Email.Set("lead@fluxday.io").
               Wait(8).
               Password.Set("password").
               Wait(8).
               Login.Click().
               Wait(10).
               Task.Should.Equals("+Task");
        }
    }

    public class SignInTestFirefox62 : UITestFixtureFirefox62
    {
        [Test]
        public void NetCoreNUnit_SignInFirefox62()
        {
            Go.To<SignInPage>().
               Email.Set("lead@fluxday.io").
               Wait(8).
               Password.Set("password").
               Wait(8).
               Login.Click().
               Wait(10).
               Task.Should.Equals("+Task");
        }
    }

    public class SignInTestFirefox63 : UITestFixtureFirefox63
    {
        [Test]
        public void NetCoreNUnit_SignInFirefox63()
        {
            Go.To<SignInPage>().
               Email.Set("lead@fluxday.io").
               Wait(8).
               Password.Set("password").
               Wait(8).
               Login.Click().
               Wait(10).
               Task.Should.Equals("+Task");
        }
    }
}
