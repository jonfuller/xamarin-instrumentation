using System;
using Android.Runtime;
using Xamarin.Android.NUnitLite;
using NUnit.Framework;
using Android.App;
using SampleApp;

namespace Sample
{
    [Instrumentation(TargetPackage = "SampleApp.SampleApp")]
    public class TestRunner : TestSuiteInstrumentation
    {
        public static Instrumentation TheInstrumentation;

        public TestRunner(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
            TheInstrumentation = this;
        }

        protected override void AddTests ()
        {
            AddTest (GetType ().Assembly);
        }
    }
    
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void TrueShouldBeTrue()
        {
            Assert.IsTrue (true, "Truth");
        }

        [Test]
        public void ResourceTest()
        {
            Assert.That (new BusinessObject (TestRunner.TheInstrumentation.TargetContext).GetAppName (), Is.EqualTo ("SampleApp"));
        }
    }
}
