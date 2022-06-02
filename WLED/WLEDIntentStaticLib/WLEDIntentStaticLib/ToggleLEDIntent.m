//
// ToggleLEDIntent.m
//
// This file was automatically generated and should not be edited.
//

#import "ToggleLEDIntent.h"

#if __has_include(<Intents/Intents.h>) && !TARGET_OS_TV

@implementation ToggleLEDIntent

@dynamic LED, STATE;

@end

@interface ToggleLEDIntentResponse ()

@property (readwrite, NS_NONATOMIC_IOSONLY) ToggleLEDIntentResponseCode code;

@end

@implementation ToggleLEDIntentResponse

@synthesize code = _code;

@dynamic state;

- (instancetype)initWithCode:(ToggleLEDIntentResponseCode)code userActivity:(nullable NSUserActivity *)userActivity {
	self = [super init];
	if (self) {
		_code = code;
		self.userActivity = userActivity;
	}
	return self;
}

@end

#endif
