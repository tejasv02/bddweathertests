using System;
using Xamarin.UITest.Queries;

namespace BddWithXamarinUITest
{
	public interface IWeatherResultsScreen
	{
		Func<AppQuery, AppQuery> Location {get;}
		Func<AppQuery, AppQuery> Temperature {get;}
		Func<AppQuery, AppQuery> WindSpeed {get;}
		Func<AppQuery, AppQuery> Humidity { get; }
		Func<AppQuery, AppQuery> Visibility { get; }
		Func<AppQuery, AppQuery> TimeOfSunRise { get; }
	}
}