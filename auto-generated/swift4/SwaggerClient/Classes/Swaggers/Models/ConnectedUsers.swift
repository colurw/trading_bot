//
// ConnectedUsers.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct ConnectedUsers: Codable {

    public var users: Int?
    public var bots: Int?

    public init(users: Int?, bots: Int?) {
        self.users = users
        self.bots = bots
    }


}

