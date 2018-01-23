module AccountsSearchadmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsSearchadmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Searches" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/SavedSearchAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Searches"
        //locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed "Searches"
        displayed "Start Date"
        displayed "End Date"
        displayed "Organization"
        displayed "User"
        displayed "Combined"
        displayed "Active"
        displayed "Status"

    "Parameter Report" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrderedSearchParameters.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Parameter Report"
        //locateWindowWithTitleText "i360 - Ordered Search Parameters Report"
        describe "on i360 - Ordered Search Parameters Report page ..."
        displayed "Ordered Search Parameters Report"
        displayed "Organization"
        displayed "Status"
        displayed "State Date"
        displayed "End Date"
