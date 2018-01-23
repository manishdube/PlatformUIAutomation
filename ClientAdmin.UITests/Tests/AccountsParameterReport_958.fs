module AccountsParameterReport_958
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsParameterReport_958"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Parameter Report" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Parameter Report"
        describe "on i360 - Ordered Search Parameters Report page ..."
        displayed "Ordered Search Parameters Report"
        displayed "Organization"
        displayed "Status"
        displayed "State Date"
        displayed "End Date"

    "Perform search" &&&& fun _ ->
       "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
       sleep 10
       click "#ctl00_MainContent_ctl01_CD"
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