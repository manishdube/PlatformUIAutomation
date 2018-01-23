module TableauUsersPage962
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "TableauUsersPage962"
    elementTimeout <- 30.0
    let user = "Dube, Manish"
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Tableau Users" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/TU.aspx") 
        //click "ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Tableau Users"
        locateWindowWithTitleText "i360 - Tableau Users"
        describe "on i360 - Tableau Users page ..."

        //let mutable user = "Dube, Manish"

        click "User Assignments - By User"
        click "#ctl00_MainContent_pc_ddlUsers"
        "#ctl00_MainContent_pc_ddlUsers" << read user

        let mutable rptAvailable = elements "#ctl00_MainContent_pc_gvxTabRpts_DXMainTable > tbody > tr" 
        //let mutable NoDataText_gvxTabRpts = (element "#ctl00_MainContent_pc_gvxTabRpts > tbody > tr > td > div.dxgvCSD").Text

        let mutable getDropDwnValues = (element "#ctl00_MainContent_pc_ddlUsers").Text
  
//        while (((element "#ctl00_MainContent_pc_gvxTabRpts > tbody > tr > td > div.dxgvCSD").Text) <> "No data to display") do
        let selectedAvailableTagRptText = (element "#ctl00_MainContent_pc_gvxTabRpts_DXDataRow0 > td:nth-child(2)").Text

        click "#ctl00_MainContent_pc_gvxTabRpts_DXSelBtn0_D"
        click "#ctl00_MainContent_pc_btnAssignUser"
        sleep 3
        // contains selectedAvailableTagRptText (read "#ctl00_MainContent_pc_gvxTabRptsAssigned > tbody > tr > td > div.dxgvCSD")

        click "User Assignments - By Tableau Report"
        "#ctl00_MainContent_pc_ddlTabRpts" << read selectedAvailableTagRptText
        sleep 2
        "#ctl00_MainContent_pc_gvxAssigned_DXFREditorcol2_I" << user
        press enter
        sleep 5
        // contains user (read "#ctl00_MainContent_pc_gvxAssigned > tbody > tr > td > div.dxgvCSD")
        // notContains user (read "#ctl00_MainContent_pc_gvxUsers > tbody > tr > td > div.dxgvCSD")
        click "User Assignments - By User"

        //let mutable NoDataText_gvxTabRptsAssigned = (element "#ctl00_MainContent_pc_gvxTabRptsAssigned > tbody > tr > td > div.dxgvCSD").Text         
        let RptsAssigned = elements "#ctl00_MainContent_pc_gvxTabRptsAssigned_DXMainTable > tbody > tr "

//        while (((element "#ctl00_MainContent_pc_gvxTabRptsAssigned > tbody > tr > td > div.dxgvCSD").Text) <> "No data to display") do
        let selectedAvailableTagRptText = (element "#ctl00_MainContent_pc_gvxTabRptsAssigned_DXDataRow0 > td:nth-child(2)").Text
               
        click "#ctl00_MainContent_pc_gvxTabRptsAssigned_DXSelBtn0_D"
        click "#ctl00_MainContent_pc_btnUnAssignUser"
        sleep 3
        // contains selectedAvailableTagRptText (read "#ctl00_MainContent_pc_gvxTabRpts > tbody > tr > td > div.dxgvCSD")    
               
        click "User Assignments - By Tableau Report"
        "#ctl00_MainContent_pc_ddlTabRpts" << read selectedAvailableTagRptText
        sleep 3
        "#ctl00_MainContent_pc_gvxUsers_DXFREditorcol2_I" << user
        press enter
        sleep 8
        // contains user (read "#ctl00_MainContent_pc_gvxUsers > tbody > tr > td > div.dxgvCSD")
        // notContains user (read "#ctl00_MainContent_pc_gvxAssigned > tbody > tr > td > div.dxgvCSD")
        click "User Assignments - By User" 
                
        describe "done with the moving of Reoprts test cases ... "