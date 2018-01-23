module OrganizationLookupData_995
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationLookupData_995"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Organization Lookup Data" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"

    "filter data and delete" &&&& fun _ ->
        "#ctl00_MainContent_ddlRefOrgType" << "Role Groups"

        // Unable to add a new Role Group by clicking the New button.
//        click "#ctl00_MainContent_ASPxGridView1_header0_btnNew"
//        "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor3_I" << "TestAutomation"
//        "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor4_I" << "TestAutomation"
//        click "#ctl00_MainContent_ASPxGridView1_DXEFL_DXCBtn21 > span > button"
//        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << "TestAutomation"
//        press enter
//        contains "TestAutomation" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0")

        //let gridText = (element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(5)").Text
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << (element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(5)").Text
        press enter
        contains (element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(5)").Text (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0")
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn2 > span > span"
        acceptAlert()
        describe "done ..."