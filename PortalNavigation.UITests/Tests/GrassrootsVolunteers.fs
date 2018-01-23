module GrassrootsVolunteers
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "GrassrootsVolunteers"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Volunteers" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/Volunteers.aspx") 
        //click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
        //locateWindowWithTitleText "i360 - Volunteers"
        describe "on i360 - Volunteers page ..."
        displayed "Volunteers"
//        displayed "Select Organization:"

    "Add Volunteer" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/V3.aspx") 
        //click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Add Volunteer"
        //locateWindowWithTitleText "i360 - Volunteer Details"
        describe "on i360 - Volunteer Details page ..."
        displayed "Add Volunteer"

    "Last Volunteer" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolunteerRedirect.aspx") 
        //click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Last Volunteer"
        //locateWindowWithTitleText "i360 - Volunteer Details"
        describe "on i360 - Volunteer Details page ..."
//        displayed "Volunteer Details"
//        displayed "Permissions"
//        displayed "Quick Tags"
//        displayed "User Name"
//        displayed "Password"

    "Precinct Assignments" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolunteerPrecinctAssc.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Precinct Assignments"
        //locateWindowWithTitleText "i360 - Precinct Assignments"
        describe "on i360 - Precinct Assignments page ..."
        displayed "Precinct"
        displayed "State"
        displayed "Election Day"
        displayed "Election Type"

    "Import Volunteers" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Import/Imports.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Import Volunteers"
        //locateWindowWithTitleText "i360 - Imports"
        describe "on i360 - Imports page ..."
        displayed "Create an Import"
        displayed "* Upload a File"
        displayed "* Import Name"
        displayed "Global Tags"

    "Volunteer Management" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolMan2.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Management"
        //locateWindowWithTitleText "i360 - Volunteer Management"
        describe "on i360 - Volunteer Management page ..."
        displayed "Volunteer Management"
        displayed "Coordinator:"

    "Survey Responses Report" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/rptVolunteerSurveyResponses.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Survey Responses Report"
        //locateWindowWithTitleText "i360 - Volunteer Survey Responses"
        describe "on i360 - Volunteer Survey Responses page ..."
        displayed "Volunteer Survey Responses"
//        displayed "Select Organization:"
        displayed "Volunteer"
        displayed "Tag"
        displayed "Survey"

    "Touchpoint Report" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/rptTP.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Touchpoint Report"
        //locateWindowWithTitleText "i360 - Touchpoint Report"
        describe "on i360 - Touchpoint Report page ..."
        displayed "Touchpoint Report"
        displayed "Client Org Touchpoints"
        displayed "End Date"
        displayed "Start Date"

    "Transfer Volunteers" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/TransferVolunteers.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Transfer Volunteers"
        //locateWindowWithTitleText "i360 - Transfer Volunteers"
        describe "on i360 - Transfer Volunteers page ..."
        displayed "Transfer Volunteers"
        displayed "From Coordinator:"
        displayed "To Coordinator:"