module OrderedSearchReportbyUser_938
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrderedSearchReportbyUser_938"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Ordered Search Report By User" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Ordered Search Report By User"
        //locateWindowWithTitleText "i360 - Ordered Search Report by User"
        describe "on i360 - Ordered Search Report by User page ..."
        displayed "Ordered Search Report by User"
        displayed "Status"
        displayed "Start Date"
        displayed "End Date"
        describe "done ..."

    "Search" &&&& fun _ ->
        "#ctl00_MainContent_DateStart_I" << "2/1/2017"
        click "#ctl00_MainContent_btnxRetrieve"
        sleep 5
        notContains "No data to display" (read "#ctl00_MainContent_upM > div.row.margin-top-10 > div")
        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."
