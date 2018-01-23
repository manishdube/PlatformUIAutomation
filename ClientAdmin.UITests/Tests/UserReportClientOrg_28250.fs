module UserReportClientOrg_28250
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open System.IO
open OpenQA.Selenium

let core _ = 
    context "UserReportClientOrg_28250"
    compareTimeout <- 30.0
    let user = "Dube, Manish"
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let userName = getRandomString (15)
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
    
    "Select Organization" &&&& fun _ ->
        click "#ctl00_MainContent_btnNew"
        acceptAlert()
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << cmbxOrg_I

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
        reload()
    
    "Users Report" &&&& fun _ ->
//        click "#ctl00_ctl16_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Users Report"
        describe "on i360 -  page ..."
        displayed "Client Organization"
        displayed "Drag a column header here to group by that column"
        "#cmbxOrg_I" << cmbxOrg_I
        press enter
        sleep 60
        "#ctl00_MainContent_gvx_DXFREditorcol2_I" << userName
        "#ctl00_MainContent_gvx_DXFREditorcol3_I" << firstName
        press enter
        sleep 30
        contains userName (read "#ctl00_MainContent_gvx > tbody > tr > td > div.dxgvCSD")
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport_CD"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExportImg"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExportImg"

//Nice to have 1 : Be able to assert files downloaded correctly
//Nice to have 2 : Be able to delete the downloaded files
(*
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.pdf")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.xlsx")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.xls")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.rtf")
        File.Delete(@"C:\Users\pkumar\Downloads\gvx.csv")

  *)



