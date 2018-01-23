module AccountsUserReports
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsUserReports"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

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

    "User Role Analysis" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUserRoleAnalysis.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "User Role Analysis"
        //locateWindowWithTitleText "i360 - User Role Analysis"
        describe "on i360 - User Role Analysis page ..."
        displayed "User Role Analysis"
        displayed "Status"
        displayed "Client Name"

    "Users By Client Org" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUsersByOrg.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Users By Client Org"
        //locateWindowWithTitleText "i360 - Users By Client"
        describe "on i360 - Users By Client page ..."
        displayed "Users By Client"
        displayed "Client:"

    "Help Requests" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptAdminHelpRequests.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Help Requests"
        //locateWindowWithTitleText "i360 - Help Requests"
        describe "on i360 - Help Requests page ..."
        displayed "Help Requests"

    "Ordered Search Report By User" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrderedSearchByUser.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Ordered Search Report By User"
        //locateWindowWithTitleText "i360 - Ordered Search Report by User"
        describe "on i360 - Ordered Search Report by User page ..."
        displayed "Ordered Search Report by User"
        displayed "Status"
        displayed "Start Date"
        displayed "End Date"

    "Scheduled Email Reports" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ScheduledEmailReports.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Scheduled Email Reports"
        //locateWindowWithTitleText "i360 - Scheduled Email Reports"
        describe "on i360 - Scheduled Email Reports page ..."
        displayed "Scheduled Email Reports"
