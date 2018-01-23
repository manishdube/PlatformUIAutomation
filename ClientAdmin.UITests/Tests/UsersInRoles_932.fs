module UsersInRoles_932
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "UsersInRoles_932"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Users In Roles" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUsersInRoles.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Users In Roles"
        //locateWindowWithTitleText "i360 - Users In Roles"
        describe "on i360 - Users In Roles page ..."
        displayed "Users In Roles"
        displayed "Role Name"
        displayed "Client Name"
        describe "done ..."

    "Searches Role Name under Client Name" &&&& fun _ ->
        "#ctl00_MainContent_tbRoleName" << "2"
//        "#ctl00_MainContent_ddlOrg" << "Americans for Prosperity"
        "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
        click "#ctl00_MainContent_btnxSearch"
        sleep 10
        notContains "No data to display" (read "#aspnetForm > div.container.body-content > div > div:nth-child(5) > div")
        describe "done ..."

    "Exports" &&&& fun _ ->
        click "#ctl00_MainContent_MyExportButtons1_btnPdfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsxExport"
        click "#ctl00_MainContent_MyExportButtons1_btnXlsExport"
        click "#ctl00_MainContent_MyExportButtons1_btnRtfExport"
        click "#ctl00_MainContent_MyExportButtons1_btnCsvExport"
        describe "done ..."

    "Click on filter and use the filter" &&&& fun _ ->
        "#ctl00_MainContent_gvx_DXFREditorcol0_I" << "4"
        click "#ctl00_MainContent_btnxSearch"
        click "#gvShowFilters"
        describe "done ..."