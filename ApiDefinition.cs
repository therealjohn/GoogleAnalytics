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

        [Field("kGAIUseSecure", "__Internal")]
        NSString UseSecure { get; }

        [Field("kGAIHitType", "__Internal")]
        NSString HitType { get; }

        [Field("kGAITrackingId", "__Internal")]
        NSString TrackingId { get; }

        [Field("kGAIClientId", "__Internal")]
        NSString ClientId { get; }

        [Field("kGAIAnonymizeIp", "__Internal")]
        NSString AnonymizeIp { get; }

        [Field("kGAISessionControl", "__Internal")]
        NSString SessionControl { get; }

        [Field("kGAIScreenResolution", "__Internal")]
        NSString ScreenResolution { get; }

        [Field("kGAIViewportSize", "__Internal")]
        NSString ViewportSize { get; }

        [Field("kGAIEncoding", "__Internal")]
        NSString Encoding { get; }

        [Field("kGAIScreenColors", "__Internal")]
        NSString ScreenColors { get; }

        [Field("kGAILanguage", "__Internal")]
        NSString Language { get; }

        [Field("kGAIJavaEnabled", "__Internal")]
        NSString JavaEnabled { get; }

        [Field("kGAIFlashVersion", "__Internal")]
        NSString FlashVersion { get; }

        [Field("kGAINonInteraction", "__Internal")]
        NSString NonInteraction { get; }

        [Field("kGAIReferrer", "__Internal")]
        NSString Referrer { get; }

        [Field("kGAILocation", "__Internal")]
        NSString Location { get; }

        [Field("kGAIHostname", "__Internal")]
        NSString Hostname { get; }

        [Field("kGAIPage", "__Internal")]
        NSString Page { get; }

        [Field("kGAIDescription", "__Internal")]
        NSString Description { get; }

        [Field("kGAIScreenName", "__Internal")]
        NSString ScreenName { get; }

        [Field("kGAITitle", "__Internal")]
        NSString Title { get; }

        [Field("kGAIAppName", "__Internal")]
        NSString AppName { get; }

        [Field("kGAIAppVersion", "__Internal")]
        NSString AppVersion { get; }

        [Field("kGAIAppId", "__Internal")]
        NSString AppId { get; }

        [Field("kGAIAppInstallerId", "__Internal")]
        NSString AppInstallerId { get; }

        [Field("kGAIEventCategory", "__Internal")]
        NSString EventCategory { get; }

        [Field("kGAIEventAction", "__Internal")]
        NSString EventAction { get; }

        [Field("kGAIEventLabel", "__Internal")]
        NSString EventLabel { get; }

        [Field("kGAIEventValue", "__Internal")]
        NSString EventValue { get; }

        [Field("kGAISocialNetwork", "__Internal")]
        NSString SocialNetwork { get; }

        [Field("kGAISocialAction", "__Internal")]
        NSString SocialAction { get; }

        [Field("kGAISocialTarget", "__Internal")]
        NSString SocialTarget { get; }

        [Field("kGAITransactionId", "__Internal")]
        NSString TransactionId { get; }

        [Field("kGAITransactionAffiliation", "__Internal")]
        NSString TransactionAffiliation { get; }

        [Field("kGAITransactionRevenue", "__Internal")]
        NSString TransactionRevenue { get; }

        [Field("kGAITransactionShipping", "__Internal")]
        NSString TransactionShipping { get; }

        [Field("kGAITransactionTax", "__Internal")]
        NSString TransactionTax { get; }

        [Field("kGAICurrencyCode", "__Internal")]
        NSString CurrencyCode { get; }

        [Field("kGAIItemPrice", "__Internal")]
        NSString ItemPrice { get; }

        [Field("kGAIItemQuantity", "__Internal")]
        NSString ItemQuantity { get; }

        [Field("kGAIItemSku", "__Internal")]
        NSString ItemSku { get; }

        [Field("kGAIItemName", "__Internal")]
        NSString ItemName { get; }

        [Field("kGAIItemCategory", "__Internal")]
        NSString ItemCategory { get; }

        [Field("kGAICampaignSource", "__Internal")]
        NSString CampaignSource { get; }

        [Field("kGAICampaignMedium", "__Internal")]
        NSString CampaignMedium { get; }

        [Field("kGAICampaignName", "__Internal")]
        NSString CampaignName { get; }

        [Field("kGAICampaignKeyword", "__Internal")]
        NSString CampaignKeyword { get; }

        [Field("kGAICampaignContent", "__Internal")]
        NSString CampaignContent { get; }

        [Field("kGAICampaignId", "__Internal")]
        NSString CampaignId { get; }

        [Field("kGAITimingCategory", "__Internal")]
        NSString TimingCategory { get; }

        [Field("kGAITimingVar", "__Internal")]
        NSString TimingVar { get; }

        [Field("kGAITimingValue", "__Internal")]
        NSString TimingValue { get; }

        [Field("kGAITimingLabel", "__Internal")]
        NSString TimingLabel { get; }

        [Field("kGAIExDescription", "__Internal")]
        NSString ExDescription { get; }

        [Field("kGAIExFatal", "__Internal")]
        NSString ExFatal { get; }

        [Field("kGAISampleRate", "__Internal")]
        NSString SampleRate { get; }

        [Field("kGAIAppView", "__Internal")]
        NSString AppView { get; }

        [Field("kGAIEvent", "__Internal")]
        NSString Event { get; }

        [Field("kGAISocial", "__Internal")]
        NSString Social { get; }

        [Field("kGAITransaction", "__Internal")]
        NSString Transaction { get; }

        [Field("kGAIItem", "__Internal")]
        NSString Item { get; }

        [Field("kGAIException", "__Internal")]
        NSString Exception { get; }

        [Field("kGAITiming", "__Internal")]
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
