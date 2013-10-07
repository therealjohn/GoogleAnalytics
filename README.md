# GoogleAnalytics

Xamarin.iOS Binding Project for Google Analytics 3.01

## Building

This is a Xamarin.iOS Binding Project. Open the solution, build the project, use the built `.dll` in your Xamarin.iOS app. A built `.dll` is also already in the bin directory if you can't build for some reason.  

## Getting Started

Include the `.dll`.

```cs
using GoogleAnalytics;
```

You can specify the settings like this:

```cs
GAI.SharedInstance.TrackUncaughtExceptions = true;
GAI.SharedInstance.DispatchInterval = 20;
...
```

To send a page view:

```cs
var tracker = GAI.SharedInstance.TrackerWithTrackingId("UA-XXXXX-YY"); // Input your GA tracking Id. 
tracker.Set(GAIFields.ScreenName, "MyHomeScreen");
tracker.Send(GAIDictionaryBuilder.CreateAppView().Build());
```

To send an event:

```cs
var tracker = GAI.SharedInstance.TrackerWithTrackingId("UA-XXXXX-YY"); // Input your GA tracking Id. 
tracker.Send(GAIDictionaryBuilder.CreateEventWithCategory("TestCategory1", "TestingAction1", "TestLabel1", 0).Build());
```



