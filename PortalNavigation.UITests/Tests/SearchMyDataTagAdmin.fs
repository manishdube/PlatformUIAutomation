module SearchMyDataTagAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "SearchMyDataTagAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "MyData Tags" &&&& fun _ ->
        //url (portalUrl + "CRM/TagAdmin.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "#Menu1\3a submenu\3a 14 > li:nth-child(1) > a"
        //locateWindowWithTitleText "i360 - MyData Tags"
        describe "on 360 - MyData Tags page ..."
        displayed "MyData Tags"

    "MyData Categories" &&&& fun _ ->
        //url (portalUrl + "CRM/CatAdmin.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "#Menu1\3a submenu\3a 14 > li:nth-child(2) > a"
        //locateWindowWithTitleText "i360 - MyData Categories"
        describe "on i360 - MyData Categories page ..."
        displayed "MyData Categories" 
