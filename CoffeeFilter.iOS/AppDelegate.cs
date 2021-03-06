﻿using UIKit;
using Foundation;

namespace CoffeeFilter.iOS
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		const string GoogleMapsAPIKey = "AIzaSyAAOpU0qjK0LBTe2UCCxPQP1iTaSv_Xihw";

		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			#if DEBUG
			Xamarin.Insights.Initialize("ef02f98fd6fb47ce8624862ab7625b933b6fb21d");
			#else
			Xamarin.Insights.Initialize ("8da86f8b3300aa58f3dc9bbef455d0427bb29086");
			#endif

			// Register Google maps key to use street view
			Google.Maps.MapServices.ProvideAPIKey(GoogleMapsAPIKey);

			// Code to start the Xamarin Test Cloud Agent
			#if UITest
			Xamarin.Calabash.Start();
			#endif

			return true;
		}
	}
}