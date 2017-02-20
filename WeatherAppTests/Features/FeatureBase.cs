using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;

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
		public void BeforeEachScenario ()
		{
			app = AppInitializer.StartApp (platform, iOSSimulator, resetDevice);
			FeatureContext.Current.Add ("App", app);
			AppInitializer.InitializeScreens (platform);
		}
	}

}