module GrassrootsSharedResources
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "GrassrootsSharedResources"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Network Calendar" &&&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Network Calendar"
        //locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
        displayed "Legend"
        displayed "Filter events by organization"

    "Shared Locations" &&&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Shared Locations"
        //locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."

    "Shared Talent" &&&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Shared Talent"
        //locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."      