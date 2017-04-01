using System;
using Xamarin.UITest.Queries;

namespace BddWithXamarinUITest
{
	public interface IHomeScreen
	{
		Func<AppQuery, AppQuery> homeScreenHeader {get;}
		Func<AppQuery, AppQuery> enterPostCode { get; }
		Func<AppQuery, AppQuery> getWeatherButton { get; }
		Func<AppQuery, AppQuery> emptyZipAlert { get; }


	}	
}