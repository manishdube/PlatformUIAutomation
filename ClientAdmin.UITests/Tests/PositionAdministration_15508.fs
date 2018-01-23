module PositionAdministration_15508
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "PositionAdministration_15508"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    let userName1 = getRandomString (10)
    let firstName1 = userName1.[0..4]
    let lastName1 = userName1.[5..9]
    let emailID1 = lastName1 + "@callingfromhome.com"
    let pwd1 = firstName1 + "123$"
    let fullName1 = lastName1 + ", " + firstName1
    let randomState1 = getRandomState ()
    let phone1 = getRandomString (10)
    let phone2 = getRandomString (10)
    let phone3 = getRandomString (10)
//    let newrole = "AutomationScript"
    let newrole = "Field Manager"

    let cmbxOrg_I = cmbxOrg_I

    "Navigate to Position Roles" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Position Roles"
        locateWindowWithTitleText "i360 - Position Roles"
        describe "on i360 - Position Roles page ..."
        displayed "Position Roles"
        describe "done ..."

    "Create New Position" &&&& fun _ ->
        click "#ctl00_MainContent_btnShowCreateRoleGroupModal"
        displayed "New Position"
        "#ctl00_MainContent_txtNewRoleGroupName" << newrole
        "#ctl00_MainContent_ddlNewRoleGroupSupervisor" << "Field Staff"
        click "#ctl00_MainContent_btnCreateRoleGroup"
        describe "done ..."

    "Select the new Position and available roles " &&&& fun _ ->
        "#ctl00_MainContent_ddlRoleGroups" << newrole
        click "#ctl00_MainContent_lbxRolesUnassigned_LBI0T1"
        click "#ctl00_MainContent_btnAssignRole_CD"
        click "#ctl00_MainContent_lbxRolesUnassigned_LBI0T1"
        click "#ctl00_MainContent_btnAssignRole_CD"
        describe "done ..."    

    "Navigate to User Admin" &&&& fun _ ->
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
        "#cmbxOrg_I" << cmbxOrg_I
        describe "done ..."

    "Create New User" &&&& fun _ ->
        click "#ctl00_MainContent_btnNew"
        "#ctl00_MainContent_frmViewAddUser_tbUserName" << userName1
        "#ctl00_MainContent_frmViewAddUser_tbFirstName" << firstName1
        "#ctl00_MainContent_frmViewAddUser_tbLastName" << lastName1        
        "#ctl00_MainContent_frmViewAddUser_tbEmail" << emailID1
        "#ctl00_MainContent_frmViewAddUser_tbPassword" << pwd1
        "#ctl00_MainContent_frmViewAddUser_tbConfirmPassword" << pwd1
        "#ctl00_MainContent_frmViewAddUser_tbPasswordQuestion" << "Last Name"
        "#ctl00_MainContent_frmViewAddUser_tbPasswordAnswer" << lastName1
        click "#ddlC_State"
        "#ddlC_State" << randomState1
        "#ctl00_MainContent_frmViewAddUser_ddlPosition_I" << "Field Staff"
        click "#ctl00_MainContent_frmViewAddUser_btnASave_CD"
        describe "done ..."

    "Confirms User Creation" &&&& fun _ ->
        contains userName1 (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "done ..."

    "Change Position" &&&& fun _ ->
        doubleClick "#ctl00_MainContent_gvUsers_DXDataRow0" 
        containsInsensitive firstName1 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive lastName1 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive emailID1 (read "#ctl00_MainContent_FormView1_Label2")
        containsInsensitive randomState1 (read "#ctl00_MainContent_FormView1_Label23")
        containsInsensitive firstName1 (read "#ctl00_MainContent_FormView1_lblUserName")
        containsInsensitive lastName1 (read "#ctl00_MainContent_FormView1_lblUserName")
        click "#cbxDelRoles"
        "#ddlRoleGroup" << newrole
        acceptAlert()
        containsInsensitive "Access Navigation Bar" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
//        containsInsensitive "Accounts: Account Rep" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
//        notContains "Accounts: iVolunteers Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
//        notContains "Admin: Client Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
        sleep 10
        click "#ctl00_MainContent_btnxUser"
        sleep 10
        click "#ctl00_MainContent_FormView2_tbSearchMaxRows"
        press tab
        press up
        press enter
        "#ctl00_MainContent_FormView2_ddlPosition_I" << newrole
        click "#ctl00_MainContent_btnSave"
        sleep 5
        contains "Access Navigation Bar" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
        contains "Accounts: Account Rep" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
 //       notContains "Accounts: iVolunteers Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
 //       notContains "Admin: Client Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")  

        "#ddlRoleGroup" << "Field Staff"
        acceptAlert()   
        contains "Access Navigation Bar" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
        contains "Accounts: Account Rep" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
        contains "Accounts: iVolunteers Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")
        contains "Admin: Client Admin" (read "#ctl00_MainContent_upRoles > div.row.margin-top-10 > div:nth-child(3)")     

    "Add Roles to None" &&&& fun _ ->
        click "#ctl00_MainContent_lbUnAssignedRoles > option:nth-child(1)"
        let selectedRolesText = (element "#ctl00_MainContent_lbUnAssignedRoles > option:nth-child(1)").Text
        click "#ctl00_MainContent_btnAssignRoles"       
        contains selectedRolesText (read "#ctl00_MainContent_upRoles")
        describe "done ..."       
                 
    "Positoin Roles test data cleanup" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        locateWindowWithTitleText "i360 - Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"
        "#ctl00_MainContent_ddlRefOrgType" << "Role Groups"
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newrole
        press enter
        sleep 3
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn2 > span > span"
        acceptAlert()
        describe "done ..."        
