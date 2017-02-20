using System;
using Xamarin.UITest.Queries;

namespace BddWithXamarinUITest
{
	public class AndroidWeatherSearchResullts : IWeatherResultsScreen
	{
		public Func<AppQuery, AppQuery> Location { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Location"));
		public Func<AppQuery, AppQuery> Temperature { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Temperature"));
		public Func<AppQuery, AppQuery> WindSpeed { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Wind Speed"));
		public Func<AppQuery, AppQuery> Humidity { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Humidity"));
		public Func<AppQuery, AppQuery> Visibility { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Visibility"));
		public Func<AppQuery, AppQuery> TimeOfSunRise { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Time of Sunrise"));
}

}