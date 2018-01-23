module AccountsAccounts
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsAccounts"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Dynamic Reporting" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/DynamicReporting.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Dynamic Reporting"
        //locateWindowWithTitleText "i360 - Dynamic Reporting"
        describe "on i360 - Dynamic Reporting page ..."

    "API Audit" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptAPIAudit.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "API Audit"
        //locateWindowWithTitleText "i360 - API Audit Report"
        describe "on i360 - API Audit Report page ..."
        displayed "API Audit Report"
        displayed "API Org:"
        displayed "API User:"
        displayed "URL:"

    "Folksonomy Tag Linking" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TagFolkAssc.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Folksonomy Tag Linking"
        //locateWindowWithTitleText "i360 - Folksonomy Tag Linking"
        describe "on i360 - Folksonomy Tag Linking page ..."
        displayed "Folksonomy Tag Linking"

    "Merge MyData Tags" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeContactTags.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge MyData Tags"
        //locateWindowWithTitleText "i360 - Merge MyData Tags"
        describe "on i360 - Merge MyData Tags page ..."
        displayed "Merge MyData Tags"
        displayed "Tag to Keep"
        displayed "Tag to Merge"

    "Merge Volunteer Tags" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeVolunteerTags.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge Volunteer Tags"
        //locateWindowWithTitleText "i360 - Merge Volunteer Tags"
        describe "on i360 - Merge Volunteer Tags page ..."
        displayed "Merge Volunteer Tags"
        displayed "Tag to keep:"
        displayed "Tag to merge:"

    "Client Organizations" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ClientOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Client Organizations"
        //locateWindowWithTitleText "i360 - Client Organizations"
        describe "on i360 - Client Organizations page ..."
        displayed "Client Organizations"

    "Client Geography" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ClientGeoAdmin.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Client Geography"
        //locateWindowWithTitleText "i360 - Client Geography Administration"
        describe "on i360 - Client Geography Administration page ..."
        displayed "Client Geography Administration"
        displayed "Select Client Organization:"

    "Organization Lookup Data" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        //locateWindowWithTitleText "i360 - Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"

    "Organization Page Views" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptOrgPageViews.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Page Views"
        //locateWindowWithTitleText "i360 - Organization Page Views"
        describe "on i360 - Organization Page Views page ..."
        displayed "Organization Page Views"
        displayed "Client Organization"

    "Empty Data Report" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/rptEmptyData.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Empty Data Report"
        //locateWindowWithTitleText "i360 - Empty Data Report"
        describe "on i360 - Empty Data Report page ..."
        displayed "Empty Data Report"
        displayed "Database"

    "Logo Upload" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/LogoUpload.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Logo Upload"
        //locateWindowWithTitleText "i360 - Logo Upload"
        describe "on i360 - Logo Upload page ..."
        displayed "Logo Upload"
        displayed "Select Image file to Upload:"
        
    "Election Admin" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ElectionAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Election Admin"
        //locateWindowWithTitleText "i360 - Election Admin"
        describe "on i360 - Election Admin page ..."
        displayed "Election Admin"

    "Imports Admin" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/Import/ImportAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Imports Admin"
        //locateWindowWithTitleText "i360 - Import Admin"
        describe "on i360 - Import Admin page ..."
        displayed "Imports Admin"

    "Survey Publishing Admin" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/SurveyPublishingAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Survey Publishing Admin"
        //locateWindowWithTitleText "i360 - Survey Publishing Admin"
        describe "on i360 - Survey Publishing Admin page ..."
        displayed "Survey Publishing Admin"

    "Observation Clusters" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ObservationClusters.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Observation Clusters"
        //locateWindowWithTitleText "i360 - Observation Cluster Administration"
        describe "on i360 - Observation Cluster Administration page ..."
        displayed "Observation Cluster Administration"
      
    "External Data Sync" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/ExternalDataSync.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "External Data Sync"
        //locateWindowWithTitleText "i360 - External Data Synchronization"
        describe "on i360 - External Data Synchronization page ..."
        displayed "External Data Synchronization"

    "PD Config" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PDConfigAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "PD Config"
        //locateWindowWithTitleText "i360 - PD Config Admin"
        describe "on i360 - PD Config Admin page ..."
        displayed "PD Config Admin"
        displayed "Environment:"
        displayed "Server:"
