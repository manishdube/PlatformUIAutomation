module OrganizationalPortalContent10424
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalPortalContent10424"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Organization Portal Content" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgPortalContent.aspx")
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Portal Content"
        locateWindowWithTitleText "i360 - Organizational Portal Content"
        describe "on i360 - Organizational Portal Content page ..."
        displayed "Organizational Portal Content"
        describe "done ..."

    "Create New Content" &&&& fun _ ->
         click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
         click "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor2_I"
         "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor2_I" << "Survey Legal Text"
         "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor3_I" << "Test1"
         "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor4_I" << "Testing"
         click "Save"
         displayed "Organizational Portal Content"
         click "#ctl00_MainContent_MyExportButtons1_btnXlsxExportImg"
         describe "done ..."