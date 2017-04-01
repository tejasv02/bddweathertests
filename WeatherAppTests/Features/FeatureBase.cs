using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;
using System;

namespace BddWithXamarinUITest
{
	[TestFixture(Platform.iOS, iPhone6.OS_10_2)]
	//[TestFixture (Platform.Android, "")]

	public class FeatureBase
	{
		protected static IApp app;
		protected Platform platform;
		protected string iOSSimulator;
		protected bool resetDevice;

		public FeatureBase (Platform platform, string iOSSimulator, bool resetDevice = true)
		{
			this.iOSSimulator = iOSSimulator;
			this.platform = platform;
			this.resetDevice = resetDevice;
		}

		[SetUp]
		public void Before()
		{
			app = AppInitializer.StartApp (platform, iOSSimulator, resetDevice);
			FeatureContext.Current.Clear();
			FeatureContext.Current.Remove("App");
			FeatureContext.Current.Add ("App", app);
			AppInitializer.InitializeScreens (platform);
		}

		[Before]
		public void BeforeEachScenario()
		{
			app = AppInitializer.StartApp(platform, iOSSimulator, resetDevice);
			//FeatureContext.Current.Add("App", app);
			//AppInitializer.InitializeScreens(platform);
		}

		[AfterScenarioBlock]
		public void AfterEachScenario()
		{
			//FeatureContext.Current.Remove("App");
		}

	}

}