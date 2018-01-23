module OrganizationalTouchpoints10598
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalTouchpoints10598"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let touchpoints = "Donation-Email Cnt: 0"
    let cmbxOrg_I = cmbxOrg_I

    "Organization Touchpoints" &&&& fun _ ->
        try
            click "#Menu2 > ul > li:nth-child(2) > a"
        with
        | _ ->
            reporter.write "Admin click failed ...but wait ... trying again"
            click "#Menu2 > ul > li:nth-child(2) > a"
       
//    "Clear out Organization Touchpoints grid" &&&& fun _ ->
//        click "Organization Touchpoints"
//        let mutable gettxtValue = (element "#ctl00_MainContent_gvx_DXMainTable").Text
//        notContains "No data to display" (read gettxtValue)
//        while (((element "#ctl00_MainContent_gvx_DXMainTable").Text) <> "No data to display") do
//        while (containsInsensitive "No data to display" (read gettxtValue)) do
//
//          click "#ctl00_MainContent_gvx_DXCBtn1 > span > span"
//          acceptAlert()
//        describe "done with clearing out Organization Touchpoints grid ..." 
    
    "click new and fill form and save" &&&& fun _ ->
        click "Organization Touchpoints"
        click "#ctl00_MainContent_ddlOrg"
        "#ctl00_MainContent_ddlOrg" << "i360"
        click "#ctl00_MainContent_btnRetrieve"
        click "#ctl00_MainContent_gvx_header0_btnNew"
        click "#ctl00_MainContent_gvx_DXPEForm_DXEFL_DXEditor2_I"
        "#ctl00_MainContent_gvx_DXPEForm_DXEFL_DXEditor2_I" << touchpoints
        click "Save"
        describe "done ..."

    "assert newly added grid item" &&&& fun _ ->
        sleep 5
//        contains touchpoints (read "#ctl00_MainContent_gvx_DXMainTable > tbody > tr.dxgvArm")
        describe "done ..."

    "download the 5 reports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport_CD"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport_CD"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"

//Nice to have 1 : Be able to assert files downloaded correctly
//Nice to have 2 : Be able to delete the downloaded files
(*
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.pdf")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.xlsx")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.xls")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.rtf")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.csv")

  *)

        click "#ctl00_MainContent_gvx_DXCBtn1 > span > span"
        acceptAlert()     
        describe "done ..."     
