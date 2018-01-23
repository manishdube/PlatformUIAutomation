module VolunteerDetails_18204
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "VolunteerDetails_18204"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let userName = getRandomString (10)
    let firstName = userName.[0..4]
    let lastName = userName.[5..9]
    let emailID = lastName + "@callingfromhome.com"
    let pwd = firstName + "123$"
    let fullName = lastName + ", " + firstName
    let randomState = getRandomState ()
    let cmbxOrg_I = cmbxOrg_I

    "User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."

    "Select Organization" &&&& fun _ ->
        click "#ctl00_MainContent_btnNew"
        acceptAlert()
        click "#cmbxOrg_I"
//        "#cmbxOrg_I" << cmbxOrg_I
        "#cmbxOrg_I" << cmbxOrg_I
        describe "done ..."

    "Create New User" &&&& fun _ ->
        click "#ctl00_MainContent_btnNew"
        "#ctl00_MainContent_frmViewAddUser_tbUserName" << userName
        "#ctl00_MainContent_frmViewAddUser_tbFirstName" << firstName
        "#ctl00_MainContent_frmViewAddUser_tbLastName" << lastName        
        "#ctl00_MainContent_frmViewAddUser_tbEmail" << emailID
        "#ctl00_MainContent_frmViewAddUser_tbPassword" << pwd
        "#ctl00_MainContent_frmViewAddUser_tbConfirmPassword" << pwd
        "#ctl00_MainContent_frmViewAddUser_tbPasswordQuestion" << "Last Name"
        "#ctl00_MainContent_frmViewAddUser_tbPasswordAnswer" << lastName
        click "#ddlC_State"
        "#ddlC_State" << randomState
        click "#ctl00_MainContent_frmViewAddUser_btnASave_CD"
        describe "done ..."

    "Confirms User Creation" &&&& fun _ ->
        //click "#cmbxOrg_I"
        //"#cmbxOrg_I" << cmbxOrg_I
        //press enter
        //reload()
        //sleep 10
        //"#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << userName         
        //press enter
        //sleep 4
        contains userName (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "done ..."

    "Grassroots Volunteers" &&&& fun _ -> 
        //click "#ctl00_MainContent_btnNew"
        click "Clear"
        click "#Menu1 > ul > li:nth-child(3) > a"
//        click "#Menu1\3a submenu\3a 24 > li:nth-child(2) > a"        
        click "#Menu1 > ul > li:nth-child(3) > a"
        sleep 5
        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
 //       locateWindowWithTitleText "i360 - Volunteers"
        describe "on i360 - Volunteers page ..."      
        click "Clear"  
        displayed "Volunteers"
        describe "done ..."

    "searches user Volunteer then doubleClick grid item to Volunteer Details page" &&&& fun _ ->
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I" << firstName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I" << lastName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I" << emailID
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol30_I" << randomState
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        sleep 10
        contains emailID (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        contains firstName (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        let LogID = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(6)"
        let changedPwd = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td.passwdField.dxgv"
        describe LogID
        describe changedPwd

        describe "doubleClick grid item to Volunteer Details page"

        doubleClick "#ctl00_MainContent_ASPxGridView1_DXDataRow0"
        sleep 10
        containsInsensitive firstName (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive lastName (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive emailID (read "#ctl00_MainContent_FormView1_EmailLabel")
        containsInsensitive randomState (read "#ctl00_MainContent_FormView1_C_StateLabel")
        containsInsensitive firstName (read "#ddlCoordinator")
        containsInsensitive lastName (read "#ddlCoordinator")
        containsInsensitive changedPwd (read "#tbPassword")
        describe "done ..."
                
        describe "change password and assert the changed password"
        "#tbPassword" << "changed"
        click "#ctl00_MainContent_FormView1_btnSaveCred"
        containsInsensitive "Volunteer Credentials Updated" (read "#ctl00_main_body > div > div > div:nth-child(2) > div > div")
        //click "#ctl00_main_body > div > div > div:nth-child(3) > div > button.btn-i-360-okay.btn-default.pull-right)"
        click ".btn-i-360-okay"
        containsInsensitive "changed" (read "#tbPassword")
//        sleep 5
        describe "done ..."

    "change Available permissions on Volunteer Details page" &&&& fun _ ->
    //    let mutable availablePermissions = (elements "#ctl00_MainContent_lbVolPermsAvailable_LBT").Length
    //    let mutable availablePermissions = (element "#ctl00_MainContent_lbVolPermsAvailable_D").Text
        //while (((element "#ctl00_MainContent_lbVolPermsAvailable_D").Text) <> "No data to display") do
    //    while (((element "#ctl00_MainContent_lbVolPermsAvailable_D").Text) <> "") do
    //    while (availablePermissions > 0) do
        for i = 0 to 5 do
        
            let selectedAvailableRowText = (element "#ctl00_MainContent_lbVolPermsAvailable_LBI0T1").Text

            click "#ctl00_MainContent_lbVolPermsAvailable_LBI0T1"
            click "#ctl00_MainContent_btnMoveSelectedItemsToRightImg"
            sleep 3
        //    contains selectedAvailableRowText (read "#ctl00_MainContent_lbVolPerms_D")



    //            click "User Assignments - By Tableau Report"
    //            "#ctl00_MainContent_pc_ddlTabRpts" << read selectedAvailableTagRptText
    //            sleep 2
    //            "#ctl00_MainContent_pc_gvxAssigned_DXFREditorcol2_I" << user
    //            press enter
    //            sleep 5
    //            contains user (read "#ctl00_MainContent_pc_gvxAssigned > tbody > tr > td > div.dxgvCSD")
    //            notContains user (read "#ctl00_MainContent_pc_gvxUsers > tbody > tr > td > div.dxgvCSD")
    //            click "User Assignments - By User"

        describe "done ..."    


    "change Chosen permissions on Volunteer Details page" &&&& fun _ ->
    //    let mutable availablePermissions = (elements "#ctl00_MainContent_lbVolPermsAvailable_LBT").Length
    //    let mutable availablePermissions = (element "#ctl00_MainContent_lbVolPermsAvailable_D").Text
        //while (((element "#ctl00_MainContent_lbVolPermsAvailable_D").Text) <> "No data to display") do
    //    while (((element "#ctl00_MainContent_lbVolPermsAvailable_D").Text) <> "") do
    //    while (availablePermissions > 0) do
        for i = 0 to 5 do
        
            let selectedChosenRowText = (element "#ctl00_MainContent_lbVolPerms_LBI0T1").Text

         //   click "#ctl00_MainContent_lbVolPerms_LBI0T1"
            click "#ctl00_MainContent_btnMoveSelectedItemsToLeftImg"
            sleep 3
         //   contains selectedChosenRowText (read "#ctl00_MainContent_lbVolPermsAvailable_D")



    //            click "User Assignments - By Tableau Report"
    //            "#ctl00_MainContent_pc_ddlTabRpts" << read selectedAvailableTagRptText
    //            sleep 2
    //            "#ctl00_MainContent_pc_gvxAssigned_DXFREditorcol2_I" << user
    //            press enter
    //            sleep 5
    //            contains user (read "#ctl00_MainContent_pc_gvxAssigned > tbody > tr > td > div.dxgvCSD")
    //            notContains user (read "#ctl00_MainContent_pc_gvxUsers > tbody > tr > td > div.dxgvCSD")
    //            click "User Assignments - By User"

        describe "done ..."    

    "assign Tags on Volunteer Details page" &&&& fun _ -> 
        click "#ctl00_MainContent_btnAddTagY"
        click "#ctl00_MainContent_ddlCats"
        press down
        press down
        let mutable ctl00_MainContent_ddlCats = (element "#ctl00_MainContent_ddlCats > option:nth-child(2)").Text
        press enter
        click "#ctl00_MainContent_ddlTags"
        press down
        press down
        let mutable ctl00_MainContent_ddlTags = (element "#ctl00_MainContent_ddlTags > option:nth-child(2)").Text
        press enter
        "#ctl00_MainContent_tbNotes" << "Testing Notes"
        click "#ctl00_MainContent_btnNewTag"
        sleep 3
  //      containsInsensitive ctl00_MainContent_ddlTags (read "#ctl00_MainContent_aspxTags_tccell1_4")

        click "#ctl00_MainContent_aspxTags_DXCBtn0Img"
//        containsInsensitive ctl00_MainContent_ddlCats (read "#ctl00_MainContent_aspxTags_DXPEForm_DXEFL_0 > table > tbody")
//        containsInsensitive ctl00_MainContent_ddlTags (read "#ctl00_MainContent_aspxTags_DXPEForm_DXEFL_1 > table > tbody")
        click "#ctl00_MainContent_aspxTags_DXPEForm_HCB-1 > img"

        click "#ctl00_MainContent_aspxTags_DXCBtn1Img"
        acceptAlert()
        containsInsensitive "No tags for this volunteer" (read "#ctl00_MainContent_aspxTags_DXEmptyRow > td:nth-child(2)")
        
        describe "done ..."
 