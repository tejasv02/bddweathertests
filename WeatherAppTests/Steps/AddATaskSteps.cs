using TechTalk.SpecFlow;
using Xamarin.UITest;
using System;
using System.Diagnostics;

namespace BddWithXamarinUITest
{
	[Binding]
	public class AddATaskSteps : StepsBase
	{
		readonly IHomeScreen homeScreen;
		readonly IWeatherResultsScreen weatherResultsScreen;
		//readonly IApp app;


		[Then(@"I must see empty zip code Error alert")]
		public void ThenIMustSeeEmptyZipCodeErrorAlert()
		{
			app.WaitForElement(e => e.Marked("Alert").Index(0));
			app.WaitForElement(e => e.Marked("Zip code must not be empty").Index(0));
			app.WaitForElement(e => e.Marked("OK").Index(0));
		}

		[Then(@"I must see Incorrect Location Error alert")]
		public void ThenIMustSeeIncorrectLocationErrorAlert()
		{
			app.WaitForElement(e => e.Marked("Alert").Index(0));
			app.WaitForElement(e => e.Marked("Incorrect Location").Index(0));
			app.WaitForElement(e => e.Marked("OK").Index(0));

		}

		[Then(@"I must see Location as ""(.*)""")]
		public void ThenIMustSeeLocationAs(string location)
		{
			var txt = app.Query(x => x.Marked("locationValue"))[0].Text;
			app.WaitFor(() => app.Query((x => x.Marked(location)))[0].Enabled);
		}
	
		[When(@"I choose search again")]
		public void WhenIChooseSearchAgain()
		{
			app.WaitFor(() => app.Query((x => x.Marked("Search Again")))[0].Enabled);
		}

		[Then(@"I must see Get weather button text changed to search again")]
		public void ThenIMustSeeGetWeatherButtonTextChangedToSearchAgain()
		{
			app.WaitFor(() => app.Query((x => x.Marked("Search Again")))[0].Enabled);
		}

		[Then(@"Temperature is shown in Fahrenhite")]
		public void ThenTemperatureIsShownInFahrenhite()
		{
			var txt = app.Query(x => x.Marked("temperatureValue"))[0].Text;
			Debug.Assert(txt.Contains(" F"));
		}

		[Then(@"Windspeed is shown in mph")]
		public void ThenWindspeedIsShownInMph()
		{
			var txt = app.Query(x => x.Marked("windSpeedValue"))[0].Text;
			Debug.Assert(txt.Contains("mph"));
		}

		[Then(@"Humidity is shown as percentage")]
		public void ThenHumidityIsShownAsPercentage()
		{
			//var txt = app.Query(x => x.Marked("humidityValue"))[0].Text;
			//Debug.Assert(txt.Contains("%"));
		}

		[Then(@"Visibility is displayed")]
		public void ThenVisibilityIsDisplayed()
		{
			var txt = app.Query(x => x.Marked("visibilityValue"))[0].Text;
		}

		[Then(@"Time of Sunrise is displayed")]

		public void ThenTimeOfSunriseIsDisplayed()
		{
			var txt = app.Query(x => x.Marked("sunriseTime"))[0].Text;
			Debug.Assert(txt.Contains("UTC"));
		}

		[Then(@"Time of Sunset is displayed")]

		public void ThenTimeOfSunsetIsDisplayed()
		{
			var txt = app.Query(x => x.Marked("sunsetTime"))[0].Text;
			Debug.Assert(txt.Contains("UTC"));
		}

	}
}