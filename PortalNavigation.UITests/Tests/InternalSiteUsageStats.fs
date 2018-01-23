module InternalSiteUsageStats
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalSiteUsageStats"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Stats Admin" &&&& fun _ ->
        //url (portalUrl + "Admin/StatsAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Stats Admin"
//        //locateWindowWithTitleText "i360 - Usage Statistics Admin"
        describe "on i360 - Usage Statistics Admin page ..."
        displayed "Usage Statistics Admin"
        displayed "Start Date"
        displayed "End Date"

    "Usage Stats Report One" &&&& fun _ ->
        //url (portalUrl + "Admin/rptUsageStats1.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Usage Stats Report One"
//        //locateWindowWithTitleText "i360 - Usage Statistics Report"
        describe "on i360 - Usage Statistics Report page ..."
        displayed "Usage Statistics Report"
        displayed "Start Date"
        displayed "End Date"

    "Usage Stats Chart One" &&&& fun _ ->
        //url (portalUrl + "Admin/rptUsageStatsChart1.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Usage Stats Chart One"
//        //locateWindowWithTitleText "i360 - Usage"
        describe "on i360 - Usage page ..."
        displayed "Usage"
        displayed "Graph Type"
        displayed "Graph Style"
        displayed "Graph Pallete"
        displayed "Width"
        displayed "Height"
        displayed "Start Date"
        displayed "End Date"

    "Metrics" &&&& fun _ ->
        //url (portalUrl + "Admin/Metrics.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metrics"
//        //locateWindowWithTitleText "i360 - Metrics"
        describe "on i360 - Metrics page ..."
        //displayed "Date Range Type"
        displayed "Metrics"
        displayed "Start"
        displayed "End"
        displayed "Type"

        