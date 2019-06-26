using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{

    /*[TestFixture(Platform.iOS)]*/
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            //app.Tap(c => c.Marked("NoResourceEntry-6"));
            //app.Tap(c => c.Marked("NoResourceEntry-7"));
            //app.EnterText("entryUser");

            Assert.IsTrue(results.Any());
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}
