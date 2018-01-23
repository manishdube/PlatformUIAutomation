module CreateANewUser_18262
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "CreateANewUser_18262"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let randomString = getRandomString (20)
    let firstName = randomString.[7..15]
    let lastName = randomString.[5..9]
    let emailID = "AutomationUser_" + firstName + "@callingfromhome.com"
    let pwd = firstName + "123$"
    let fullName = lastName + ", " + firstName
    let randomState = getRandomState ()
    let PasswordQuestion = randomString.[7..11] + " " + randomString.[0..5]
    let cmbxOrg_I = cmbxOrg_I


    "User Admin" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/UserVer2/UserAdmin.aspx")
        //click i360HomeLogo
        click "Admin"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."

    "Create and Save a New User" &&&& fun _ ->
        click "#ctl00_MainContent_btnNew"
        acceptAlert()
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << cmbxOrg_I
        click "#ctl00_MainContent_btnNew"
        "#ctl00_MainContent_frmViewAddUser_tbUserName" << firstName
        "#ctl00_MainContent_frmViewAddUser_tbFirstName" << randomString
        "#ctl00_MainContent_frmViewAddUser_tbLastName" << lastName
        "#ctl00_MainContent_frmViewAddUser_tbEmail" << emailID
        "#ctl00_MainContent_frmViewAddUser_tbPassword" << pwd
        "#ctl00_MainContent_frmViewAddUser_tbConfirmPassword" << pwd
        "#ctl00_MainContent_frmViewAddUser_tbPasswordQuestion" << PasswordQuestion
        "#ctl00_MainContent_frmViewAddUser_tbPasswordAnswer" << "mdsn"
        click "#ddlC_State"
        "#ddlC_State" << randomState
        click "#ctl00_MainContent_frmViewAddUser_btnASave_CD > span"
        displayed "User Admin"
        contains firstName (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        contains randomString (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        contains lastName (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        contains emailID (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        contains randomState (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "done ..."

    "Check the newly created User details in the Edit User Details page" &&&& fun _ ->
        doubleClick "#ctl00_MainContent_gvUsers_DXDataRow0"
        displayed "User Details"
        contains (randomString + " " + lastName) (read "#ctl00_MainContent_FormView1_lblFullName")
        contains firstName (read "#ctl00_MainContent_FormView1_lblUserName")
        contains emailID (read "#ctl00_MainContent_FormView1_Label2")
        click "#ctl00_MainContent_btnxUser_CD > span"
        describe "done ..."

        contains "Edit User Details" (read "#pageTitle") 
        contains firstName (read "#ctl00_MainContent_FormView2_tbUserName") 
        contains randomString (read "#ctl00_MainContent_FormView2_tbFirstName")
        contains lastName (read "#ctl00_MainContent_FormView2_tbLastName")
        contains emailID (read "#ctl00_MainContent_FormView2_tbEmail")
        contains PasswordQuestion (read "#ctl00_MainContent_FormView2_tbPasswordQuestion")
        contains randomState (read "#ddlC_State")
        click "#ctl00_MainContent_btnEClose_CD > span"
        describe "done ..."
