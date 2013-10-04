GoogleAnalytics
===============

Xamarin.iOS Binding Project for Google Analytics 3.01

Building
========

This is a Xamarin.iOS Binding Project. Create a solution and add an "Existing Project". Choose the `GoogleAnalytics.csproj` file to add the project to your solution. Build the project to create the `GoogleAnalytics.dll`. You can now package that `.dll` with your project and reference it to use the API. 

Getting Started
===============

You can specify the settings like this:

    GAI.SharedInstance.TrackUncaughtExceptions = true;
    GAI.SharedInstance.DispatchInterval = 20;
    ...

To send a page view:

    var tracker = GAI.SharedInstance.TrackerWithTrackerId("UA-XXXXX-YY"); // Input your GA tracking Id. 
    tracker.Set(GAIFields.ScreenName, "MyHomeScreen");
    tracker.Send(GAIDictionaryBuilder.CreateAppView().Build());

To send an event:

    var tracker = GAI.SharedInstance.TrackerWithTrackerId("UA-XXXXX-YY"); // Input your GA tracking Id. 
    tracker.Send(GAIDictionaryBuilder.CreateEventWithCategory("TestCategory1", "TestingAction1", "TestLabel1", 0).Build());



