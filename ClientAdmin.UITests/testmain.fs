module testmain
open canopy
open canopy.configuration
open canopy.reporters
open canopy.types
open runner
open etconfig
open etreporter
open summaryreporter
open commandlineargs
open System

let appName = AppDomain.CurrentDomain.FriendlyName.Replace(".exe", "")

let usage = "usage: {appName} [args]\n" +
            "where args is optional and can be a combination of the following:\n" +
            "    -Firefox (use Firefox browser*)\n" +
            "    -Chrome (use Chrome browser)\n" +
            "    -IE (use Internet Explorer browser)\n" +
            "    -WarmUp (run prepare both emma and dataport for testing*)\n" +
            "    -NoWarmUp (do NOT run prepare both emma and dataport for testing)\n" +
            "    -Log (create log file of results, use logFileTemplate entry in config.yaml to specify file name*)\n" +
            "    -NoLog (do NOT create log file of results)\n" +
            "    -TeamCity (create output for Team City, all other output OFF)\n" +
            "    -SqlInit (execute sql init file with parameters specified in config.yaml)\n" +
            "    -Dev (run only the dev test suite)\n" +
            "    -PressEnter (require entering return key at end of tests)\n" +
            "    -CoreOnly (Ignore any tests that are under construction)\n" +
            "    -Help or -? (display this usage text and run no tests)\n" +
            "parameters are not case sensitive\n" +
            "* default\n" +
            "running without specifying any args is equivalent to \"-Firefox -WarmUp -Log\"\n" +
            "test case parameters are specified in the \"config.yaml\" file\n" +
            "this file can be edited with notepad or any other text editor"

let configReporters (cla : CommandLineArgs) =
    if cla.teamCity then
        let teamCityReporter = new TeamCityReporter ()
        canopy.configuration.reporter <- new TeamCityReporter()
    else if cla.log then

        let executionTime =  DateTime.Now
        let dtString = executionTime.ToString "yyyy-MM-dd-HHmm"
        let logFileName = config.logFileTemplate.Replace("{dt}", dtString)
        let summaryFileName = config.summaryFileTemplate.Replace("{dt}", dtString)
//
//        let logReporter = new LogFileReporter (logFileName) :> IReporter
//        t.Add logReporter
//        logReporter.describe (sprintf "%s version %s" appName versioninfo.versionString)
//        logReporter.describe (sprintf "tests executed on %s %s" (executionTime.ToShortDateString()) (executionTime.ToShortTimeString()))
//        let browser = match cla.browser with
//                      | Firefox -> "Firefox"
//                      | Chrome -> "Chrome"
//                      | IE -> "IE"
//        logReporter.describe (sprintf "browser: %s" browser)
//        logReporter.describe "parameters:"
//        logReporter.write ("gatewayUrl: " + gatewayUrl)

//        let summaryReporter = new SummaryReporter (summaryFileName)
//        t.Add summaryReporter
//        summaryReporter.Info appName versioninfo.versionString executionTime browser ["gatewayUrl"; gatewayUrl]

//        let liveHtmlReporter = new LiveHtmlReporter ()
//        liveHtmlReporter.reportPath <- Some(config.htmlFileTemplate.Replace("{dt}", dtString))
//        t.Add liveHtmlReporter

        reporter <- new LiveHtmlReporter(BrowserStartMode.Chrome, AppDomain.CurrentDomain.BaseDirectory + @"\BrowserSupport") :> IReporter
        let liveHtmlReporter = reporter :?> LiveHtmlReporter
        liveHtmlReporter.reportPath <- Some(config.htmlFileTemplate.Replace("{dt}", dtString))

[<EntryPoint>]
let main argv =
    let cla = parseCommandLine argv
    if cla.versionOnly then
        printfn "%s" versioninfo.versionString
        0
    else if cla.showUsage || not cla.isValid then
        printfn "%s" (usage.Replace("{appName}", appName))
        -1
    else
        printfn "%s version %s" appName versioninfo.versionString

        configReporters cla
        chromeDir <- (AppDomain.CurrentDomain.BaseDirectory + @"\BrowserSupport")
        ieDir <- (AppDomain.CurrentDomain.BaseDirectory + @"\BrowserSupport")

//        for i = 0 to 10 do

//        ContactTagGroup_21664.core ()
//        TableauUsersPage962.core ()
//        OrganizationalTouchpoints10598.core ()
//        CancelNewUserCreation18281.core ()
//        OrganizationalPortalContent10424.core ()
//        CreateANewVolunteer_18415.core ()
//        UserAdminPositionSearchFilter_20158.core ()
//        UserReportClientOrg_28250.core ()
//        NewUserWithExistingUsername_27609.core ()
//        ChangeSecurityQuestion_6093.core ()
//        CreateANewUser_18262.core ()  
////        OrganizationalPortalContent_10424.core ()
//        MultiOrgUserSwitchOrg_28289.core ()
//        ShortCutToSwitchOrg28290.core ()
//        SwitchOrg_28289P2.core ()
//        ParentOrgAdminUsersCanViewChildOrgs_20254.core ()
//        VolunteerTagGroup_898.core ()
//        VolunteerDetails_18204.core ()
//        EditVolunteerDetails_18279.core ()
//        VolunteerChangeUsernamePassword_22115.core ()
//        AddVolunteerPermissions_22043.core ()
//        VolunteerDetails_Tags_18372.core () 
//        VolunteerDetailsPhoneType_25322.core ()
//        UserAdminNonePosition_18516.core ()
//        PositionAdministration_15508.core()
//        UsersInRoles_932.core ()
//        UserByClientOrg_934.core ()
//        OrderedSearchReportbyUser_938.core ()
//        BillingCallDetailsPage_920.core () 
//        BillingReportPage_916.core ()
//        BillingList_918.core ()
//        DynamicReporting_922.core ()
//        MergeMyDataTags_942.core ()
//        MergeVoulunteerTags_944.core ()
//        OrganizationalPageViews_949.core ()
//        OrganizationLookupData_995.core ()
//        AccountsSearchAdmin_952.core ()
//        AccountsParameterReport_958.core ()
//        FolksonomyTag_940.core ()
//        VolunteerData.core ()
//        OrganizationalLookupData_948.core ()
//        OrganizationalLookupData_36753.core ()
//        OrganizationalLookupData_36775.core ()
//        ClientOrganizationsPageFilters_18340.core ()
        nc4.core ()
        nsc.core ()
        BensMemuTest.core ()

        match cla.browser with
            | Firefox -> start firefox
            | Chrome -> start chrome
            | IE -> start ie

        browser.Manage().Window.Maximize()

        run()
        if cla.pressEnter then
            printfn "press [enter] to exit"
            System.Console.ReadLine() |> ignore
        quit()
        0
