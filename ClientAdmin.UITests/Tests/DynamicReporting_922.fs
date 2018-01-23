module DynamicReporting_922
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "DynamicReporting_922"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Dynamic Reporting" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/DynamicReporting.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Dynamic Reporting"
        //locateWindowWithTitleText "i360 - Dynamic Reporting"
        describe "on i360 - Dynamic Reporting page ..."

    "Select Options" &&&& fun _ ->
        click "#ctl00_MainContent_lbProcs > option:nth-child(2)"
        sleep 5
        notContains "No data to display" (read "#ctl00_MainContent_gvx")

        click "#ctl00_MainContent_lbProcs > option:nth-child(3)"
        click "#ctl00_MainContent_btnR"
        sleep 5
        click "#ctl00_MainContent_gvx"

        click "#ctl00_MainContent_lbProcs > option:nth-child(4)"
        click "#ctl00_MainContent_btnR"
        sleep 5
        click "#ctl00_MainContent_gvx"

        click "#ctl00_MainContent_lbProcs > option:nth-child(5)"
        click "#ctl00_MainContent_btnR"
        sleep 5
        click "#ctl00_MainContent_gvx"

        click "#ctl00_MainContent_lbProcs > option:nth-child(6)"
        sleep 10
        click "#ctl00_MainContent_gvx"

        click "#ctl00_MainContent_lbProcs > option:nth-child(2)"
        sleep 5
        notContains "No data to display" (read "#ctl00_MainContent_gvx")

        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."