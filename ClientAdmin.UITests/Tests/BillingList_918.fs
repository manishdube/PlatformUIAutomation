module BillingList_918
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "BillingList_918"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

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

    "Search" &&&& fun _ ->
        "#ctl00_MainContent_tbStart" << "2/1/2017"
        //"#ctl00_MainContent_ddlOrg" << "Americans for Prosperity"
        "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
        click "#ctl00_MainContent_btnSearch"
        sleep 20
        notContains "No data to display" (read "#ctl00_MainContent_gvx")
        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."
