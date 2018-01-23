module InternalDatabaseAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalDatabaseAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
        
