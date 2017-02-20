using System;
using Xamarin.UITest.Queries;

namespace BddWithXamarinUITest
{
	public class iOSHomeScreen : IHomeScreen
	{
		public Func<AppQuery, AppQuery> homeScreenHeader { get; } = new Func<AppQuery, AppQuery> (c => c.Marked("Sample Weather App"));
		public Func<AppQuery, AppQuery> enterPostCode { get; } = new Func<AppQuery, AppQuery>(c => c.Class("UITextField"));
		public Func<AppQuery, AppQuery> getWeatherButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Get Weather"));
	}	
}