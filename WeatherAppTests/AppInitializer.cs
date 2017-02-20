using Xamarin.UITest;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Diagnostics;
using System;

namespace BddWithXamarinUITest
{
	public static class AppInitializer
	{
		public static IApp StartApp (Platform platform, string iOSSimulator, bool resetDevice)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if (platform == Platform.Android) {

				return ConfigureApp
					.Android
					.ApkFile ("../../binaries/com.xamarin.samples.taskydroidnew.exampleapp.apk")
					.EnableLocalScreenshots ()
					.StartApp ();
				
			} else if (platform == Platform.iOS) {
				
				return ConfigureApp
					.iOS
					.EnableLocalScreenshots ()
					.AppBundle ("../../../binaries/WeatherAppiOS.app")
					//.DeviceIdentifier(iOSSimulator)
					.DeviceIdentifier("6F704F23-E36D-48DE-BD92-42CAA928F40B")
					.StartApp ();
			}

			throw new ArgumentException ("Unsupported platform");
		}

	
		public static void InitializeScreens(Platform platform)
		{
			if (platform == Platform.iOS) {
				FeatureContext.Current.Add (ScreenNames.Home, new iOSHomeScreen ());
				FeatureContext.Current.Add (ScreenNames.WeatherResults, new iOSWeatherSearchResullts ());
			} else if (platform == Platform.Android) {
				FeatureContext.Current.Add (ScreenNames.Home, new AndroidHomeScreen ());
				FeatureContext.Current.Add (ScreenNames.WeatherResults, new AndroidWeatherSearchResullts ());
			}
		}
	}
}