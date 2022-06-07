using System;
using Foundation;
using Intents;
using ObjCRuntime;

namespace WLED.iOS
{
	// @interface ToggleLEDIntent : INIntent
	[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[BaseType (typeof(INIntent))]
	interface ToggleLEDIntent
	{
		// @property (readwrite, copy, nonatomic) NSString * _Nullable LED;
		[NullAllowed, Export ("LED", ArgumentSemantic.Copy)]
		string LED { get; set; }

		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable STATE __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6, 0), Mac (11, 0), iOS (13, 0)]
		[NullAllowed, Export ("STATE", ArgumentSemantic.Copy)]
		NSNumber STATE { get; set; }
	}

	// @protocol ToggleLEDIntentHandling <NSObject>
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
	interface ToggleLEDIntentHandling
	{
		// @required -(void)resolveLEDForToggleLED:(ToggleLEDIntent * _Nonnull)intent withCompletion:(void (^ _Nonnull)(INStringResolutionResult * _Nonnull))completion __attribute__((swift_name("resolveLED(for:with:)"))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6,0), Mac (11,0), iOS (13,0)]
		[Abstract]
		[Export ("resolveLEDForToggleLED:withCompletion:")]
		void ResolveLEDForToggleLED (ToggleLEDIntent intent, Action<INStringResolutionResult> completion);

		// @required -(void)resolveSTATEForToggleLED:(ToggleLEDIntent * _Nonnull)intent withCompletion:(void (^ _Nonnull)(INBooleanResolutionResult * _Nonnull))completion __attribute__((swift_name("resolveSTATE(for:with:)"))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6,0), Mac (11,0), iOS (13,0)]
		[Abstract]
		[Export ("resolveSTATEForToggleLED:withCompletion:")]
		void ResolveSTATEForToggleLED (ToggleLEDIntent intent, Action<INBooleanResolutionResult> completion);

		// @optional -(void)confirmToggleLED:(ToggleLEDIntent * _Nonnull)intent completion:(void (^ _Nonnull)(ToggleLEDIntentResponse * _Nonnull))completion __attribute__((swift_name("confirm(intent:completion:)")));
		[Export ("confirmToggleLED:completion:")]
		void ConfirmToggleLED (ToggleLEDIntent intent, Action<ToggleLEDIntentResponse> completion);

		// @optional -(void)handleToggleLED:(ToggleLEDIntent * _Nonnull)intent completion:(void (^ _Nonnull)(ToggleLEDIntentResponse * _Nonnull))completion __attribute__((swift_name("handle(intent:completion:)")));
		[Export ("handleToggleLED:completion:")]
		void HandleToggleLED (ToggleLEDIntent intent, Action<ToggleLEDIntentResponse> completion);
	}

	// @interface ToggleLEDIntentResponse : INIntentResponse
	[Watch (5,0), NoTV, Mac (11,0), iOS (12,0)]
	[BaseType (typeof(INIntentResponse))]
	[DisableDefaultCtor]
	interface ToggleLEDIntentResponse
	{
		// -(instancetype _Nonnull)initWithCode:(ToggleLEDIntentResponseCode)code userActivity:(NSUserActivity * _Nullable)userActivity __attribute__((objc_designated_initializer));
		[Export ("initWithCode:userActivity:")]
		[DesignatedInitializer]
		IntPtr Constructor (ToggleLEDIntentResponseCode code, [NullAllowed] NSUserActivity userActivity);

		// @property (readwrite, copy, nonatomic) NSNumber * _Nullable state;
		[NullAllowed, Export ("state", ArgumentSemantic.Copy)]
		NSNumber State { get; set; }

		// @property (readonly, nonatomic) ToggleLEDIntentResponseCode code;
		[Export ("code")]
		ToggleLEDIntentResponseCode Code { get; }
	}
}
