using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace GoogleAnalytics
{
    [BaseType(typeof(NSObject))]
    public partial interface GAI
    {
        [Export("defaultTracker", ArgumentSemantic.Assign)]
        GAITracker DefaultTracker { get; set; }

        [Export("logger", ArgumentSemantic.Assign)]
        GAILogger Logger { get; set; }

        [Export("optOut")]
        bool OptOut { get; set; }

        [Export("dispatchInterval")]
        double DispatchInterval { get; set; }

        [Export("trackUncaughtExceptions")]
        bool TrackUncaughtExceptions { get; set; }

        [Export("dryRun")]
        bool DryRun { get; set; }

        [Static, Export("sharedInstance")]
        GAI SharedInstance { get; }

        [Export("trackerWithName:trackingId:")]
        GAITracker TrackerWithName(string name, string trackingId);

        [Export("trackerWithTrackingId:")]
        GAITracker TrackerWithTrackingId(string trackingId);

        [Static, Export("removeTrackerByName:")]
        void RemoveTrackerByName(string name);

        [Export("dispatch")]
        void Dispatch();
    }

    [BaseType(typeof(NSObject))]
    public partial interface GAIDictionaryBuilder
    {
        [Export("set:forKey:")]
        GAIDictionaryBuilder Set(string value, string key);

        [Export("setAll:")]
        GAIDictionaryBuilder SetAll(NSDictionary pairs);

        [Export("get:")]
        string Get(string paramName);

        [Export("build")]
        NSMutableDictionary Build();

        [Export("setCampaignParametersFromUrl:")]
        GAIDictionaryBuilder SetCampaignParametersFromUrl(string urlString);

        [Static, Export("createAppView")]
        GAIDictionaryBuilder CreateAppView();

        [Static, Export("createEventWithCategory:action:label:value:")]
        GAIDictionaryBuilder CreateEventWithCategory(string category, string action, string label, NSNumber value);

        [Static, Export("createExceptionWithDescription:withFatal:")]
        GAIDictionaryBuilder CreateExceptionWithDescription(string description, NSNumber fatal);

        [Static, Export("createItemWithTransactionId:name:sku:category:price:quantity:currencyCode:")]
        GAIDictionaryBuilder CreateItemWithTransactionId(string transactionId, string name, string sku, string category, NSNumber price, NSNumber quantity, string currencyCode);

        [Static, Export("createSocialWithNetwork:action:target:")]
        GAIDictionaryBuilder CreateSocialWithNetwork(string network, string action, string target);

        [Static, Export("createTimingWithCategory:interval:name:label:")]
        GAIDictionaryBuilder CreateTimingWithCategory(string category, NSNumber intervalMillis, string name, string label);

        [Static, Export("createTransactionWithId:affiliation:revenue:tax:shipping:currencyCode:")]
        GAIDictionaryBuilder CreateTransactionWithId(string transactionId, string affiliation, NSNumber revenue, NSNumber tax, NSNumber shipping, string currencyCode);
    }

    [BaseType(typeof(NSObject))]
    public partial interface GAIFields
    {
        [Static, Export("contentGroupForIndex:")]
        string ContentGroupForIndex(uint index);

        [Static, Export("customDimensionForIndex:")]
        string CustomDimensionForIndex(uint index);

        [Static, Export("customMetricForIndex:")]
        string CustomMetricForIndex(uint index);

        [Field("GAIUseSecure", "__Internal")]
        NSString UseSecure { get; }

        [Field("GAIHitType", "__Internal")]
        NSString HitType { get; }

        [Field("GAITrackingId", "__Internal")]
        NSString TrackingId { get; }

        [Field("GAIClientId", "__Internal")]
        NSString ClientId { get; }

        [Field("GAIAnonymizeIp", "__Internal")]
        NSString AnonymizeIp { get; }

        [Field("GAISessionControl", "__Internal")]
        NSString SessionControl { get; }

        [Field("GAIScreenResolution", "__Internal")]
        NSString ScreenResolution { get; }

        [Field("GAIViewportSize", "__Internal")]
        NSString ViewportSize { get; }

        [Field("GAIEncoding", "__Internal")]
        NSString Encoding { get; }

        [Field("GAIScreenColors", "__Internal")]
        NSString ScreenColors { get; }

        [Field("GAILanguage", "__Internal")]
        NSString Language { get; }

        [Field("GAIJavaEnabled", "__Internal")]
        NSString JavaEnabled { get; }

        [Field("GAIFlashVersion", "__Internal")]
        NSString FlashVersion { get; }

        [Field("GAINonInteraction", "__Internal")]
        NSString NonInteraction { get; }

        [Field("GAIReferrer", "__Internal")]
        NSString Referrer { get; }

        [Field("GAILocation", "__Internal")]
        NSString Location { get; }

        [Field("GAIHostname", "__Internal")]
        NSString Hostname { get; }

        [Field("GAIPage", "__Internal")]
        NSString Page { get; }

        [Field("GAIDescription", "__Internal")]
        NSString Description { get; }

        [Field("GAIScreenName", "__Internal")]
        NSString ScreenName { get; }

        [Field("GAITitle", "__Internal")]
        NSString Title { get; }

        [Field("GAIAppName", "__Internal")]
        NSString AppName { get; }

        [Field("GAIAppVersion", "__Internal")]
        NSString AppVersion { get; }

        [Field("GAIAppId", "__Internal")]
        NSString AppId { get; }

        [Field("GAIAppInstallerId", "__Internal")]
        NSString AppInstallerId { get; }

        [Field("GAIEventCategory", "__Internal")]
        NSString EventCategory { get; }

        [Field("GAIEventAction", "__Internal")]
        NSString EventAction { get; }

        [Field("GAIEventLabel", "__Internal")]
        NSString EventLabel { get; }

        [Field("GAIEventValue", "__Internal")]
        NSString EventValue { get; }

        [Field("GAISocialNetwork", "__Internal")]
        NSString SocialNetwork { get; }

        [Field("GAISocialAction", "__Internal")]
        NSString SocialAction { get; }

        [Field("GAISocialTarget", "__Internal")]
        NSString SocialTarget { get; }

        [Field("GAITransactionId", "__Internal")]
        NSString TransactionId { get; }

        [Field("GAITransactionAffiliation", "__Internal")]
        NSString TransactionAffiliation { get; }

        [Field("GAITransactionRevenue", "__Internal")]
        NSString TransactionRevenue { get; }

        [Field("GAITransactionShipping", "__Internal")]
        NSString TransactionShipping { get; }

        [Field("GAITransactionTax", "__Internal")]
        NSString TransactionTax { get; }

        [Field("GAICurrencyCode", "__Internal")]
        NSString CurrencyCode { get; }

        [Field("GAIItemPrice", "__Internal")]
        NSString ItemPrice { get; }

        [Field("GAIItemQuantity", "__Internal")]
        NSString ItemQuantity { get; }

        [Field("GAIItemSku", "__Internal")]
        NSString ItemSku { get; }

        [Field("GAIItemName", "__Internal")]
        NSString ItemName { get; }

        [Field("GAIItemCategory", "__Internal")]
        NSString ItemCategory { get; }

        [Field("GAICampaignSource", "__Internal")]
        NSString CampaignSource { get; }

        [Field("GAICampaignMedium", "__Internal")]
        NSString CampaignMedium { get; }

        [Field("GAICampaignName", "__Internal")]
        NSString CampaignName { get; }

        [Field("GAICampaignKeyword", "__Internal")]
        NSString CampaignKeyword { get; }

        [Field("GAICampaignContent", "__Internal")]
        NSString CampaignContent { get; }

        [Field("GAICampaignId", "__Internal")]
        NSString CampaignId { get; }

        [Field("GAITimingCategory", "__Internal")]
        NSString TimingCategory { get; }

        [Field("GAITimingVar", "__Internal")]
        NSString TimingVar { get; }

        [Field("GAITimingValue", "__Internal")]
        NSString TimingValue { get; }

        [Field("GAITimingLabel", "__Internal")]
        NSString TimingLabel { get; }

        [Field("GAIExDescription", "__Internal")]
        NSString ExDescription { get; }

        [Field("GAIExFatal", "__Internal")]
        NSString ExFatal { get; }

        [Field("GAISampleRate", "__Internal")]
        NSString SampleRate { get; }

        [Field("GAIAppView", "__Internal")]
        NSString AppView { get; }

        [Field("GAIEvent", "__Internal")]
        NSString Event { get; }

        [Field("GAISocial", "__Internal")]
        NSString Social { get; }

        [Field("GAITransaction", "__Internal")]
        NSString Transaction { get; }

        [Field("GAIItem", "__Internal")]
        NSString Item { get; }

        [Field("GAIException", "__Internal")]
        NSString Exception { get; }

        [Field("GAITiming", "__Internal")]
        NSString Timing { get; }
    }

    [BaseType(typeof(NSObject))]
    public partial interface GAILogger
    {
        [Export("logLevel")]
        GAILogLevel LogLevel { get; set; }

        [Export("verbose:")]
        void Verbose(string message);

        [Export("info:")]
        void Info(string message);

        [Export("warning:")]
        void Warning(string message);

        [Export("error:")]
        void Error(string message);
    }

    [BaseType(typeof(UIViewController))]
    public partial interface GAITrackedViewController
    {
        [Export("tracker")]
        GAITracker Tracker { get; set; }

        [Export("screenName")]
        string ScreenName { get; set; }

        [Field ("kGAIProduct", "__Internal")]
        NSString GAIProduct { get; }

        [Field ("kGAIVersion", "__Internal")]
        NSString GAIVersion { get; }

        [Field ("kGAIErrorDomain", "__Internal")]
        NSString GAIErrorDomain { get; }
    }

    [BaseType(typeof(NSObject))]
    public partial interface GAITracker
    {
        [Export("name")]
        string Name { get; }

        [Export("set:value:")]
        void Set(string parameterName, string value);

        [Export("get:")]
        string Get(string parameterName);

        [Export("send:")]
        void Send(NSDictionary parameters);
    }
}
