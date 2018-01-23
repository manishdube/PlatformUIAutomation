module InternalTesting
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalTesting"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Metric 1" &&&& fun _ ->
        //url (portalUrl + "Test/Metric1.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metric 1"
        //locateWindowWithTitleText "i360 - Metric 1"
        describe "on i360 - Metric 1 page ..."
        displayed "Metric 1"

    "Metric 2" &&&& fun _ ->
        //url (portalUrl + "Test/Metric2.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metric 2"
        //locateWindowWithTitleText "i360 - Metric 2"
        describe "on i360 - Metric 2 page ..."
        displayed "Metric 2"

    "Test 1" &&&& fun _ ->
        //url (portalUrl + "Test/Test1.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Test 1"
        //locateWindowWithTitleText "i360 - Test 1"
        describe "on i360 - Test 1 page ..."
        displayed "Test 1"

    "Civic Information" &&&& fun _ ->
        //url (portalUrl + "Admin/CivicInformation.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Civic Information"
        //locateWindowWithTitleText "i360 - Civic Information"
        describe "on i360 - Civic Information page ..."
        displayed "Civic Information"    