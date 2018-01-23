module UserByClientOrg_934
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "UserByClientOrg_934"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Users By Client Org" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUsersByOrg.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Users By Client Org"
        //locateWindowWithTitleText "i360 - Users By Client"
        describe "on i360 - Users By Client page ..."
        displayed "Users By Client"
        displayed "Client:"
        click "#ctl00_MainContent_ddlOrg"
        "#ctl00_MainContent_ddlOrg" << "All"
        click "#ctl00_MainContent_ddlOrg"
        sleep 10
        notContains "No data to display" (read "#aspnetForm > div.container.body-content > div > div.row.margin-top-10 > div")
        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."

    "Use the filter" &&&& fun _ ->
        //"#ctl00_MainContent_gvx_DXFREditorcol0_I" << "Americans for Prosperity"
        "#ctl00_MainContent_gvx_DXFREditorcol0_I" << cmbxOrg_I
        press enter
        sleep 15
        contains cmbxOrg_I (read "#ctl00_MainContent_gvx_DXDataRow0 > td:nth-child(1)")
        describe "done ..."