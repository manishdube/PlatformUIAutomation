module PortalNavigationalTests
open canopy
open runner
open etconfig
open lib
open System

let core _ = 
    context "PortalNavigationalTests"
    compareTimeout <- 30.0

    "Login" &&& fun _ ->
        url (portalUrl)
        locateWindowWithTitleText "i360 Portal Accounts"
        describe "on Login page ..."
        setFieldValue "input[id='username']" username
        setFieldValue "input[id='password']" password
        click "input[id='Login1_Button1']"
        locateWindowWithTitleText "i360 - Home Page"
        describe "on i360 - Home Page page ..."
        displayed "Quick Links"

(*
// issues with the modal screen
    "Basic Search" &&& fun _ ->
        //url (portalUrl + "Search/Search/StandardSearch.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "#btnStartClose"
        waitForElement "Lets get started!" 
        //click "btnStartClose"
*)
    "Combined Searches" &&& fun _ ->
        //url (portalUrl + "Search/Search/CombinedSearch.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Combined Searches"
        locateWindowWithTitleText "i360 - Combined Searches"
        describe "on i360 - Combined Searches page ..."
        displayed "Combined Searches"
        displayed "Criteria"
        displayed "Overview"
        displayed "Find" 
(*
// issues with the modal screen
    "Export" &&& fun _ ->
        url (portalUrl + "Search/Search/SearchExport.aspx") 
        displayed "Individual Search"
        displayed "Searches"
        displayed "Saved"
        displayed "Quick Links"
        displayed "Choose widget to display:"
*)
    "Individual i360 Search" &&& fun _ ->
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Individual i360 Search"
        locateWindowWithTitleText "i360 - Individual i360 Search"
        describe "on Individual i360 Search page ..."
        displayed "Individual i360 Search"
        displayed "Drag a column header here to group by that column"  
        displayed "State"
        displayed "First Name"
        displayed "Last Name"
        displayed "Birth Year"

    "MyData" &&& fun _ ->
        //url (portalUrl + "Search/CRM/Contacts.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "MyData"
        locateWindowWithTitleText "i360 - MyData"
        describe "on i360 - MyData page ..."
        displayed "MyData"
        displayed "Tag Checked"

    "Individual MyData Search" &&& fun _ ->
        //url (portalUrl + "Search/Search/IndividualSearchContact.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Individual MyData Search"
        locateWindowWithTitleText "i360 - Individual MyData Search"
        describe "on i360 - Individual MyData Search page ..."
        displayed "Individual MyData Search"
        displayed "State"
        displayed "Birth Year"
        displayed "City"
        displayed "Zip"
        displayed "Party"

    "Add Contact" &&& fun _ ->
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Add Contact"
        locateWindowWithTitleText "i360 - Contact Detail"
        describe "on i360 - Contact Detail page ..."
        displayed "Add Contact"
        displayed "Required Information"
        displayed "First Name"
        displayed "Last Name"
        displayed "State"
        displayed "Zipcode"
        displayed "Enter Full Record"
        displayed "Facebook Page"
        displayed "Occupation"

    "Last Contact" &&& fun _ ->
        //url (portalUrl + "Search/CRM/ContactRedirect.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Last Contact"
        locateWindowWithTitleText "i360 - Contact Detail"
        describe "on i360 - Contact Detail page ..." 
        displayed "Contact Details"
        displayed "Contact Tags"
        //displayed "Other Household Members"
        displayed "Relationships"
        displayed "Contact Notes"

    "MyData Tags" &&& fun _ ->
        //url (portalUrl + "CRM/TagAdmin.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "MyData Tags"
        locateWindowWithTitleText "i360 - MyData Tags"
        describe "on 360 - MyData Tags page ..."
        displayed "MyData Tags"

    "MyData Categories" &&& fun _ ->
        //url (portalUrl + "CRM/CatAdmin.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "MyData Categories"
        locateWindowWithTitleText "i360 - MyData Categories"
        describe "on i360 - MyData Categories page ..."
        displayed "MyData Categories" 

    "Import" &&& fun _ ->
        //url (portalUrl + "Import/Imports.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Import"
        locateWindowWithTitleText "i360 - Imports"
        describe "on i360 - Imports page ..." 
        displayed "Imports Home"
        displayed "Click on a row to view more information in the review section below."
        displayed "Status Legend:"
        //displayed "My Imports Only"
        displayed "Import Name"
        displayed "New Import"
        displayed "By"
        displayed "Previous"

    "Tag-Phone Import" &&& fun _ ->
        //url (portalUrl + "Import/PhoneTagImport.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Tag-Phone Import" 
        locateWindowWithTitleText "i360 - Phone Tag Import"
        describe "on i360 - Phone Tag Import page ..."
        displayed "Phone Tag Import"
        displayed "Telephone Numbers"
        displayed "Notes:"
        displayed "Category:"

    "Volunteers" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/Volunteers.aspx") 
        click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "#Menu1\3a submenu\3a 24 > li:nth-child(1) > a"
        locateWindowWithTitleText "i360 - Volunteers"
        describe "on i360 - Volunteers page ..."
        displayed "Volunteers"
        displayed "Select Organization:"

    "Add Volunteer" &&& fun _ ->
        url (portalUrl + "Grassroots/Volunteers/V3.aspx") 

    "Last Volunteer" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolunteerRedirect.aspx") 
        click i360HomeLogo        
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "#Menu1\3a submenu\3a 24 > li:nth-child(3) > a"
        locateWindowWithTitleText "i360 - Volunteer Details"
        describe "on i360 - Volunteer Details page ..."
        displayed "Volunteer Details"
        displayed "Permissions"
        displayed "Quick Tags"
        displayed "User Name"
        displayed "Password"

    "Precinct Assignments" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolunteerPrecinctAssc.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Precinct Assignments"
        locateWindowWithTitleText "i360 - Precinct Assignments"
        describe "on i360 - Precinct Assignments page ..."
        displayed "Precinct"
        displayed "State"
        displayed "Election Day"
        displayed "Election Type"

    "Import Volunteers" &&& fun _ ->
        //url (portalUrl + "Grassroots/Import/Imports.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Import Volunteers"
        locateWindowWithTitleText "i360 - Imports"
        describe "on i360 - Imports page ..."
        displayed "Create an Import"
        displayed "* Upload a File"
        displayed "* Import Name"
        displayed "Global Tags"

    "Volunteer Management" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VolMan2.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Management"
        locateWindowWithTitleText "i360 - Volunteer Management"
        describe "on i360 - Volunteer Management page ..."
        displayed "Volunteer Management"
        displayed "Coordinator:"

    "Survey Responses Report" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/rptVolunteerSurveyResponses.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Survey Responses Report"
        locateWindowWithTitleText "i360 - Volunteer Survey Responses"
        describe "on i360 - Volunteer Survey Responses page ..."
        displayed "Volunteer Survey Responses"
        displayed "Select Organization:"
        displayed "Volunteer"
        displayed "Tag"
        displayed "Survey"

    "Touchpoint Report" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/rptTP.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Touchpoint Report"
        locateWindowWithTitleText "i360 - Touchpoint Report"
        describe "on i360 - Touchpoint Report page ..."
        displayed "Touchpoint Report"
        displayed "Client Org Touchpoints"
        displayed "End Date"
        displayed "Start Date"

    "Transfer Volunteers" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/TransferVolunteers.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Transfer Volunteers"
        locateWindowWithTitleText "i360 - Transfer Volunteers"
        describe "on i360 - Transfer Volunteers page ..."
        displayed "Transfer Volunteers"
        displayed "From Coordinator:"
        displayed "To Coordinator:"

    "Volunteer Tags" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VtagAdmin.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Tags"
        locateWindowWithTitleText "i360 - Volunteer Tags"
        describe "on i360 - Volunteer Tags page ..."
        displayed "Volunteer Tags"

    "Volunteer Categories" &&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VCatAdmin.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Categories"
        locateWindowWithTitleText "i360 - Volunteer Categories"
        describe "on i360 - Volunteer Categories page ..."
        displayed "Volunteer Categories"

    "Network Calendar" &&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Network Calendar"
        locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
        displayed "Legend"
        displayed "Filter events by organization"

    "Shared Locations" &&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Shared Locations"
        locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
//        displayed "Filter events by organization"

    "Shared Talent" &&& fun _ ->
        //url (portalUrl + "iNetwork/iTalent.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Shared Talent"
        locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
       // displayed "Filter events by organization"

    "Survey Home" &&& fun _ ->
        //url (portalUrl + "SurveyV2/SurveySelect.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Survey Home"
        locateWindowWithTitleText "i360 - Select a Survey"
        describe "on i360 - Select a Survey page ..."
        displayed "Select a Survey"
        displayed "Client Org"

    "List Survey Volunteers" &&& fun _ ->
        //url (portalUrl + "SurveyV2/rptSurveyVolunteers.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "List Survey Volunteers"
        locateWindowWithTitleText "i360 - List Survey Volunteers"
        describe "on i360 - List Survey Volunteers page ..."
        displayed "List Survey Volunteers"
        displayed "Survey:"
        
    "Predictive Dialer Link" &&& fun _ ->
        //url (portalUrl + "SurveyV2/PDLink.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Predictive Dialer Link"
        locateWindowWithTitleText "i360 - Predictive Dialer Link"
        describe "on i360 - Predictive Dialer Link page ..."
        displayed "Predictive Dialer Link"
        displayed "Click to go to the Predictive Dialer login form:"
(*
    "Load Paper Walkbook Results" &&& fun _ ->
        //url (portalUrl + "SurveyV2/ILink.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Load Paper Walkbook Results"
        locateWindowWithTitleText "Paper Walkbook Ingestion"
        describe "on Paper Walkbook Ingestion page ..."
        displayed "Welcome to the walkbook data return site."
*)
    "Canvassing Report" &&& fun _ ->
        //url (portalUrl + "SurveyV2/Reports/CanvassingReportSurveySelect.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Canvassing Report"
        locateWindowWithTitleText "i360 - Canvassing Report"
        describe "on i360 - Canvassing Report page ..."
        displayed "Canvassing Report"
        displayed "Select a Survey"
        displayed "Client Organization:"

    "PD Admin" &&& fun _ ->
        //url (portalUrl + "SurveyV2/PDAdmin.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "PD Admin"
        locateWindowWithTitleText "i360 - PD Admin"
        describe "on i360 - PD Admin page ..."

    "Call Admin" &&& fun _ ->
        //url (portalUrl + "SurveyV2/CallAdminSwitch.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Call Admin"
        locateWindowWithTitleText "i360 - Call Admin"
        describe "on i360 - Call Admin page ..."
        displayed "Call Admin"
        displayed "Status Filter"

    "Snapshots" &&& fun _ ->
        //url (portalUrl + "Analytics/Analytix/SSRSPlus.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Snapshots"
        locateWindowWithTitleText "i360 - Snapshots"
        describe "on i360 - Snapshots page ..."
        displayed "Snapshots"
        displayed "Select Report:"

    "Dashboards" &&& fun _ ->
        //url (portalUrl + "Analytics/Analytix/Dashboards.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Dashboards"
        locateWindowWithTitleText "i360 - Dashboards"
        describe "on i360 - Dashboards page ..."
        displayed "Dashboards"
        displayed "Select Year"
        displayed "Select Dashboard View:"

    "Upload Documents" &&& fun _ ->
        //url (portalUrl + "Analytics/Docs/Docs.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Upload Documents"
        //locateWindowWithTitleText "i360 - Test and Learn: Upload Documents"
        describe "on i360 - Upload Documents page ..."
        displayed "Upload Documents"
        displayed "Poll Date:"
        displayed "Description:"
        displayed "Tags:"

    "View Documents" &&& fun _ ->
        //url (portalUrl + "Analytics/Docs/EditDocs.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "#Menu1\3a submenu\3a 68 > li:nth-child(2) > a"
        locateWindowWithTitleText "i360 - Analytics: View Documents"
        describe "on i360 - Analytics: View Documents page ..."
        displayed "Analytics: View Documents"

    "Upload Documents" &&& fun _ ->
        //url (portalUrl + "Analytics/Docs/DocsM.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Upload Documents"
        //locateWindowWithTitleText "i360 - Test and Learn: Upload Documents"
        describe "on i360 - Test and Learn: Upload Documents page ..."
        //displayed "Test and Learn: Upload Documents"
        displayed "Poll Date:"
        displayed "Description:"
        displayed "Tags:"

    "View Documents" &&& fun _ ->
        //url (portalUrl + "Analytics/Docs/EditDocsM.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "#Menu1\3a submenu\3a 72 > li:nth-child(2) > a"
        locateWindowWithTitleText "i360 - Test and Learn: View Documents"
        describe "on i360 - Test and Learn: View Documents page ..."
        displayed "Test and Learn: View Documents"

    "View Polls" &&& fun _ ->
        //url (portalUrl + "Analytics/Poll/ViewPollM.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "View Polls"
        locateWindowWithTitleText "i360 - View Polls"
        describe "on i360 - View Polls page ..."
        displayed "View Polls"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"

    "Poll Aggregates Report" &&& fun _ ->
        //url (portalUrl + "Analytics/Poll/rptPollAggregates.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Poll Aggregates Report"
        locateWindowWithTitleText "i360 - Poll Aggregates Report"
        describe "on i360 - Poll Aggregates Report page ..."
        displayed "Poll Aggregates Report"
        displayed "State"
        displayed "Race Type"
        displayed "Group Types"
        displayed "Source"

    "Poll Templates" &&& fun _ ->
        //url (portalUrl + "Analytics/Poll/TemplatePoll.aspx")
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Poll Templates"
        locateWindowWithTitleText "i360 - Poll Templates"
        describe "on i360 - Poll Templates page ..."
        displayed "Poll Templates"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"

    "Add New Poll" &&& fun _ ->
        //url (portalUrl + "Analytics/Poll/AddPoll.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Add New Poll"
        locateWindowWithTitleText "i360 - Add New Poll"
        describe "on i360 - Add New Poll page ..."
        displayed "Add New Poll"
        displayed "Select Poll Template:"
        displayed "Race Type:"
        displayed "Visibility:"
        displayed "State:"

    "Edit Polls" &&& fun _ ->
        //url (portalUrl + "Analytics/Poll/ViewPoll.aspx") 
        click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Edit Polls"
        locateWindowWithTitleText "i360 - Edit Polls"
        describe "on i360 - Edit Polls page ..."
        displayed "Edit Polls"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"

    "User Admin" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/UserVer2/UserAdmin.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"

    "Users Report" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/UserReport1.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Users Report"
        //locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
        displayed "Client Organization"
        displayed "Drag a column header here to group by that column"

    "Volunteer Tag Groups" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/Volunteers/VTagGroupAdmin.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Volunteer Tag Groups"
        locateWindowWithTitleText "i360 - Volunteer Tag Groups"
        describe "on i360 - Volunteer Tag Groups page ..."
        displayed "Select Group:"
        displayed "Volunteer Tag Groups"

    "Contact Tag Groups" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/CRM/TagGroupAdmin.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Contact Tag Groups"
        locateWindowWithTitleText "i360 - Contact Tag Groups"
        describe "on i360 - Contact Tag Groups page ..."
        displayed "Contact Tag Groups"
        displayed "Select Group:"

    "Position Roles" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/RoleGroups.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Position Roles"
        locateWindowWithTitleText "i360 - Position Roles"
        describe "on i360 - Position Roles page ..."
        displayed "Position:"
        //displayed "Available:"
        //displayed "Chosen:"
        displayed "Position Roles"

    "Tableau Users" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/TU.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Tableau Users"
        locateWindowWithTitleText "i360 - Tableau Users"
        describe "on i360 - Tableau Users page ..."
        displayed "Tableau Users"
        displayed "Unassigned Users"
        displayed "Assigned Users"

    "Organization Touchpoints" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgTouchpoints.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Touchpoints"
        locateWindowWithTitleText "i360 - Organization Touchpoints"
        describe "on i360 - Organization Touchpoints page ..."
        displayed "Organization"
        displayed "Organization Touchpoints"

    "Organization Portal Content" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/OrgPortalContent.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Organization Portal Content"
        locateWindowWithTitleText "i360 - Organizational Portal Content"
        describe "on i360 - Organizational Portal Content page ..."
        displayed "Organizational Portal Content"

    "Email Alert Admin" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/EmailAlerts.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Email Alert Admin"
        locateWindowWithTitleText "i360 - Email Alert Admin"
        describe "on i360 - Email Alert Admin page ..."
        displayed "Email Alert Admin"

    "Email Alert CC and BCC" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/EmailAlertCC.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Email Alert CC and BCC"
        locateWindowWithTitleText "i360 - Email Alert CC and BCC"
        describe "on i360 - Email Alert CC and BCC page ..."
        displayed "Email Alert CC and BCC"
        displayed "Client Organization"
        displayed "Alert Type"

    "Remove AB\EV Voters From Surveys" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/RST.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Remove AB\EV Voters From Surveys"
        locateWindowWithTitleText "i360 - Remove AB\EV Voters From Surveys"
        describe "on i360 - Remove AB\EV Voters From Surveys page ..."
        displayed "Remove AB\EV Voters From Surveys"

    "Single Record Import Exceptions" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/ImportSRExceptions.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Single Record Import Exceptions"
        locateWindowWithTitleText "i360 - Single Row Import Exceptions"
        describe "on i360 - Single Row Import Exceptions page ..."
        displayed "Single Row Import Exceptions"
        displayed "Client Organization:"
        displayed "Start Date"
        displayed "End Date"

    "Child Organizations" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/ChildOrganizations.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "Child Organizations"
        locateWindowWithTitleText "i360 - Child Organizations"
        describe "on i360 - Child Organizations page ..."
        displayed "Child Organizations"

    "User Geography" &&& fun _ ->
        //url (portalUrl + "ClientAdmin/User/UserGeoAdmin.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Geography"
        locateWindowWithTitleText "i360 - User Geography Administration"
        describe "on i360 - User Geography Administration page ..."
        displayed "User Geography Administration"
        displayed "Select Client:"
        displayed "Select User:"

    "Dynamic Reporting" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/DynamicReporting.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Dynamic Reporting"
        locateWindowWithTitleText "i360 - Dynamic Reporting"
        describe "on i360 - Dynamic Reporting page ..."

    "API Audit" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptAPIAudit.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "API Audit"
        locateWindowWithTitleText "i360 - API Audit Report"
        describe "on i360 - API Audit Report page ..."
        displayed "API Audit Report"
        displayed "API Org:"
        displayed "API User:"
        displayed "URL:"

    "Folksonomy Tag Linking" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TagFolkAssc.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Folksonomy Tag Linking"
        locateWindowWithTitleText "i360 - Folksonomy Tag Linking"
        describe "on i360 - Folksonomy Tag Linking page ..."
        displayed "Folksonomy Tag Linking"

    "Merge MyData Tags" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeContactTags.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge MyData Tags"
        locateWindowWithTitleText "i360 - Merge MyData Tags"
        describe "on i360 - Merge MyData Tags page ..."
        displayed "Merge MyData Tags"
        displayed "Tag to Keep"
        displayed "Tag to Merge"

    "Merge Volunteer Tags" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeVolunteerTags.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge Volunteer Tags"
        locateWindowWithTitleText "i360 - Merge Volunteer Tags"
        describe "on i360 - Merge Volunteer Tags page ..."
        displayed "Merge Volunteer Tags"
        displayed "Tag to keep:"
        displayed "Tag to merge:"

    "Client Organizations" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ClientOrgAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Client Organizations"
        locateWindowWithTitleText "i360 - Client Organizations"
        describe "on i360 - Client Organizations page ..."
        displayed "Client Organizations"

    "Client Geography" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ClientGeoAdmin.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Client Geography"
        locateWindowWithTitleText "i360 - Client Geography Administration"
        describe "on i360 - Client Geography Administration page ..."
        displayed "Client Geography Administration"
        displayed "Select Client Organization:"

    "Organization Lookup Data" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        locateWindowWithTitleText "i360 - Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"

    "Organization Page Views" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrgPageViews.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Page Views"
        locateWindowWithTitleText "i360 - Organization Page Views"
        describe "on i360 - Organization Page Views page ..."
        displayed "Organization Page Views"
        displayed "Client Organization"

    "Empty Data Report" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptEmptyData.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Empty Data Report"
        locateWindowWithTitleText "i360 - Empty Data Report"
        describe "on i360 - Empty Data Report page ..."
        displayed "Empty Data Report"
        displayed "Database"

    "Logo Upload" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/LogoUpload.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Logo Upload"
        locateWindowWithTitleText "i360 - Logo Upload"
        describe "on i360 - Logo Upload page ..."
        displayed "Logo Upload"
        displayed "Select Image file to Upload:"
        
    "Election Admin" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ElectionAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Election Admin"
        locateWindowWithTitleText "i360 - Election Admin"
        describe "on i360 - Election Admin page ..."
        displayed "Election Admin"

    "Imports Admin" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/Import/ImportAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Imports Admin"
        locateWindowWithTitleText "i360 - Import Admin"
        describe "on i360 - Import Admin page ..."
        displayed "Imports Admin"

    "Survey Publishing Admin" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/SurveyPublishingAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Survey Publishing Admin"
        locateWindowWithTitleText "i360 - Survey Publishing Admin"
        describe "on i360 - Survey Publishing Admin page ..."
        displayed "Survey Publishing Admin"

    "Observation Clusters" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ObservationClusters.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Observation Clusters"
        locateWindowWithTitleText "i360 - Observation Cluster Administration"
        describe "on i360 - Observation Cluster Administration page ..."
        displayed "Observation Cluster Administration"
      
    "External Data Sync" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ExternalDataSync.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "External Data Sync"
        locateWindowWithTitleText "i360 - External Data Synchronization"
        describe "on i360 - External Data Synchronization page ..."
        displayed "External Data Synchronization"

    "PD Config" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PDConfigAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "PD Config"
        locateWindowWithTitleText "i360 - PD Config Admin"
        describe "on i360 - PD Config Admin page ..."
        displayed "PD Config Admin"
        displayed "Environment:"
        displayed "Server:"

    "Billing Report" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBilling.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Report"
        locateWindowWithTitleText "i360 - Billing Report"
        describe "on i360 - Billing Report page ..."
        displayed "Billing Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"

    "Billing List and Export Detail" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingListAndExportDetail.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing List and Export Detail"
        locateWindowWithTitleText "i360 - Billing List and Export Detail Report"
        describe "on i360 - Billing List and Export Detail Report page ..."
        displayed "Billing List and Export Detail Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"
        displayed "State"

    "Billing Call Detail" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingCallDetail.aspx")
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Call Detail"
        locateWindowWithTitleText "i360 - Billing Call Detail Report"
        describe "on i360 - Billing Call Detail Report page ..."
        displayed "Billing Call Detail Report"
        displayed "Start Date"
        displayed "End Date"
        displayed "Client Org"
        displayed "Area Code"
        displayed "Cost/Min"

    "Billing Call Summary" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptBillingCallSummary.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Billing Call Summary"
        locateWindowWithTitleText "i360 - Billing Call Summary Report"
        describe "on i360 - Billing Call Summary Report page ..."
        displayed "Billing Call Summary Report"
        displayed "Start Date"
        displayed "End Date"

    "User Groups" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/UserGroups.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "User Groups"
        locateWindowWithTitleText "i360 - User Groups"
        describe "on i360 - User Groups page ..."
        displayed "User Groups"
        displayed "Select a Group"

    "Query Constraints" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/QueryConstraints.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Query Constraints"
        locateWindowWithTitleText "i360 - Query Constraints"
        describe "on i360 - Query Constraints page ..."
        displayed "Query Constraints"
        displayed "User"
        displayed "Query Type"
        displayed "State"

    "Look Up Password" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/Impersonate.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Look Up Password"
        locateWindowWithTitleText "i360 - Look Up Password"
        describe "on i360 - Look Up Password page ..."
        displayed "Look Up Password"
        displayed "Select User to Impersonate"
        displayed "Select Organization"
        displayed "New Organization Wide Password"

    "Delete Contacts" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/DeleteContacts.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Delete Contacts"
        locateWindowWithTitleText "i360 - Delete Contacts"
        describe "on i360 - Delete Contacts page ..."
        displayed "Delete Contacts"

    "Users In Roles" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUsersInRoles.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Users In Roles"
        locateWindowWithTitleText "i360 - Users In Roles"
        describe "on i360 - Users In Roles page ..."
        displayed "Users In Roles"
        displayed "Role Name"
        displayed "Client Name"

    "User Role Analysis" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUserRoleAnalysis.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "User Role Analysis"
        locateWindowWithTitleText "i360 - User Role Analysis"
        describe "on i360 - User Role Analysis page ..."
        displayed "User Role Analysis"
        displayed "Status"
        displayed "Client Name"

    "Users By Client Org" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptUsersByOrg.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Users By Client Org"
        locateWindowWithTitleText "i360 - Users By Client"
        describe "on i360 - Users By Client page ..."
        displayed "Users By Client"
        displayed "Client:"

    "Help Requests" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptAdminHelpRequests.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Help Requests"
        locateWindowWithTitleText "i360 - Help Requests"
        describe "on i360 - Help Requests page ..."
        displayed "Help Requests"

    "Ordered Search Report By User" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrderedSearchByUser.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Ordered Search Report By User"
        locateWindowWithTitleText "i360 - Ordered Search Report by User"
        describe "on i360 - Ordered Search Report by User page ..."
        displayed "Ordered Search Report by User"
        displayed "Status"
        displayed "Start Date"
        displayed "End Date"

    "Scheduled Email Reports" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ScheduledEmailReports.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Scheduled Email Reports"
        locateWindowWithTitleText "i360 - Scheduled Email Reports"
        describe "on i360 - Scheduled Email Reports page ..."
        displayed "Scheduled Email Reports"

    "Searches" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/SavedSearchAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Searches"
        locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed "Searches"
        displayed "Start Date"
        displayed "End Date"
        displayed "Organization"
        displayed "User"
        displayed "Combined"
        displayed "Active"
        displayed "Status"

    "Parameter Report" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrderedSearchParameters.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Parameter Report"
        locateWindowWithTitleText "i360 - Ordered Search Parameters Report"
        describe "on i360 - Ordered Search Parameters Report page ..."
        displayed "Ordered Search Parameters Report"
        displayed "Organization"
        displayed "Status"
        displayed "State Date"
        displayed "End Date"

    "Tableau Admin" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TableauAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Tableau Admin"
        locateWindowWithTitleText "i360 - Tableau Administration"
        describe "on i360 - Tableau Administration page ..."
        displayed "Tableau Administration"

    "Tableau Organizations" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TableauOrgAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Tableau Organizations"
        locateWindowWithTitleText "i360 - Tableau Organizations"
        describe "on i360 - Tableau Organizations page ..."
        displayed "Tableau Organizations"

    "Pyramid Admin" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PyramidAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Pyramid Admin"
        locateWindowWithTitleText "i360 - Pyramid Administration"
        describe "on i360 - Pyramid Administration page ..."
        displayed "Pyramid Administration"

    "Roles Admin" &&& fun _ ->
        //url (portalUrl + "Admin/RolesAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Roles Admin"
        locateWindowWithTitleText "i360 - Roles Administration"
        describe "on i360 - Roles Administration page ..."
        displayed "Roles Administration"

    "Error + Debugging" &&& fun _ ->
        //url (portalUrl + "Admin/TraceAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Error + Debugging"
        locateWindowWithTitleText "i360 - Error + Debugging"
        describe "on i360 - Error + Debugging page ..."
        displayed "Error + Debugging"
        displayed "Start Date"
        displayed "End Date"
        displayed "ID"
        displayed "Server"
        displayed "Application"
        displayed "Level"

    "Lookup Data" &&& fun _ ->
        //url (portalUrl + "Admin/RefAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Lookup Data"
        //locateWindowWithTitleText "i360 - Reference Data Admin"
        describe "on i360 - Reference Data Admin page ..."
        displayed "Reference Data Admin"

    "Portal Content" &&& fun _ ->
        url (portalUrl + "Admin/PortalContent.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Portal Content"
        locateWindowWithTitleText "i360 - Portal Content Administration"
        describe "on i360 - Portal Content Administration page ..."
        displayed "Portal Content Administration"

    "Election Officials" &&& fun _ ->
        url (portalUrl + "Admin/ElectionOfficials.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Election Officials"
        locateWindowWithTitleText "i360 - Election Officials"
        describe "on i360 - Election Officials page ..."
        displayed "Election Officials"
        displayed "State:"

    "Organization Refresh Rules" &&& fun _ ->
        //url (portalUrl + "Admin/ClientOrgRefreshRules.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Organization Refresh Rules"
        locateWindowWithTitleText "i360 - Client Organization Refresh Rules"
        describe "on i360 - Client Organization Refresh Rules page ..."
        displayed "Client Organization Refresh Rules"
        displayed "Organization"

    "Bulk Load Users" &&& fun _ ->
        //url (portalUrl + "Admin/BulkUsers.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Bulk Load Users"
        locateWindowWithTitleText "i360 - Ad-Hoc Bulk Users"
        describe "on i360 - Ad-Hoc Bulk Users page ..."
        displayed "Ad-Hoc Bulk Users"

    "Email Alert Admin" &&& fun _ ->
        //url (portalUrl + "Admin/EmailAlert.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Email Alert Admin"
        locateWindowWithTitleText "i360 - Email Alert Admin"
        describe "on i360 - Email Alert Admin page ..."
        displayed "Email Alert Admin"

    "Canvass Returns By Minute" &&& fun _ ->
        //url (portalUrl + "Admin/RptCanvassReturnsPerMinute.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Canvass Returns By Minute"
        locateWindowWithTitleText "i360 - Canvass Returns Per Minute"
        describe "on i360 - Canvass Returns Per Minute page ..."
        displayed "Canvass Returns Per Minute"
        displayed "Start"
        displayed "End"
        displayed "GMT Offset"
        displayed "MD Database"
        displayed "Survey ID"
        displayed "Type"

    "Canvass Returns By Second" &&& fun _ ->
        //url (portalUrl + "Admin/RptCanvassReturnsPerSecond.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Canvass Returns By Second"
        locateWindowWithTitleText "i360 - Canvass Returns Per Second"
        describe "on i360 - Canvass Returns Per Second page ..."
        displayed "Canvass Returns Per Second"
        displayed "Start"
        displayed "End"
        displayed "GMT Offset"
        displayed "MD Database"
        displayed "Survey ID"
        displayed "Type"

    "Help Guides Admin" &&& fun _ ->
        //url (portalUrl + "Admin/HelpGuidesAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Help Guides Admin"
        locateWindowWithTitleText "i360 - Help Guides Admin"
        describe "on i360 - Help Guides Admin page ..."
        displayed "Help Guides Admin"

    "CDN Admin" &&& fun _ ->
        //url (portalUrl + "Admin/CDNAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "CDN Admin"
        locateWindowWithTitleText "i360 - CDN Admin"
        describe "on i360 - CDN Admin page ..."
        displayed "CDN Admin"
        
    "FB Audience Tracking" &&& fun _ ->
        //url (portalUrl + "Admin/FBAudienceTracking.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "FB Audience Tracking"
        locateWindowWithTitleText "i360 - Facebook Audience Tracking"
        describe "on i360 - Facebook Audience Tracking page ..."
        displayed "Facebook Audience Tracking"
        displayed "Start Date:"
        displayed "Start Date:"
        displayed "Client Organization:"
        displayed "Status:"

    "Stats Admin" &&& fun _ ->
        //url (portalUrl + "Admin/StatsAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Stats Admin"
        locateWindowWithTitleText "i360 - Usage Statistics Admin"
        describe "on i360 - Usage Statistics Admin page ..."
        displayed "Usage Statistics Admin"
        displayed "Start Date"
        displayed "End Date"

    "Usage Stats Report One" &&& fun _ ->
        //url (portalUrl + "Admin/rptUsageStats1.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Usage Stats Report One"
        locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed "Usage Statistics Report"
        displayed "Start Date"
        displayed "End Date"

    "Usage Stats Chart One" &&& fun _ ->
        //url (portalUrl + "Admin/rptUsageStatsChart1.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Usage Stats Chart One"
        locateWindowWithTitleText "i360 - Usage "
        describe "on i360 - Usage page ..."
        displayed "Usage"
        displayed "Graph Type"
        displayed "Graph Style"
        displayed "Graph Pallete"
        displayed "Width"
        displayed "Height"
        displayed "Start Date"
        displayed "End Date"

    "Metrics" &&& fun _ ->
        //url (portalUrl + "Admin/Metrics.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metrics"
        locateWindowWithTitleText "i360 - Metrics"
        describe "on i360 - Metrics page ..."
        displayed "Date Range Type"
        displayed "Metrics"
        displayed "Start"
        displayed "End"
        displayed "Type"

    "System Configuration" &&& fun _ ->
        //url (portalUrl + "Admin/SysCon.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "System Configuration"
        locateWindowWithTitleText "i360 - System Configuration"
        describe "on i360 - System Configuration page ..."
        displayed "System Configuration"

    "Mail Gun Reports" &&& fun _ ->
        //url (portalUrl + "Admin/MailGunReports.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Mail Gun Reports"
        locateWindowWithTitleText "i360 - Mail Gun Reports"
        describe "on i360 - Mail Gun Reports page ..."
        displayed "Mail Gun Reports"
        displayed "Gun Email Report"

    "Caching" &&& fun _ ->
        url (portalUrl + "Admin/CacheAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Caching"
        locateWindowWithTitleText "i360 - Caching"
        describe "on i360 - Caching page ..."
        displayed "Caching"
(*   
    //Pratibha: This URL takes to the Home page(search)
    "Hangfire Dashboard" &&& fun _ ->
        //url (portalUrl + "Admin/HangfireEnvSwitch.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Hangfire Dashboard"
        locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed ""
        displayed ""
        displayed ""
        displayed ""
*)
    "Analytics Poll" &&& fun _ ->
        url (portalUrl + "Admin/APollAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Analytics Poll"
        locateWindowWithTitleText "i360 - Analytics Poll Admin"
        describe "on i360 - Analytics Poll Admin page ..."
        displayed "Analytics Poll Admin"
        displayed "Poll Type:"

    "Analytics Poll Permissions" &&& fun _ ->
        //url (portalUrl + "Admin/APollPermissions.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Analytics Poll Permissions"
        locateWindowWithTitleText "i360 - Analytics Poll Permissions"
        describe "on i360 - Analytics Poll Permissions page ..."
        displayed "Analytics Poll Permissions"
        displayed "Select Poll:"

    "Search Page Sections" &&& fun _ ->
        url (portalUrl + "Admin/SearchSectionAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Page Sections"
        locateWindowWithTitleText "i360 - Search Section Administration"
        describe "on i360 - Search Section Administration page ..."
        displayed "Search Section Administration"

    "Search Page Detail" &&& fun _ ->
        //url (portalUrl + "Admin/SearchMetaData.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Page Detail"
        locateWindowWithTitleText "i360 - Search Metadata"
        describe "on i360 - Search Metadata page ..."
        displayed "Search Metadata"
        
    "Search Columns" &&& fun _ ->
        //url (portalUrl + "Admin/SearchColumnAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Columns"
        locateWindowWithTitleText "i360 - Search Column Administration"
        describe "on i360 - Search Column Administration page ..."
        displayed "Search Column Administration"

    "Search Column Groups" &&& fun _ ->
        //url (portalUrl + "Admin/SearchColGroupAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Column Groups"
        locateWindowWithTitleText "i360 - Search Col Group Admin"
        describe "on i360 - Search Col Group Admin page ..."
        displayed "Search Col Group Admin"

    "ACT DB Synchronization" &&& fun _ ->
        //url (portalUrl + "Admin/DatabaseAdminVol.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "ACT DB Synchronization"
        locateWindowWithTitleText "i360 - iVolunteer DB Admin"
        describe "on i360 - iVolunteer DB Admin page ..."
        displayed ""
        displayed ""
        displayed ""
        displayed ""

    "Database Admin" &&& fun _ ->
        //url (portalUrl + "Admin/DatabaseAdmin.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Database Admin"
        locateWindowWithTitleText "i360 - Database Admin"
        describe "on i360 - Database Admin page ..."
        displayed "Database Admin"

    "HzSc Connection Manager" &&& fun _ ->
        //url (portalUrl + "Admin/DataConnectionManagerReport.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "HzSc Connection Manager"
        locateWindowWithTitleText "i360 - Horizontal Scaling Connection Manager Report"
        describe "on i360 - Horizontal Scaling Connection Manager Report page ..."
        displayed "Horizontal Scaling Connection Manager Report"

    "Proc Pusher" &&& fun _ ->
        //url (portalUrl + "Admin/ProcPusher.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Proc Pusher"
        locateWindowWithTitleText "i360 - Proc Pusher"
        describe "on i360 - Proc Pusher page ..."
        displayed "Proc Pusher"

    "Proctopus" &&& fun _ ->
        //url (portalUrl + "Admin/Proctopus.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Proctopus"
        locateWindowWithTitleText "i360 - Proctopus"
        describe "on i360 - Proctopus page ..."
        displayed "Proctopus"

    "Canvass" &&& fun _ ->
        //url (portalUrl + "CanvassMonitor/CMH.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Canvass"
        locateWindowWithTitleText ""
        describe "on Login page ..."
        displayed "Canvassing Monitoring Home"
        displayed "Start Date"
        displayed "End Date"
        displayed "Active"
        displayed "Organization"
        displayed "Creator"

    "Style Guide" &&& fun _ ->
        //url (portalUrl + "Admin/StyleGuide.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Style Guide"
        locateWindowWithTitleText "i360 - Style Guide"
        describe "on i360 - Style Guide page ..."
        displayed "Accordians"

    "jqxGrid Demo" &&& fun _ ->
        //url (portalUrl + "Test/jqxGridDemo.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "jqxGrid Demo"
        locateWindowWithTitleText "i360 - jqxGrid Demo"
        describe "on i360 - jqxGrid Demo page ..."

    "Metric 1" &&& fun _ ->
        //url (portalUrl + "Test/Metric1.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metric 1"
        locateWindowWithTitleText "i360 - Metric 1"
        describe "on i360 - Metric 1 page ..."
        displayed "Metric 1"

    "Metric 2" &&& fun _ ->
        //url (portalUrl + "Test/Metric2.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Metric 2"
        locateWindowWithTitleText "i360 - Metric 2"
        describe "on i360 - Metric 2 page ..."
        displayed "Metric 2"

    "Test 1" &&& fun _ ->
        //url (portalUrl + "Test/Test1.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Test 1"
        locateWindowWithTitleText "i360 - Test 1"
        describe "on i360 - Test 1 page ..."
        displayed "Test 1"

    "Civic Information" &&& fun _ ->
        //url (portalUrl + "Admin/CivicInformation.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Civic Information"
        locateWindowWithTitleText "i360 - Civic Information"
        describe "on i360 - Civic Information page ..."
        displayed "Civic Information"

    "About i360" &&& fun _ ->
        //url (portalUrl + "About.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "About i360"
        locateWindowWithTitleText "i360 - About"
        describe "on i360 - About page ..."
        displayed "About"
        displayed "Development Team"
        displayed "Portal Information"

    "Contact i360" &&& fun _ ->
        //url (portalUrl + "Contact.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Contact i360"
        locateWindowWithTitleText "i360 - Contact i360"
        describe "on i360 - Contact i360 page ..."
        displayed "Contact i360"
        displayed "Your Account Rep"
        displayed "Main Phone"
        displayed "Main Email"

    "Help Request" &&& fun _ ->
        //url (portalUrl + "HelpRequest.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Help Request"
        locateWindowWithTitleText "i360 - Help Request"
        describe "on i360 - Help Request page ..."
        displayed "Help Request"
        displayed "Type:"
        displayed "Subject:"
        displayed "Request:"

    "Help Guides" &&& fun _ ->
        //url (portalUrl + "Help/HelpGuide.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Help Guides"
        locateWindowWithTitleText "i360 - "
        describe "on i360 -  page ..."
        displayed "Help Guides"

    "Release Notes" &&& fun _ ->
        //url (portalUrl + "ReleaseNotes.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Release Notes"
        locateWindowWithTitleText "i360 - i360 Portal Release Notes"
        describe "on i360 - i360 Portal Release Notes page ..."
        displayed "Release Notes"

    "Change Password" &&& fun _ ->
        //url (portalUrl + "Account/ChangePassword.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Change Password"
        locateWindowWithTitleText "i360 - Change Password"
        describe "on i360 - Change Password page ..."
        displayed "Change Password"
        displayed "Current password"
        displayed "i360 - Change Password"
        displayed "New password"
        displayed "Confirm new password"
        displayed "Password"
        displayed "Security question"
        displayed "Answer"

    "Reset Password" &&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PasswordReset.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Reset Password"
        locateWindowWithTitleText "i360 - Reset Password"
        describe "on i360 - Reset Password page ..."
        displayed "Reset Password"
        displayed "User Name:"

    "Switch Organizations" &&& fun _ ->
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Switch Organizations"
        locateWindowWithTitleText "Switch Organization"
        describe "on Switch Organization page ..."
        displayed "Organization"

    "Logout" &&& fun _ ->
        //url (portalUrl + "Logout.aspx") 
        click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Logout"
        locateWindowWithTitleText ""
        describe "on Login page ..."
