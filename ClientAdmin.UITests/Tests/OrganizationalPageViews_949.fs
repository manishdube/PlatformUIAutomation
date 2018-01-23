module OrganizationalPageViews_949
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalPageViews_949"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Organization Page Views" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrgPageViews.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Page Views"
        //locateWindowWithTitleText "i360 - Organization Page Views"
        describe "on i360 - Organization Page Views page ..."
        displayed "Organization Page Views"
        displayed "Client Organization"

    "Select Client Org" &&&& fun _ ->
        "#ctl00_MainContent_ddlOrg" << "i360"
        sleep 10
        notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."
