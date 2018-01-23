module CreateANewVolunteer_18415
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open OpenQA.Selenium

let core _ = 
    context "CreateANewVolunteer_18415"
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
 //       click "#ctl15_imgMasterHdrLogo"
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
  //      "#cmbxOrg_I" << "Alicias minions1"
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
        sleep 10
        contains userName (read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "done ..."

    "Grassroots Volunteers Page" &&&& fun _ -> 
        //click "#ctl00_MainContent_btnNew"        
        click "#Menu1 > ul > li:nth-child(3) > a"
        url (portalUrl + "Grassroots/Volunteers/Volunteers.aspx")
        //click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
        //click "Volunteers"

        click "Clear"
        sleep 10
        describe "on i360 - Volunteers page ..."
        displayed "Volunteers"
        describe "done ..."

    "New User Creates a new Volunteer" &&&& fun _ ->
        click "#cmbxOrg_B-1"
        let dd_cmbxOrg_I = elementWithText ".dxeListBoxItemRow" cmbxOrg_I
        click dd_cmbxOrg_I 
        sleep 5
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I" << firstName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I" << lastName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I" << emailID
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol30_I" << randomState
        press enter
        sleep 30
        contains emailID (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(8)")
        containsInsensitive firstName (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(3)")
        describe "done ..."