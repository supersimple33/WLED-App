//
// ToggleAllLEDsIntent.m
//
// This file was automatically generated and should not be edited.
//

#import "ToggleAllLEDsIntent.h"

#if __has_include(<Intents/Intents.h>) && !TARGET_OS_TV

@implementation ToggleAllLEDsIntent

@dynamic STATE;

@end

@interface ToggleAllLEDsIntentResponse ()

@property (readwrite, NS_NONATOMIC_IOSONLY) ToggleAllLEDsIntentResponseCode code;

@end

@implementation ToggleAllLEDsIntentResponse

@synthesize code = _code;

@dynamic state, state1;

- (instancetype)initWithCode:(ToggleAllLEDsIntentResponseCode)code userActivity:(nullable NSUserActivity *)userActivity {
	self = [super init];
	if (self) {
		_code = code;
		self.userActivity = userActivity;
	}
	return self;
}

@end

#endif
