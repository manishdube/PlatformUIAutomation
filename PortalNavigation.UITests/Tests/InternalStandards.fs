module InternalStandards
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalStandards"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Style Guide" &&&& fun _ ->
        //url (portalUrl + "Admin/StyleGuide.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Style Guide"
        //locateWindowWithTitleText "i360 - Style Guide"
        describe "on i360 - Style Guide page ..."
        displayed "Accordians"

    "jqxGrid Demo" &&&& fun _ ->
        //url (portalUrl + "Test/jqxGridDemo.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "jqxGrid Demo"
        //locateWindowWithTitleText "i360 - jqxGrid Demo"
        describe "on i360 - jqxGrid Demo page ..."
