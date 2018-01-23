module InternalSystemAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalSystemAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Roles Admin" &&&& fun _ ->
        //url (portalUrl + "Admin/RolesAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Roles Admin"
        //locateWindowWithTitleText "i360 - Roles Administration"
        describe "on i360 - Roles Administration page ..."
        displayed "Roles Administration"

    "Error + Debugging" &&&& fun _ ->
        //url (portalUrl + "Admin/TraceAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Error + Debugging"
        //locateWindowWithTitleText "i360 - Error + Debugging"
        describe "on i360 - Error + Debugging page ..."
        displayed "Error + Debugging"
        displayed "Start Date"
        displayed "End Date"
        displayed "ID"
        displayed "Server"
        displayed "Application"
        displayed "Level"

    "Lookup Data" &&&& fun _ ->
        //url (portalUrl + "Admin/RefAdmin.aspx") 
        //click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(4) > a"
        //click "#Menu2\3a submenu\3a 177 > li:nth-child(3) > a"
        click "Lookup Data"
        //click "#Menu2\3a submenu\3a 174 > li:nth-child(3) > a"
        //compareTimeout <- 20.0
        //locateWindowWithTitleText "i360 - Reference Data Admin"
        describe "on i360 - Reference Data Admin page ..."
        displayed "Reference Data Admin"

    "Portal Content" &&&& fun _ ->
        url (portalUrl + "Admin/PortalContent.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Portal Content"
        //locateWindowWithTitleText "i360 - Portal Content Administration"
        describe "on i360 - Portal Content Administration page ..."
        displayed "Portal Content Administration"

    "Election Officials" &&&& fun _ ->
        url (portalUrl + "Admin/ElectionOfficials.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Election Officials"
        //locateWindowWithTitleText "i360 - Election Officials"
        describe "on i360 - Election Officials page ..."
        displayed "Election Officials"
        displayed "State:"

    "Organization Refresh Rules" &&&& fun _ ->
        //url (portalUrl + "Admin/ClientOrgRefreshRules.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Organization Refresh Rules"
        //locateWindowWithTitleText "i360 - Client Organization Refresh Rules"
        describe "on i360 - Client Organization Refresh Rules page ..."
        displayed "Client Organization Refresh Rules"
        displayed "Organization"

    "Bulk Load Users" &&&& fun _ ->
        //url (portalUrl + "Admin/BulkUsers.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Bulk Load Users"
        //locateWindowWithTitleText "i360 - Ad-Hoc Bulk Users"
        describe "on i360 - Ad-Hoc Bulk Users page ..."
        displayed "Ad-Hoc Bulk Users"

    "Email Alert Admin" &&&& fun _ ->
        //url (portalUrl + "Admin/EmailAlert.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Email Alert Admin"
        //locateWindowWithTitleText "i360 - Email Alert Admin"
        describe "on i360 - Email Alert Admin page ..."
        displayed "Email Alert Admin"

    "Canvass Returns By Minute" &&&& fun _ ->
        //url (portalUrl + "Admin/RptCanvassReturnsPerMinute.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Canvass Returns By Minute"
        //locateWindowWithTitleText "i360 - Canvass Returns Per Minute"
        describe "on i360 - Canvass Returns Per Minute page ..."
        displayed "Canvass Returns Per Minute"
        displayed "Start"
        displayed "End"
        displayed "GMT Offset"
        displayed "MD Database"
        displayed "Survey ID"
        displayed "Type"

    "Canvass Returns By Second" &&&& fun _ ->
        //url (portalUrl + "Admin/RptCanvassReturnsPerSecond.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Canvass Returns By Second"
        //locateWindowWithTitleText "i360 - Canvass Returns Per Second"
        describe "on i360 - Canvass Returns Per Second page ..."
        displayed "Canvass Returns Per Second"
        displayed "Start"
        displayed "End"
        displayed "GMT Offset"
        displayed "MD Database"
        displayed "Survey ID"
        displayed "Type"

    "Help Guides Admin" &&&& fun _ ->
        //url (portalUrl + "Admin/HelpGuidesAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Help Guides Admin"
        //locateWindowWithTitleText "i360 - Help Guides Admin"
        describe "on i360 - Help Guides Admin page ..."
        displayed "Help Guides Admin"
(*

    "CDN Admin" &&&& fun _ ->
        //url (portalUrl + "Admin/CDNAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "CDN Admin"
        //locateWindowWithTitleText "i360 - CDN Admin"
        describe "on i360 - CDN Admin page ..."
        displayed "CDN Admin"
*)

        
    "FB Audience Tracking" &&&& fun _ ->
        //url (portalUrl + "Admin/FBAudienceTracking.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "FB Audience Tracking"
        //click "#Menu2\3a submenu\3a 174 > li:nth-child(13) > a"
        //locateWindowWithTitleText "i360 - Facebook Audience Tracking"
        describe "on i360 - Facebook Audience Tracking page ..."
        displayed "Facebook Audience Tracking"
        displayed "Start Date:"
        displayed "Start Date:"
        displayed "Client Organization:"
        displayed "Status:"

        