module VolunteerData
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open OpenQA.Selenium

let core _ = 
    context "VolunteerData"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let randomString = getRandomString (20)
    let randomNumber = getRandomNumberString (9)
    let firstName = randomString.[0..15]
    let middleName = randomString.[3..4]
    let lastName = randomString.[5..9]
    let suffix = randomString.[6..10]
    let address1 = randomNumber.[0..3] + " " + randomString.[11..17]
    let address2 = randomNumber.[4..7]
    let city = randomString.[15..19]
    let randomState = getRandomState ()
    let zip1 = randomNumber.[4..8]
    let zip4 = randomNumber.[1..4]
    let contactNum = getRandomNumberString (9)
    let randomGender = getRandomGender ()
    let emailID = "AutomationUser_" + firstName + "@callingfromhome.com"
    describe emailID

    "Add Volunteer" &&&& fun _ -> 
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Add Volunteer"
        sleep 10
        describe "on i360 - Volunteer Details page ..."
        displayed "Add Volunteer"

    "Create Volunteer Required Information " &&&& fun _ ->
         "#ddlC_State2" << randomState
         "#ctl00_MainContent_FormView3_ctl02_tbEmail12" << emailID
         describe emailID
         
    "Create Volunteer Full Record" &&&& fun _ ->
         click "Enter Full Record"
         "#ctl00_MainContent_FormView3_ctl04_tbSalutation" << "Mr."
         "#ctl00_MainContent_FormView3_ctl04_tbFirstName" << firstName
         "#ctl00_MainContent_FormView3_ctl04_tbMiddleName" << middleName
         "#ctl00_MainContent_FormView3_ctl04_tbLastName" << lastName
         "#ctl00_MainContent_FormView3_ctl04_tbSuffix" << suffix
         "#ctl00_MainContent_FormView3_ctl04_ddlStatus" << "Active"
         "#ctl00_MainContent_FormView3_ctl04_tbC_AddrLine1" << address1
         "#ctl00_MainContent_FormView3_ctl04_tbC_AddrLine2" << address2
         "#ctl00_MainContent_FormView3_ctl04_tbC_City" << city
         "#ddlC_State" << "VA"
         "#ctl00_MainContent_FormView3_ctl04_tbC_Zip5" << zip1
         "#ctl00_MainContent_FormView3_ctl04_tbC_USPSZip4" << zip4
         "#ctl00_MainContent_FormView3_ctl04_tbC_CountyName" << getRandomString (10)
  //       "#ctl00_MainContent_FormView3_ctl04_tbEmail2" << "mnewm@mpole.com"
         "#ctl00_MainContent_FormView3_ctl04_tbPhone1" << contactNum
         click "#ctl00_MainContent_FormView3_ctl04_MyToggleSwitch1_ToggleSwitchControl"
         "#ctl00_MainContent_FormView3_ctl04_tbPhone2" << randomNumber.[0..4]+randomNumber.[0..5]
    
    "Create Volunteer Additional Recodes" &&&& fun _ ->
          "#ctl00_MainContent_FormView3_ctl04_tbDOB" << "5/16/1991"
          "#ctl00_MainContent_FormView3_ctl04_ddlGender" << randomGender
          "#ctl00_MainContent_FormView3_ctl04_tbFacebookPage" << getRandomString (20)
          "#ctl00_MainContent_FormView3_ctl04_tbTwitterHandle" << lastName
          "#ctl00_MainContent_FormView3_ctl04_tbEmployer" << getRandomString (10)
          "#ctl00_MainContent_FormView3_ctl04_tbOccupation" << getRandomString (10)
          "#ddlCoordinator" << "Dube, Manish "
          click "#divPane1"
          sleep 5
          click "#ctl00_MainContent_FormView3_btnASaveNew_CD > span"
          sleep 10
          click "#ctl00_main_body > div.i-360-simple-alert-bg > div > div:nth-child(3) > div > button.btn-i-360-okay.btn-default.pull-right"
          //contains emailID ( read "#ctl00_MainContent_FormView1_EmailLabel")
          //acceptAlert()

//    "Check created volunteer" &&&& fun _ ->      
//        click "#Menu1 > ul > li:nth-child(3) > a"
//        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
//        describe "on i360 - Volunteers page ..."
//        displayed "Volunteers"
//        //displayed "Select Organization:"
//
//        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I" << firstName
//        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I" << lastName
//        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I" << emailID
//        //click "#ctl00_MainContent_ASPxGridView1_DXCBtn1Img"
//        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
//        sleep 10
//        contains emailID ( read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")

     