using ObjCRuntime;

namespace WLED.iOS
{
	[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[Native]
	public enum ToggleAllLEDsIntentResponseCode : long
	{
		Unspecified = 0,
		Ready,
		ContinueInApp,
		InProgress,
		Success,
		Failure,
		FailureRequiringAppLaunch
	}
}
