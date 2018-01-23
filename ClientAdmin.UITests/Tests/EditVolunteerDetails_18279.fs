module EditVolunteerDetails_18279
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "EditVolunteerDetails_18279"
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

    let userName2 = getRandomString (10)
    let firstName2 = userName2.[0..4]
    let lastName2 = userName2.[5..9]
    let emailID2 = lastName2 + "@callingfromhome.com"
    let pwd2 = firstName2 + "123$"
    let fullName2 = lastName2 + ", " + firstName2
    let randomState2 = getRandomState ()
    
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
        contains userName1 (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "done ..."

    "Grassroots Volunteers" &&&& fun _ -> 
        //click "#ctl00_MainContent_btnNew"        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
        locateWindowWithTitleText "i360 - Volunteers"
        describe "on i360 - Volunteers page ..."
        displayed "Volunteers"
        describe "done ..."

    "searches user Volunteer then doubleClick grid item to Volunteer Details page" &&&& fun _ ->
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I" << firstName1
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I" << lastName1
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I" << emailID1
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol30_I" << randomState1
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        sleep 35
        contains emailID1 (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        contains firstName1 (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        let LogID = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(6)"
        let iVolPwd = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td.passwdField.dxgv"
        describe LogID
        describe iVolPwd

        describe "doubleClick grid item to Volunteer Details page"

        doubleClick "#ctl00_MainContent_ASPxGridView1_DXDataRow0"
        sleep 5
        containsInsensitive firstName1 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive lastName1 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive emailID1 (read "#ctl00_MainContent_FormView1_EmailLabel")
        containsInsensitive randomState1 (read "#ctl00_MainContent_FormView1_C_StateLabel")
        containsInsensitive firstName1 (read "#ddlCoordinator")
        containsInsensitive lastName1 (read "#ddlCoordinator")
        containsInsensitive iVolPwd (read "#tbPassword")
//        containsInsensitive LogID (read "#tbLogID")

//    "click to go to Edit Volunteer Details page, confirm and change" &&&& fun _ ->
        click "#ctl00_MainContent_btnxEditVol"

        containsInsensitive firstName1 (read "#ctl00_MainContent_FormView2_tbFirstName")
        containsInsensitive lastName1 (read "#ctl00_MainContent_FormView2_tbLastName")
        containsInsensitive emailID1 (read "#ctl00_MainContent_FormView2_tbEmail1")
        containsInsensitive randomState1 (read "#ddlC_StateE")
//        containsInsensitive firstName1 (read "#ddlCoordinator")
//        containsInsensitive lastName1 (read "#ddlCoordinator")

        "#ctl00_MainContent_FormView2_tbFirstName" << firstName2
        "#ctl00_MainContent_FormView2_tbLastName" << lastName2
        "#ctl00_MainContent_FormView2_tbEmail1" << emailID2
        "#ddlC_StateE" << randomState2
        "#ctl00_MainContent_FormView2_tbC_Zip5" << "22201"
        "#ctl00_MainContent_FormView2_tbC_CountyName" << "Arlington"
        click "#ctl00_MainContent_btnESaveProxy"
        click "#ctl00_main_body > div.i-360-simple-alert-bg > div > div:nth-child(3) > div > button.btn-i-360-okay.btn-default.pull-right"
        describe "done ..."

//    "assert new values on the Volunteer Details page" &&&& fun _ ->
        containsInsensitive firstName2 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive lastName2 (read "#ctl00_MainContent_FormView1_lblFullName")
        containsInsensitive emailID2 (read "#ctl00_MainContent_FormView1_EmailLabel")
        containsInsensitive randomState2 (read "#ctl00_MainContent_FormView1_C_StateLabel")
        containsInsensitive firstName1 (read "#ddlCoordinator")
        containsInsensitive lastName1 (read "#ddlCoordinator")
        containsInsensitive emailID1 (read "#ctl00_MainContent_FormView1_Email2Label")
        containsInsensitive iVolPwd (read "#tbPassword")
        describe "done ..."