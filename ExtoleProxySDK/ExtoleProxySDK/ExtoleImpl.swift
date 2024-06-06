//
//  ExtoleImpl.swift
//  ExtoleProxySDK
//
//  Created by Puneet on 26/05/24.
//

import Foundation
import Extole_iOS
import Logging
import UIKit
import SwiftUI

@objc
public class ExtoleImpl: NSObject, Extole {
    
    var sharedInstance: Extole_iOS.Extole? = nil
    
    public func initFor(_ programDomain: String, _ applicationName: String){
        
        print("Init Extole")
        
        self.sharedInstance = Extole_iOS.ExtoleImpl(programDomain: programDomain, applicationName: applicationName)
        
        print("Finished Init Extole")
        
    }
    
    public func fetchZone(_ zoneName: String, _ data: [String : String], completion: @escaping (Zone?, Campaign?, (any Error)?) -> Void) {
        
        self.sharedInstance?.fetchZone(zoneName, data, completion: { zone, campaign, error in
            completion(Zone.init(zone), Campaign.init(campaign) , error)
        })
    }
    
    public func identify(_ email: String, _ data: [String : String], _ completion: @escaping (( Id)?, (any Error)?) -> Void) {
        
        self.sharedInstance?.identify(email, data, { id, error in
            completion(Id.init(id?.getValue()), error)
        })
    }
    
    public func identifyJwt(_ jwt: String, _ data: [String : String], _ completion: @escaping (( Id)?, (any Error)?) -> Void) {
        
        self.sharedInstance?.identifyJwt(jwt, data, { id, error in
            completion(Id.init(id?.getValue()), error)
        })
    }
    
    public func sendEvent(_ eventName: String, _ data: [String : Any], _ completion: @escaping (( Id)?, (any Error)?) -> Void) {
        
        self.sharedInstance?.sendEvent(eventName, data, { id, error in
            completion(Id.init(id?.getValue()), error)
        })
    }
    
    public func sendEvent(_ eventName: String, _ data: [String : Any], _ completion: @escaping (( Id)?, (any Error)?) -> Void, _ jwt: String?) {
        
        self.sharedInstance?.sendEvent(eventName, data, { id, error in
            completion(Id.init(id?.getValue()), error)
        }, jwt)
    }
    
    public func logout() {
        
        self.sharedInstance?.logout()
    }
    
    public func getView() -> UIViewController {
        
        let swiftUIViewController = UIHostingController(rootView: self.sharedInstance?.getView())
        
        let controller = UIViewController()
        controller.addChild(swiftUIViewController)
        controller.view.addSubview(swiftUIViewController.view)
        swiftUIViewController.didMove(toParent: controller)
        return controller
    }
    
    //    public func fetchZone() {
    //        self.sharedInstance?.fetchZone("mobile_cta", [:], completion: { zone, campaign,_ in
    //            print("Zone Response", zone?.get("title"))
    //        })
    //    }
    //
    //    public func sendEvent() {
    //        self.sharedInstance?.sendEvent("deeplink", ["extole_name":""], nil, nil)
    //        print("Hello from SendEvent!!")
    //    }
    
}

@objc
public class Zone: NSObject, IZone {
    
    private var zone: Extole_iOS.Zone?
    
    public init(_ zone: Extole_iOS.Zone?) {
        self.zone = zone
    }
        
    public func getName() -> String? {
        
        return self.zone?.getName()
    }
    
    public func tap() {
     
        self.zone?.tap()
    }
    
    public func viewed() {
        
        self.zone?.viewed()
    }
    
    public func get(_ dottedPath: String) -> Any? {
        
        return self.zone?.get(dottedPath)
    }
}

@objc
public class Campaign : ExtoleImpl, ICampaign  {
    
    private var campaign: Extole_iOS.Campaign?
    
    public init(_ campaign: Extole_iOS.Campaign?) {
        self.campaign = campaign
    }
    
    public func getId() -> any IId {
        return Id.init(self.campaign?.getId().getValue())
    }
    
    public func getProgram() -> String? {
        
        return self.campaign?.getProgram()
    }
}

@objc
public class Id : NSObject, IId {
    
    let value: String?

    init(_ element: String?) {
        value = element
    }

    public func getValue() -> String? {
        return value
    }
}
