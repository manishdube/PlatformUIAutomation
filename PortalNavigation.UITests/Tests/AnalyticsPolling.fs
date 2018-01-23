module AnalyticsPolling
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open i360Lib

let core _ = 
    context "AnalyticsPolling"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "View Polls" &&&& fun _ ->
        //url (portalUrl + "Analytics/Poll/ViewPollM.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "View Polls"
//        //locateWindowWithTitleText "i360 - View Polls"
        describe "on i360 - View Polls page ..."
        displayed "View Polls"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"

    "Poll Aggregates Report" &&&& fun _ ->
        //url (portalUrl + "Analytics/Poll/rptPollAggregates.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Poll Aggregates Report"
//        //locateWindowWithTitleText "i360 - Poll Aggregates Report"
        describe "on i360 - Poll Aggregates Report page ..."
        displayed "Poll Aggregates Report"
        displayed "State"
        displayed "Race Type"
        displayed "Group Types"
        displayed "Source"

    "Poll Templates" &&&& fun _ ->
        //url (portalUrl + "Analytics/Poll/TemplatePoll.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Poll Templates"
//        //locateWindowWithTitleText "i360 - Poll Templates"
        describe "on i360 - Poll Templates page ..."
        displayed "Poll Templates"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"

    "Add New Poll" &&&& fun _ ->
        //url (portalUrl + "Analytics/Poll/AddPoll.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Add New Poll"
//        //locateWindowWithTitleText "i360 - Add New Poll"
        describe "on i360 - Add New Poll page ..."
        displayed "Add New Poll"
        displayed "Select Poll Template:"
        displayed "Race Type:"
        displayed "Visibility:"
        displayed "State:"

    "Edit Polls" &&&& fun _ ->
        //url (portalUrl + "Analytics/Poll/ViewPoll.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(5) > a"
        click "Edit Polls"
//        //locateWindowWithTitleText "i360 - Edit Polls"
        describe "on i360 - Edit Polls page ..."
        displayed "Edit Polls"
        displayed "State"
        displayed "Race Type"
        displayed "Released After"
        displayed "Released Before"