using System;
using Foundation;
using UIKit;

namespace ExtoleiOSLibBinding
{
    // @protocol Extole
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP14ExtoleProxySDK6Extole_")]
    interface Extole
    {
        // @required -(void)initFor:(NSString * _Nonnull)programDomain :(NSString * _Nonnull)applicationName __attribute__((objc_method_family("none")));
        [Abstract]
        [Export("initFor::")]
        void InitFor(string programDomain, string applicationName);

        // @required -(void)fetchZone:(NSString * _Nonnull)zoneName :(NSDictionary<NSString *,NSString *> * _Nonnull)data completion:(void (^ _Nonnull)(Zone * _Nullable, Campaign * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("fetchZone::completion:")]
        void FetchZone(string zoneName, NSDictionary<NSString, NSString> data, Action<Zone, Campaign, NSError> completion);

        // @required -(UIViewController * _Nonnull)getView __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getView")]
        UIViewController View { get; }

        // @required -(void)identify:(NSString * _Nonnull)email :(NSDictionary<NSString *,NSString *> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("identify:::")]
        void Identify(string email, NSDictionary<NSString, NSString> data, Action<Id, NSError> completion);

        // @required -(void)identifyJwt:(NSString * _Nonnull)jwt :(NSDictionary<NSString *,NSString *> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("identifyJwt:::")]
        void IdentifyJwt(string jwt, NSDictionary<NSString, NSString> data, Action<Id, NSError> completion);

        // @required -(void)sendEvent:(NSString * _Nonnull)eventName :(NSDictionary<NSString *,id> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("sendEvent:::")]
        void SendEvent(string eventName, NSDictionary<NSString, NSObject> data, Action<Id, NSError> completion);

        // @required -(void)sendEvent:(NSString * _Nonnull)eventName :(NSDictionary<NSString *,id> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion :(NSString * _Nullable)jwt;
        [Abstract]
        [Export("sendEvent::::")]
        void SendEvent(string eventName, NSDictionary<NSString, NSObject> data, Action<Id, NSError> completion, [NullAllowed] string jwt);

        // @required -(void)logout;
        [Abstract]
        [Export("logout")]
        void Logout();
    }

    // @protocol ICampaign <Extole>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP14ExtoleProxySDK9ICampaign_")]
    interface ICampaign : Extole
    {
        // @required -(NSString * _Nullable)getProgram __attribute__((warn_unused_result("")));
        [Abstract]
        [NullAllowed, Export("getProgram")]
        string Program { get; }

        // @required -(id<IId> _Nonnull)getId __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getId")]
        IId Id { get; }
    }

    // @interface ExtoleImpl : NSObject <Extole>
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtC14ExtoleProxySDK10ExtoleImpl")]
    interface ExtoleImpl : Extole
    {
        // -(void)initFor:(NSString * _Nonnull)programDomain :(NSString * _Nonnull)applicationName __attribute__((objc_method_family("none")));
        [Export("initFor::")]
        void InitFor(string programDomain, string applicationName);

        // -(void)fetchZone:(NSString * _Nonnull)zoneName :(NSDictionary<NSString *,NSString *> * _Nonnull)data completion:(void (^ _Nonnull)(Zone * _Nullable, Campaign * _Nullable, NSError * _Nullable))completion;
        [Export("fetchZone::completion:")]
        void FetchZone(string zoneName, NSDictionary<NSString, NSString> data, Action<Zone, Campaign, NSError> completion);

        // -(void)identify:(NSString * _Nonnull)email :(NSDictionary<NSString *,NSString *> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Export("identify:::")]
        void Identify(string email, NSDictionary<NSString, NSString> data, Action<Id, NSError> completion);

        // -(void)identifyJwt:(NSString * _Nonnull)jwt :(NSDictionary<NSString *,NSString *> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Export("identifyJwt:::")]
        void IdentifyJwt(string jwt, NSDictionary<NSString, NSString> data, Action<Id, NSError> completion);

        // -(void)sendEvent:(NSString * _Nonnull)eventName :(NSDictionary<NSString *,id> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion;
        [Export("sendEvent:::")]
        void SendEvent(string eventName, NSDictionary<NSString, NSObject> data, Action<Id, NSError> completion);

        // -(void)sendEvent:(NSString * _Nonnull)eventName :(NSDictionary<NSString *,id> * _Nonnull)data :(void (^ _Nonnull)(Id * _Nullable, NSError * _Nullable))completion :(NSString * _Nullable)jwt;
        [Export("sendEvent::::")]
        void SendEvent(string eventName, NSDictionary<NSString, NSObject> data, Action<Id, NSError> completion, [NullAllowed] string jwt);

        // -(void)logout;
        [Export("logout")]
        void Logout();

        // -(UIViewController * _Nonnull)getView __attribute__((warn_unused_result("")));
        [Export("getView")]
        UIViewController View { get; }
    }

    // @interface Campaign : ExtoleImpl <ICampaign>
    [Protocol]
    [BaseType(typeof(ExtoleImpl), Name = "_TtC14ExtoleProxySDK8Campaign")]
    [DisableDefaultCtor]
    interface Campaign : ICampaign
    {
        // -(id<IId> _Nonnull)getId __attribute__((warn_unused_result("")));
        [Export("getId")]
        IId Id { get; }

        // -(NSString * _Nullable)getProgram __attribute__((warn_unused_result("")));
        [NullAllowed, Export("getProgram")]
        string Program { get; }
    }

    // @protocol IId
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP14ExtoleProxySDK3IId_")]
    interface IId
    {
        // @required -(NSString * _Nullable)getValue __attribute__((warn_unused_result("")));
        [Abstract]
        [NullAllowed, Export("getValue")]
        string Value { get; }
    }

    // @protocol IZone
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP14ExtoleProxySDK5IZone_")]
    interface IZone
    {
        // @required -(NSString * _Nullable)getName __attribute__((warn_unused_result("")));
        [Abstract]
        [NullAllowed, Export("getName")]
        string Name { get; }

        // @required -(void)tap;
        [Abstract]
        [Export("tap")]
        void Tap();

        // @required -(void)viewed;
        [Abstract]
        [Export("viewed")]
        void Viewed();

        // @required -(id _Nullable)get:(NSString * _Nonnull)dottedPath __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("get:")]
        [return: NullAllowed]
        NSObject Get(string dottedPath);
    }

    // @interface Id : NSObject <IId>
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtC14ExtoleProxySDK2Id")]
    [DisableDefaultCtor]
    interface Id : IId
    {
        // -(NSString * _Nullable)getValue __attribute__((warn_unused_result("")));
        [NullAllowed, Export("getValue")]
        string Value { get; }
    }

    // @interface Zone : NSObject <IZone>
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtC14ExtoleProxySDK4Zone")]
    [DisableDefaultCtor]
    interface Zone : IZone
    {
        // -(NSString * _Nullable)getName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("getName")]
        string Name { get; }

        // -(void)tap;
        [Export("tap")]
        void Tap();

        // -(void)viewed;
        [Export("viewed")]
        void Viewed();

        // -(id _Nullable)get:(NSString * _Nonnull)dottedPath __attribute__((warn_unused_result("")));
        [Export("get:")]
        [return: NullAllowed]
        NSObject Get(string dottedPath);
    }
}