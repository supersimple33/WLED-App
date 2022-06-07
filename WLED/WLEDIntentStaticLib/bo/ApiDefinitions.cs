using System;
using Foundation;
using Intents;
using ObjCRuntime;

namespace WLED.iOS
{
	// @interface ToggleAllLEDsIntent : INIntent
	[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[BaseType (typeof(INIntent))]
	interface ToggleAllLEDsIntent
	{
		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable STATE __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6, 0), Mac (11, 0), iOS (13, 0)]
		[NullAllowed, Export ("STATE", ArgumentSemantic.Copy)]
		NSNumber STATE { get; set; }
	}

	// @protocol ToggleAllLEDsIntentHandling <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ToggleAllLEDsIntentHandling
	{
		// @required -(void)resolveSTATEForToggleAllLEDs:(ToggleAllLEDsIntent * _Nonnull)intent withCompletion:(void (^ _Nonnull)(INBooleanResolutionResult * _Nonnull))completion __attribute__((swift_name("resolveSTATE(for:with:)"))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6,0), Mac (11,0), iOS (13,0)]
		[Abstract]
		[Export ("resolveSTATEForToggleAllLEDs:withCompletion:")]
		void ResolveSTATEForToggleAllLEDs (ToggleAllLEDsIntent intent, Action<INBooleanResolutionResult> completion);

		// @optional -(void)confirmToggleAllLEDs:(ToggleAllLEDsIntent * _Nonnull)intent completion:(void (^ _Nonnull)(ToggleAllLEDsIntentResponse * _Nonnull))completion __attribute__((swift_name("confirm(intent:completion:)")));
		[Export ("confirmToggleAllLEDs:completion:")]
		void ConfirmToggleAllLEDs (ToggleAllLEDsIntent intent, Action<ToggleAllLEDsIntentResponse> completion);

		// @optional -(void)handleToggleAllLEDs:(ToggleAllLEDsIntent * _Nonnull)intent completion:(void (^ _Nonnull)(ToggleAllLEDsIntentResponse * _Nonnull))completion __attribute__((swift_name("handle(intent:completion:)")));
		[Export ("handleToggleAllLEDs:completion:")]
		void HandleToggleAllLEDs (ToggleAllLEDsIntent intent, Action<ToggleAllLEDsIntentResponse> completion);
	}

	// @interface ToggleAllLEDsIntentResponse : INIntentResponse
	[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[BaseType (typeof(INIntentResponse))]
	[DisableDefaultCtor]
	interface ToggleAllLEDsIntentResponse
	{
		// -(instancetype _Nonnull)initWithCode:(ToggleAllLEDsIntentResponseCode)code userActivity:(NSUserActivity * _Nullable)userActivity __attribute__((objc_designated_initializer));
		[Export ("initWithCode:userActivity:")]
		[DesignatedInitializer]
		IntPtr Constructor (ToggleAllLEDsIntentResponseCode code, [NullAllowed] NSUserActivity userActivity);

		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable state;
		[NullAllowed, Export ("state", ArgumentSemantic.Copy)]
		NSNumber State { get; set; }

		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable state1;
		[NullAllowed, Export ("state1", ArgumentSemantic.Copy)]
		NSNumber State1 { get; set; }

		// @property (readonly, nonatomic) ToggleAllLEDsIntentResponseCode code;
		[Export ("code")]
		ToggleAllLEDsIntentResponseCode Code { get; }
	}
}
