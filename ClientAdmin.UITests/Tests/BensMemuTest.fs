module BensMemuTest
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open OpenQA.Selenium

let core _ = 
    context "BensMemuTest"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
//    once (fun _ -> portalLogin ())
//    lastly (fun _ -> portalLogout ())

    "Navigate to NC4 Home Page" &&&& fun _ ->
        url ("http://nc4.com") 
        //displayed "Home"


        displayed "industries"
        highlight "#menu > li:nth-child(4) > a"
        hover "#menu > li:nth-child(4) > a"

        displayed "Aerospace & Defense"

        sleep 5




