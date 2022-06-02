XBUILD=xcodebuild
PROJECT_ROOT=./
PROJECT=$(PROJECT_ROOT)/WLEDIntentStaticLib.xcodeproj
TARGET=WLEDIntentStaticLib

all: bind

lib$(TARGET)-simulator.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator EXCLUDED_ARCHS="arm64" -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

lib$(TARGET)-device.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

lib$(TARGET).a: lib$(TARGET)-simulator.a lib$(TARGET)-device.a
	xcrun -sdk iphoneos lipo -create -output $@ $^

bind: lib$(TARGET).a
	sharpie bind -scope WLEDIntentStaticLib -output bo -namespace WLED.iOS -sdk iphoneos$(shell xcrun --show-sdk-platform-version --sdk iphoneos) WLEDIntentStaticLib/ToggleAllLEDsIntent.h
	sharpie bind -scope WLEDIntentStaticLib -output bo -namespace WLED.iOS -sdk iphoneos$(shell xcrun --show-sdk-platform-version --sdk iphoneos) WLEDIntentStaticLib/ToggleLEDIntent.h

clean:
	-rm -rf bo build *.a *.dll
