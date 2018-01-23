module InternalAdvancedAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalAdvancedAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "System Configuration" &&&& fun _ ->
        //url (portalUrl + "Admin/SysCon.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "System Configuration"
        //locateWindowWithTitleText "i360 - System Configuration"
        describe "on i360 - System Configuration page ..."
        displayed "System Configuration"

    "Mail Gun Reports" &&&& fun _ ->
        //url (portalUrl + "Admin/MailGunReports.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Mail Gun Reports"
        //locateWindowWithTitleText "i360 - Mail Gun Reports"
        describe "on i360 - Mail Gun Reports page ..."
        displayed "Mail Gun Reports"
        displayed "Gun Email Report"

    "Caching" &&&& fun _ ->
        //url (portalUrl + "Admin/CacheAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Caching"
        //locateWindowWithTitleText "i360 - Caching"
        describe "on i360 - Caching page ..."
        displayed "Caching"
(*   
    //Pratibha: This URL takes to the Home page(search)
    "Hangfire Dashboard" &&&& fun _ ->
        //url (portalUrl + "Admin/HangfireEnvSwitch.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Hangfire Dashboard"
        //locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed ""
        displayed ""
        displayed ""
        displayed ""
*)
    "Analytics Poll" &&&& fun _ ->
        //url (portalUrl + "Admin/APollAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Analytics Poll"
        //locateWindowWithTitleText "i360 - Analytics Poll Admin"
        describe "on i360 - Analytics Poll Admin page ..."
        displayed "Analytics Poll Admin"
        displayed "Poll Type:"

    "Analytics Poll Permissions" &&&& fun _ ->
        //url (portalUrl + "Admin/APollPermissions.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Analytics Poll Permissions"
        //locateWindowWithTitleText "i360 - Analytics Poll Permissions"
        describe "on i360 - Analytics Poll Permissions page ..."
        displayed "Analytics Poll Permissions"
        displayed "Select Poll:"

       
