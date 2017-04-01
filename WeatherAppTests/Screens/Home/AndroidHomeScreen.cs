using System;
using Xamarin.UITest.Queries;

namespace BddWithXamarinUITest
{
	public class AndroidHomeScreen : IHomeScreen
	{
		public Func<AppQuery, AppQuery> homeScreenHeader { get; } = new Func<AppQuery, AppQuery> (c => c.Marked("xxx"));
		public Func<AppQuery, AppQuery> enterPostCode { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("xxx"));
		public Func<AppQuery, AppQuery> getWeatherButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Get Weather"));
		public Func<AppQuery, AppQuery> emptyZipAlert { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Get Weather"));
}		
}