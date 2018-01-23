module AdminAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AdminAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "User Admin" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/UserVer2/UserAdmin.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"

    "Users Report" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/UserReport1.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Users Report"
        ////locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
        displayed "Client Organization"
        displayed "Drag a column header here to group by that column"

    "Volunteer Tag Groups" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/Volunteers/VTagGroupAdmin.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Volunteer Tag Groups"
        //locateWindowWithTitleText "i360 - Volunteer Tag Groups"
        describe "on i360 - Volunteer Tag Groups page ..."
        displayed "Select Group:"
        displayed "Volunteer Tag Groups"

    "Contact Tag Groups" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/CRM/TagGroupAdmin.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Contact Tag Groups"
        //locateWindowWithTitleText "i360 - Contact Tag Groups"
        describe "on i360 - Contact Tag Groups page ..."
        displayed "Contact Tag Groups"
        displayed "Select Group:"

    "Position Roles" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/RoleGroups.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Position Roles"
        //locateWindowWithTitleText "i360 - Position Roles"
        describe "on i360 - Position Roles page ..."
        displayed "Position:"
        //displayed "Available:"
        //displayed "Chosen:"
        displayed "Position Roles"

    "Tableau Users" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/TU.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Tableau Users"
        //locateWindowWithTitleText "i360 - Tableau Users"
        describe "on i360 - Tableau Users page ..."
        displayed "Tableau Users"
        displayed "Unassigned Users"
        displayed "Assigned Users"

    "Organization Touchpoints" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgTouchpoints.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Touchpoints"
        //locateWindowWithTitleText "i360 - Organization Touchpoints"
        describe "on i360 - Organization Touchpoints page ..."
        displayed "Organization"
        displayed "Organization Touchpoints"

    "Organization Portal Content" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgPortalContent.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Portal Content"
        //locateWindowWithTitleText "i360 - Organizational Portal Content"
        describe "on i360 - Organizational Portal Content page ..."
        displayed "Organizational Portal Content"

    "Email Alert Admin" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/EmailAlerts.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Email Alert Admin"
        //locateWindowWithTitleText "i360 - Email Alert Admin"
        describe "on i360 - Email Alert Admin page ..."
        displayed "Email Alert Admin"

    "Email Alert CC and BCC" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/EmailAlertCC.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Email Alert CC and BCC"
        //locateWindowWithTitleText "i360 - Email Alert CC and BCC"
        describe "on i360 - Email Alert CC and BCC page ..."
        displayed "Email Alert CC and BCC"
        displayed "Client Organization"
        displayed "Alert Type"

    "Remove AB\EV Voters From Surveys" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/RST.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Remove AB\EV Voters From Surveys"
        //locateWindowWithTitleText "i360 - Remove AB\EV Voters From Surveys"
        describe "on i360 - Remove AB\EV Voters From Surveys page ..."
        displayed "Remove AB\EV Voters From Surveys"

    "Single Record Import Exceptions" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/ImportSRExceptions.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Single Record Import Exceptions"
        //locateWindowWithTitleText "i360 - Single Row Import Exceptions"
        describe "on i360 - Single Row Import Exceptions page ..."
        displayed "Single Row Import Exceptions"
        displayed "Client Organization:"
        displayed "Start Date"
        displayed "End Date"

    "Child Organizations" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/ChildOrganizations.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Child Organizations"
        //locateWindowWithTitleText "i360 - Child Organizations"
        describe "on i360 - Child Organizations page ..."
        displayed "Child Organizations"

    "User Geography" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/UserGeoAdmin.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Geography"
        //locateWindowWithTitleText "i360 - User Geography Administration"
        describe "on i360 - User Geography Administration page ..."
        displayed "User Geography Administration"
        displayed "Select Client:"
        displayed "Select User:"

        