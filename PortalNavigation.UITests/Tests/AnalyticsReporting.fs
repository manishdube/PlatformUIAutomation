module AnalyticsReporting
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AnalyticsReporting"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Snapshots" &&&& fun _ ->
        //url (portalUrl + "Analytics/Analytix/SSRSPlus.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Snapshots"
        //locateWindowWithTitleText "i360 - Snapshots"
        describe "on i360 - Snapshots page ..."
        displayed "Snapshots"
        displayed "Select Report:"

    "Dashboards" &&&& fun _ ->
        //url (portalUrl + "Analytics/Analytix/Dashboards.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Dashboards"
        //locateWindowWithTitleText "i360 - Dashboards"
        describe "on i360 - Dashboards page ..."
        displayed "Dashboards"
        displayed "Select Year"
        displayed "Select Dashboard View:"
