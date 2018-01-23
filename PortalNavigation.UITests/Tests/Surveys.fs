module Surveys
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "Surveys"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Survey Home" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/SurveySelect.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Survey Home"
        //locateWindowWithTitleText "i360 - Select a Survey"
        describe "on i360 - Select a Survey page ..."
        displayed "Select a Survey"
        displayed "Create a new survey"

    "List Survey Volunteers" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/rptSurveyVolunteers.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "List Survey Volunteers"
        //locateWindowWithTitleText "i360 - List Survey Volunteers"
        describe "on i360 - List Survey Volunteers page ..."
        displayed "List Survey Volunteers"
        displayed "Survey:"
(*        
    "Predictive Dialer Link" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/PDLink.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Predictive Dialer Link"
        //locateWindowWithTitleText "i360 - Predictive Dialer Link"
        describe "on i360 - Predictive Dialer Link page ..."
        displayed "Predictive Dialer Link"
        displayed "Click to go to the Predictive Dialer login form:"
*)

    "Load Paper Walkbook Results" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/ILink.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Load Paper Walkbook Results"
        //locateWindowWithTitleText "Paper Walkbook Ingestion"
        describe "on Paper Walkbook Ingestion page ..."
//        displayed "Welcome to the walkbook data return site."


    "Canvassing Report" &&&& fun _ ->
        portalLogout ()
        portalLogin ()
        //url (portalUrl + "SurveyV2/Reports/CanvassingReportSurveySelect.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Canvassing Report"
        //locateWindowWithTitleText "i360 - Canvassing Report"
        describe "on i360 - Canvassing Report page ..."
        displayed "Canvassing Report"
        displayed "Select a Survey"
        displayed "Client Organization:"


    "PD Admin" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/PDAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "PD Admin"
        //locateWindowWithTitleText "i360 - PD Admin"
        describe "on i360 - PD Admin page ..."

    "Call Admin" &&&& fun _ ->
        //url (portalUrl + "SurveyV2/CallAdminSwitch.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(4) > a"
        click "Call Admin"
        //locateWindowWithTitleText "i360 - Call Admin"
        describe "on i360 - Call Admin page ..."
        displayed "Call Admin"
        displayed "Status Filter"