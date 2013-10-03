using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGoogleAnalyticsServices.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "CoreData SystemConfiguration", ForceLoad = true, LinkerFlags="-lsqlite3.0 -lz")]
