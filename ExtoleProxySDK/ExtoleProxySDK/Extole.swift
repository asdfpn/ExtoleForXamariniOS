//
//  Extole.swift
//  ExtoleProxySDK
//
//  Created by Puneet on 26/05/24.
//

import Foundation
import Extole_iOS
import Logging
import UIKit

@objc
public protocol IZone {
    
    func getName() -> String?

    func tap()

    func viewed()

    func get(_ dottedPath: String) -> Any?
}

@objc
public protocol IId {

    func getValue() -> String?
}

@objc
public protocol ICampaign: Extole {

    func getProgram() -> String?
    func getId() -> IId
}

@objc
public protocol Extole {

    func initFor(_ programDomain: String, _ applicationName: String)
    
    func fetchZone(_ zoneName: String, _ data: [String: String], completion: @escaping (Zone?, Campaign?, Error?) -> Void)

    func getView() -> UIViewController

    func identify(_ email: String, _ data: [String : String], _ completion: @escaping (Id?, Error?) -> Void)

    func identifyJwt(_ jwt: String, _ data: [String : String], _ completion: @escaping (Id?, Error?) -> Void)
    
    func sendEvent(_ eventName: String, _ data: [String : Any], _ completion: @escaping (Id?, Error?) -> Void)

    func sendEvent(_ eventName: String, _ data: [String : Any], _ completion: @escaping (Id?, Error?) -> Void,
                       _ jwt: String?) -> Void
    
    func logout()
    
}
