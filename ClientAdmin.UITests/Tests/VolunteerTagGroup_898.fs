module VolunteerTagGroup_898
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "VolunteerTagGroup_898"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Volunteer Tag Groups" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/CRM/TagGroupAdmin.aspx")
//        click "#ctl15_imgMasterHdrLogo"
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
//        click "#Menu2\3a submenu\3a 89 > li:nth-child(3) > a"
        click "Volunteer Tag Groups"
        displayed "Volunteer Tag Groups"
        describe "on i360 - Volunteer  Tag Groups page ..."

    "Create New Tag Group" &&&& fun _ ->
        click "#ctl00_MainContent_btnNewGroup"
        displayed "Create New Tag Group"
        "#ctl00_MainContent_tbNewGroup" << "AutomatedTest"
        click "#ctl00_MainContent_btnCreateNewGroup"
        describe "done ..."

    "Add/Remove Tags to Group" &&&& fun _ ->
        click "#ctl00_MainContent_ddlGroups"
        displayed "No data to display"
        "#ctl00_MainContent_ddlGroups" << read "AutomatedTest"

        let mutable tagsAvailableRows = elements "#ctl00_MainContent_gvMaster_DXMainTable > tbody > tr" 
        //let mutable NoDataText_gvMaster = (element "#ctl00_MainContent_gvMaster > tbody > tr > td > div.dxgvCSD").Text
        let mutable NoDataText_gvCart = (element "#ctl00_MainContent_gvCart > tbody > tr > td > div.dxgvCSD").Text
        
        //while (((element "#ctl00_MainContent_gvMaster > tbody > tr > td > div.dxgvCSD").Text) <> "No data to display") do
        let selectedAvailableTagElementText = (element "#ctl00_MainContent_gvMaster_DXDataRow0 > td:nth-child(2)").Text
        click selectedAvailableTagElementText
        click "#ctl00_MainContent_imgbtnAdd"
        contains selectedAvailableTagElementText (read "#ctl00_MainContent_gvCart > tbody > tr > td > div.dxgvCSD")

        //while (((element "#ctl00_MainContent_gvCart > tbody > tr > td > div.dxgvCSD").Text) <> "No data to display") do
        click "#ctl00_MainContent_gvCart_DXDataRow0"  
        let selectedTagsInGroupTagElementText = (element "#ctl00_MainContent_gvCart_DXDataRow0 > td:nth-child(2)").Text
        click "#ctl00_MainContent_imgbtnSub"       
        contains selectedTagsInGroupTagElementText (read "#ctl00_MainContent_gvMaster > tbody > tr > td > div.dxgvCSD")                  
        describe "done with the moving of tags test cases ... "
     
    "Delete the Tag Group" &&&& fun _ ->
//        url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
//        click "#ctl00_ctl16_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        locateWindowWithTitleText "i360 - Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"
        click "#ctl00_MainContent_ddlRefOrgType"
        "#ctl00_MainContent_ddlRefOrgType" << "Volunteer Tag Group"
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << "AutomatedTest"
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn2"
        acceptAlert()
        describe "done ..."
