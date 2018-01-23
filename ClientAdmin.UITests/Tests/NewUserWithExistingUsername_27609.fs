module NewUserWithExistingUsername_27609
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "NewUserWithExistingUsername_27609"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let userName = getRandomString (10)
    let firstName = userName.[0..4]
    let lastName = userName.[5..9]
    let emailID = lastName + "@callingfromhome.com"
    let pwd = firstName + "123$"
    let randomState = getRandomState ()
    let fullName = lastName + ", " + firstName
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

    "Add a User - Existing Username" &&&& fun _ ->
//        click "#ctl00_ctl16_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        click "#ctl00_MainContent_btnNew"
        acceptAlert()
        click "#cmbxOrg_I"
        //27607: Add a User - Existing Username
        "#cmbxOrg_I" << cmbxOrg_I
        click "#ctl00_MainContent_btnNew"        
        "#ctl00_MainContent_frmViewAddUser_tbUserName" << userName        
        "#ctl00_MainContent_frmViewAddUser_tbEmail" << "testing@callingfromhome.com"
        "#ctl00_MainContent_frmViewAddUser_tbPassword" << "PTest123$"
        "#ctl00_MainContent_frmViewAddUser_tbConfirmPassword" << "PTest123$"
        "#ctl00_MainContent_frmViewAddUser_tbPasswordQuestion" << "fav food"
        "#ctl00_MainContent_frmViewAddUser_tbPasswordAnswer" << "mdsnb"
        //27608 Add a User - Part2
        click "#ddlC_State"
        "#ctl00_MainContent_frmViewAddUser_tbFirstName" << "Test123"
        "#ctl00_MainContent_frmViewAddUser_tbLastName" << "Test"
        check "#ctl00_MainContent_frmViewAddUser_cbxIsActive"
        check "#ctl00_MainContent_frmViewAddUser_cbxIsActive"
        "#ddlC_State" << "VA"
        click "#ctl00_MainContent_frmViewAddUser_btnASave"
        contains "This user already exists; a duplicate record cannot be created." (read "#ctl00_MainContent_lblMsg2")
        describe "done ..."

    "Checking UserAdmin" &&&& fun _ ->
//        click "#ctl00_ctl16_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << cmbxOrg_I
        (*
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << userName  
        "#ctl00_MainContent_gvUsers_DXFREditorcol4_I" << firstName
        press enter
        contains userName (read "#ctl00_MainContent_gvUsers")

        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << userName 
        "#ctl00_MainContent_gvUsers_DXFREditorcol4_I" << "Test123"
        press enter
        notContains userName (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        *)

        describe "done ..."