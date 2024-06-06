//
//  Extole_iOS.h
//  Extole-iOS
//
//  Created by Puneet on 26/04/24.
//

#import <Foundation/Foundation.h>

//! Project version number for Extole_iOS.
FOUNDATION_EXPORT double Extole_iOSVersionNumber;

//! Project version string for Extole_iOS.
FOUNDATION_EXPORT const unsigned char Extole_iOSVersionString[];

// In this header, you should import all the public headers of your framework using statements like #import <Extole_iOS/PublicHeader.h>


/*!
 *  @brief Delegate provided by the app to the SDK.
 */
@protocol Extole
//- (void)fetchZone:(NSString *)zoneName
//           withData:(NSDictionary<NSString *, NSString *> *)data
//       completion:(void (^)(Zone * _Nullable, Campaign * _Nullable, NSError * _Nullable))completion;
//
//- (void)sendEvent:(NSString *)eventName
//           data:(NSDictionary<NSString *, id> *)data
//       completion:(void (^)(id<Event> _Nullable, NSError * _Nullable))completion;
- (void)logout;
@end
