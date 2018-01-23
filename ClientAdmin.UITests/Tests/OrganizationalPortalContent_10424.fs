module OrganizationalPortalContent_10424
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalPortalContent_10424"
    elementTimeout <- 30.0
    let user = "Dube, Manish"
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let randomString = getRandomString (20)
    let Type = "Survey Legal Text"
    let Title = randomString.[7..15]
    let PortalContent = "AutomationUser_" + randomString
    let cmbxOrg_I = cmbxOrg_I

    "Navigate to Organization Portal Content" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgPortalContent.aspx")
//        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Portal Content"
        locateWindowWithTitleText "i360 - Organizational Portal Content"
        describe "on i360 - Organizational Portal Content page ..."
        displayed "Organizational Portal Content"
        describe "done ..."
   
//    "Clear out Organization Portal Content grid" &&&& fun _ ->
//        let mutable gettxtValue = (element "#ctl00_MainContent_ASPxGridView1_DXEmptyRow > td.dxgv").Text
//        while (((element "#ctl00_MainContent_ASPxGridView1_DXEmptyRow > td.dxgv").Text) <> "No data to display") do
//          click "#ctl00_MainContent_ASPxGridView1_DXCBtn3 > span > span"
//          acceptAlert()
//        describe "done ..."   

    "click new and fill form and save" &&&& fun _ ->
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0 > span > button"
        click "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor2_I"
        click Type
        "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor3_I" << Title
        "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor4_I" << PortalContent
        //click "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXCBtn2 > span > button"
        click "Save"
        describe "done ..."

    "assert newly added grid item" &&&& fun _ ->
        contains Type (read "#aspnetForm > div.container.body-content > div > div.row.margin-top-10 > div")
        contains Title (read "#aspnetForm > div.container.body-content > div > div.row.margin-top-10 > div")
        contains PortalContent (read "#aspnetForm > div.container.body-content > div > div.row.margin-top-10 > div")
        describe "done ..."

    "assert newly added grid item in the Edit Form screen" &&&& fun _ ->
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn2 > span > span"
        contains Type (read "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor2_I")
        contains Title (read "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor3_I")
        contains PortalContent (read "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor4_I")
        click "#ctl00_MainContent_ASPxGridView1_DXPEForm_DXEFL_DXCBtn3 > span > button"
        describe "done ..."

    "delete the newly added grid item" &&&& fun _ ->
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn3 > span > span"
        acceptAlert()
        describe "done ..."
        