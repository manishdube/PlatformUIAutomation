module CancelNewUserCreation18281
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "CancelNewUserCreation18281"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let randomString = getRandomString (20)
    let firstName = randomString.[0..19]
    let lastName = randomString.[5..9]
    let emailID = "AutomationUser_" + firstName + "@callingfromhome.com"
    let pwd = firstName + "123$"
    let fullName = lastName + ", " + firstName
    let randomState = getRandomState ()
    let cmbxOrg_I = cmbxOrg_I
        
    "User Admin" &&&& fun _ ->
        try
        //    click "#ctl15_imgMasterHdrLogo"
            click "#Menu2 > ul > li:nth-child(2) > a"
        with
        | _ ->
            reporter.write "Admin click failed ...but wait ... trying again"
            sleep 2
            click "#Menu2 > ul > li:nth-child(2) > a"
//        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."

    "Create User" &&&& fun _ ->
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
        "#ctl00_MainContent_frmViewAddUser_tbPasswordQuestion" << "fav food"
        "#ctl00_MainContent_frmViewAddUser_tbPasswordAnswer" << "mdsn"
        click "#ddlC_State"
        "#ddlC_State" << randomState
        click "#ctl00_MainContent_frmViewAddUser_btnCancel_CD"
        displayed "Select Organization:"
        describe "done ..."