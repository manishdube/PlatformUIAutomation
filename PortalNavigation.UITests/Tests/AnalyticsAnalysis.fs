module AnalyticsAnalysis
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AnalyticsAnalysis"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Upload Documents" &&&& fun _ ->
        //url (portalUrl + "Analytics/Docs/Docs.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Upload Documents"
//        //locateWindowWithTitleText "i360 - Upload Documents"
        describe "on i360 - Upload Documents page ..."
        displayed "Upload Documents"
        displayed "Poll Date:"
        displayed "Description:"
        displayed "Tags:"

    "View Documents" &&&& fun _ ->
        //url (portalUrl + "Analytics/Docs/EditDocs.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "View Documents"
        describe "on i360 - Analytics: View Documents page ..."
        displayed "View Documents"
