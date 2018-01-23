module AccountsBilling
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsBilling"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Billing Report" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBilling.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Report"
        //locateWindowWithTitleText "i360 - Billing Report"
        describe "on i360 - Billing Report page ..."
        displayed "Billing Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"

    "Billing List and Export Detail" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingListAndExportDetail.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing List and Export Detail"
        //locateWindowWithTitleText "i360 - Billing List and Export Detail Report"
        describe "on i360 - Billing List and Export Detail Report page ..."
        displayed "Billing List and Export Detail Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"
        displayed "State"

    "Billing Call Detail" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingCallDetail.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Call Detail"
        //locateWindowWithTitleText "i360 - Billing Call Detail Report"
        describe "on i360 - Billing Call Detail Report page ..."
        displayed "Billing Call Detail Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"
        displayed "Area Code"
        displayed "Cost/Min"

    "Billing Call Summary" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingCallSummary.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Call Summary"
        //locateWindowWithTitleText "i360 - Billing Call Summary Report"
        describe "on i360 - Billing Call Summary Report page ..."
        displayed "Billing Call Summary Report"
        displayed "Start Date"
        displayed "End Date"
