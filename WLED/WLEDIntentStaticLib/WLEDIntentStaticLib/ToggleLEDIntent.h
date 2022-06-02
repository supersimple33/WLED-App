//
// ToggleLEDIntent.h
//
// This file was automatically generated and should not be edited.
//

#if __has_include(<Intents/Intents.h>)

#import <Intents/Intents.h>

NS_ASSUME_NONNULL_BEGIN

API_AVAILABLE(ios(12.0), macos(10.16), watchos(5.0)) API_UNAVAILABLE(tvos)
@interface ToggleLEDIntent : INIntent

@property (readwrite, copy, nullable, nonatomic) NSString *LED;
@property (readwrite, copy, nullable, nonatomic) NSNumber *STATE API_AVAILABLE(ios(13.0), macos(10.16), watchos(6.0));

@end

@class ToggleLEDIntentResponse;

/*!
 @abstract Protocol to declare support for handling a ToggleLEDIntent. By implementing this protocol, a class can provide logic for resolving, confirming and handling the intent.
 @discussion The minimum requirement for an implementing class is that it should be able to handle the intent. The confirmation method is optional. The handling method is always called last, after confirming the intent.
 */
API_AVAILABLE(ios(12.0), macos(10.16), watchos(5.0)) API_UNAVAILABLE(tvos)
@protocol ToggleLEDIntentHandling <NSObject>

@required

/*!
@abstract Resolution methods - Determine if this intent is ready for the next step (confirmation)
@discussion Called to make sure the app extension is capable of handling this intent in its current form. This method is for validating if the intent needs any further fleshing out.

@param  intent The input intent
@param  completion The response block contains an INIntentResolutionResult for the parameter being resolved

@see INIntentResolutionResult
*/
- (void)resolveLEDForToggleLED:(ToggleLEDIntent *)intent withCompletion:(void (^)(INStringResolutionResult *resolutionResult))completion NS_SWIFT_NAME(resolveLED(for:with:)) API_AVAILABLE(ios(13.0), macos(10.16), watchos(6.0));

- (void)resolveSTATEForToggleLED:(ToggleLEDIntent *)intent withCompletion:(void (^)(INBooleanResolutionResult *resolutionResult))completion NS_SWIFT_NAME(resolveSTATE(for:with:)) API_AVAILABLE(ios(13.0), macos(10.16), watchos(6.0));

@optional

/*!
 @abstract Confirmation method - Validate that this intent is ready for the next step (i.e. handling)
 @discussion Called prior to asking the app to handle the intent. The app should return a response object that contains additional information about the intent, which may be relevant for the system to show the user prior to handling. If unimplemented, the system will assume the intent is valid, and will assume there is no additional information relevant to this intent.

 @param  intent The input intent
 @param  completion The response block contains a ToggleLEDIntentResponse containing additional details about the intent that may be relevant for the system to show the user prior to handling.

 @see ToggleLEDIntentResponse
 */
- (void)confirmToggleLED:(ToggleLEDIntent *)intent completion:(void (^)(ToggleLEDIntentResponse *response))completion NS_SWIFT_NAME(confirm(intent:completion:));

/*!
 @abstract Handling method - Execute the task represented by the ToggleLEDIntent that's passed in
 @discussion Called to actually execute the intent. The app must return a response for this intent.

 @param  intent The input intent
 @param  completion The response handling block takes a ToggleLEDIntentResponse containing the details of the result of having executed the intent

 @see  ToggleLEDIntentResponse
 */
- (void)handleToggleLED:(ToggleLEDIntent *)intent completion:(void (^)(ToggleLEDIntentResponse *response))completion NS_SWIFT_NAME(handle(intent:completion:));

@end

/*!
 @abstract Constants indicating the state of the response.
 */
typedef NS_ENUM(NSInteger, ToggleLEDIntentResponseCode) {
	ToggleLEDIntentResponseCodeUnspecified = 0,
	ToggleLEDIntentResponseCodeReady,
	ToggleLEDIntentResponseCodeContinueInApp,
	ToggleLEDIntentResponseCodeInProgress,
	ToggleLEDIntentResponseCodeSuccess,
	ToggleLEDIntentResponseCodeFailure,
	ToggleLEDIntentResponseCodeFailureRequiringAppLaunch
} API_AVAILABLE(ios(12.0), macos(10.16), watchos(5.0)) API_UNAVAILABLE(tvos);

API_AVAILABLE(ios(12.0), macos(10.16), watchos(5.0)) API_UNAVAILABLE(tvos)
@interface ToggleLEDIntentResponse : INIntentResponse

- (instancetype)init NS_UNAVAILABLE;

/*!
 @abstract Initializes the response object with the specified code and user activity object.
 @discussion The app extension has the option of capturing its private state as an NSUserActivity and returning it as the 'currentActivity'. If the app is launched, an NSUserActivity will be passed in with the private state. The NSUserActivity may also be used to query the app's UI extension (if provided) for a view controller representing the current intent handling state. In the case of app launch, the NSUserActivity will have its activityType set to the name of the intent. This intent object will also be available in the NSUserActivity.interaction property.

 @param  code The response code indicating your success or failure in confirming or handling the intent.
 @param  userActivity The user activity object to use when launching your app. Provide an object if you want to add information that is specific to your app. If you specify nil, the system automatically creates a user activity object for you, sets its type to the class name of the intent being handled, and fills it with an INInteraction object containing the intent and your response.
 */
- (instancetype)initWithCode:(ToggleLEDIntentResponseCode)code userActivity:(nullable NSUserActivity *)userActivity NS_DESIGNATED_INITIALIZER;

@property (readwrite, copy, nullable, nonatomic) NSNumber *state;

/*!
 @abstract The response code indicating your success or failure in confirming or handling the intent.
 */
@property (readonly, NS_NONATOMIC_IOSONLY) ToggleLEDIntentResponseCode code;

@end

NS_ASSUME_NONNULL_END

#endif
