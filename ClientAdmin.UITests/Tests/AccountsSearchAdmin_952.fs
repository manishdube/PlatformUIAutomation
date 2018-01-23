module AccountsSearchAdmin_952
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsSearchAdmin_952"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Searches Page" &&&& fun _ ->
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

    "Perform search" &&&& fun _ ->
       "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
       sleep 5
       click "#ctl00_MainContent_btnxRetrieve_CD"
       click "#ctl00_MainContent_btnxRetrieve_CD > span"
       sleep 20
       notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
       describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."