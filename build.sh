#!/bin/sh
set -e

xcodebuild -project "/Users/puneet/Downloads/ExtoleProxySDK/ExtoleProxySDK.xcodeproj" archive \
  -scheme "ExtoleProxySDK" \
  -configuration Release \
  -archivePath "build/ExtoleProxySDK-simulator.xcarchive" \
  -destination "generic/platform=iOS Simulator" \
  -derivedDataPath "build" \
  -IDECustomBuildProductsPath="" -IDECustomBuildIntermediatesPath="" \
  ENABLE_BITCODE=NO \
  SKIP_INSTALL=NO \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcodebuild -project "/Users/puneet/Downloads/ExtoleProxySDK/ExtoleProxySDK.xcodeproj" archive \
   -scheme "ExtoleProxySDK" \
   -configuration Release \
   -archivePath "build/ExtoleProxySDK-ios.xcarchive" \
   -destination "generic/platform=iOS" \
   -derivedDataPath "build" \
   -IDECustomBuildProductsPath="" -IDECustomBuildIntermediatesPath="" \
   ENABLE_BITCODE=NO \
   SKIP_INSTALL=NO \
   BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcodebuild -create-xcframework \
  	-framework "build/ExtoleProxySDK-ios.xcarchive/Products/Library/Frameworks/ExtoleProxySDK.framework" \
  	-framework "build/ExtoleProxySDK-simulator.xcarchive/Products/Library/Frameworks/ExtoleProxySDK.framework" \
  	-output "build/ExtoleProxySDK.xcframework"

sharpie bind --sdk=iphoneos17.5 --output="XamarinApiDef" --namespace="ExtoleiOSBindingLibrary" --scope="/Users/puneet/Downloads/Output/build/ExtoleProxySDK.xcframework/ios-arm64/ExtoleProxySDK.framework/Headers/" "/Users/puneet/Downloads/Output/build/ExtoleProxySDK.xcframework/ios-arm64/ExtoleProxySDK.framework/Headers/ExtoleProxySDK-Swift.h"
