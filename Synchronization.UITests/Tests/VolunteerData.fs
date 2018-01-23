module VolunteerData
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "VolunteerData"
//    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let randomString = getRandomString (20)
    let firstName = randomString.[0..19]
    let lastName = randomString.[5..9]
    let emailID = "AutomationUser_" + firstName + "@callingfromhome.com"
    
    "Add Volunteer" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/V3.aspx") 
        click "#ctl15_imgMasterHdrLogo"        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Add Volunteer"
        locateWindowWithTitleText "i360 - Volunteer Details"
        describe "on i360 - Volunteer Details page ..."
        displayed "Add Volunteer"

    "Create Volunteer Required Information " &&&& fun _ ->
         "#ddlC_State2" << "VA"
         "#ctl00_MainContent_FormView3_ctl02_tbEmail12" << emailID
         
    "Create Volunteer Full Record" &&&& fun _ ->
         click "Enter Full Record"
         "#ctl00_MainContent_FormView3_ctl04_tbSalutation" << "Mr."
         "#ctl00_MainContent_FormView3_ctl04_tbFirstName" << firstName
         "#ctl00_MainContent_FormView3_ctl04_tbMiddleName" << "L"
         "#ctl00_MainContent_FormView3_ctl04_tbLastName" << lastName
         "#ctl00_MainContent_FormView3_ctl04_tbSuffix" << "ffdds"
         "#ctl00_MainContent_FormView3_ctl04_ddlStatus" << "Active"
         "#ctl00_MainContent_FormView3_ctl04_tbC_AddrLine1" << "1345 Yejj Rd."
         "#ctl00_MainContent_FormView3_ctl04_tbC_AddrLine2" << "Apt 34"
         "#ctl00_MainContent_FormView3_ctl04_tbC_City" << "Arlington"
         "#ddlC_State" << "VA"
         "#ctl00_MainContent_FormView3_ctl04_tbC_Zip5" << "23001"
         "#ctl00_MainContent_FormView3_ctl04_tbC_USPSZip4" << "4567"
         "#ctl00_MainContent_FormView3_ctl04_tbC_CountyName" << "collin"
         "#ctl00_MainContent_FormView3_ctl04_tbEmail2" << "mnewm@mpole.com"
         "#ctl00_MainContent_FormView3_ctl04_tbPhone1" << "234457891"
         click "#ctl00_MainContent_FormView3_ctl04_MyToggleSwitch1_ToggleSwitchControl"
         //"#ctl00_MainContent_FormView3_ctl04_MyToggleSwitch1_ToggleSwitchControl" << "On"
         "#ctl00_MainContent_FormView3_ctl04_tbPhone2" << "7438798753"
    
    "Create Volunteer Additional Recodes" &&&& fun _ ->
          "#ctl00_MainContent_FormView3_ctl04_tbDOB" << "5/16/1991"
          "#ctl00_MainContent_FormView3_ctl04_ddlGender" << "Male"
          "#ctl00_MainContent_FormView3_ctl04_tbFacebookPage" << "http:nsndn//ndn"
          "#ctl00_MainContent_FormView3_ctl04_tbTwitterHandle" << "KamJohn"
          "#ctl00_MainContent_FormView3_ctl04_tbEmployer" << "i-360"
          "#ctl00_MainContent_FormView3_ctl04_tbOccupation" << "Doctor"
          "#ddlCoordinator" << "Dube, Manish "
          click "#ctl00_MainContent_FormView3_btnASave_CD"
          click "#ctl00_main_body > div.i-360-simple-alert-bg > div > div:nth-child(3) > div > button.btn-i-360-okay.btn-default.pull-right"
          contains emailID ( read "#ctl00_MainContent_FormView1_EmailLabel")
          //acceptAlert()

    "Check created volunteer" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/Volunteers.aspx") 
        //click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
        locateWindowWithTitleText "i360 - Volunteers"
        describe "on i360 - Volunteers page ..."
        displayed "Volunteers"
        //displayed "Select Organization:"

        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I" << firstName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I" << lastName
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I" << emailID
        //click "#ctl00_MainContent_ASPxGridView1_DXCBtn1Img"
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        sleep 8
        contains emailID ( read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
