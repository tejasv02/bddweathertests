using TechTalk.SpecFlow;
using Xamarin.UITest;
using Should;
using System.Linq;
using NUnit.Framework;
using System;

namespace BddWithXamarinUITest
{
	[Binding]
	public class CommonSteps
	{
		readonly IHomeScreen homeScreen;
		readonly IWeatherResultsScreen weatherResultsScreen;
		readonly IApp app;

		public CommonSteps ()
		{
			app = FeatureContext.Current.Get<IApp>("App");
			homeScreen = FeatureContext.Current.Get<IHomeScreen> (ScreenNames.Home);
			weatherResultsScreen = FeatureContext.Current.Get<IWeatherResultsScreen> (ScreenNames.WeatherResults);
		}

		[Given (@"I am on the Home screen")]
		public void GivenIAmOnTheHomeScreen ()
		{
			app.Screenshot ("Given I am on the Home screen");
		}

		[When (@"I enter zipcode ""(.*)""")]
		public void WhenIEnterZipCode(string zipCode)
		{
			app.ClearText(homeScreen.enterPostCode);
			app.EnterText(homeScreen.enterPostCode, zipCode);
		}

		[When (@"I choose to Get Weather")]
		public void WhenIChooseToGetWeather ()
		{
			app.Tap(homeScreen.getWeatherButton);
		}

		[Then (@"I verify home screen")]
		public void ThenIVerifyHomescreen()
		{
			app.WaitForElement(homeScreen.homeScreenHeader);
			app.WaitForElement(homeScreen.enterPostCode);
			app.WaitForElement(homeScreen.getWeatherButton);
		}

		[Then(@"I verify weather screen")]
		public void ThenIVerifyWeatherResultscreen()
		{
			app.WaitForElement(weatherResultsScreen.Location);
		}
	}
}
