open canopy
open runner
open System
open configuration
open reporters
open FSharp.Data
open System.IO
open System.Net.Mime

chromeDir <- "C:\\SeleniumDrivers\\"

//start an instance of the chrome browser
start chrome
browser.Manage().Window.Maximize()

[<Literal>]
let path = @"testData.csv"
type Stocks = CsvProvider<path>

//let stocks = Stocks.Load(new StreamReader(path))
//
//let firstRow = stocks.Rows |> Seq.head
//let lastDate = firstRow.FirstName
//let lastOpen = firstRow.Open

// Download the stock prices
let msft = Stocks.Load(new StreamReader(path))

// Look at the most recent row. Note the 'Date' property
// is of type 'DateTime' and 'Open' has a type 'decimal'
let firstRow = msft.Rows |> Seq.head
let FirstName = firstRow.FirstName
let Open = firstRow.Open
let High = firstRow.High
let Low = firstRow.Low
let Close = firstRow.Close
let Volume = firstRow.Volume
let AdjClose = firstRow.AdjClose

printfn "A string: %s" "Hello"

// Print the prices in the HLOC format

for row in msft.Rows do
  //printfn "HLOC: (%A, %A, %A, %A)" row.High row.Low row.Open row.Close
  url ("https://test-login.i-360.com/core/login?")
  printfn "A string: %s" "Hello"
  "input[id='username']" << row.High.ToString()
  "input[id='password']" << row.Low.ToString()

//for row in msft.Rows do
//        url (https://test-login.i-360.com/core/login?)
//        //describe "on Login page ..."
//        "input[id='username']" << username
//        "input[id='password']" << password
//        click "input[id='Login1_Button1']"
//        //locateWindowWithTitleText "i360 - Home Page"
//        describe "on i360 - Home Page page ..."
//        displayed "Quick Links"
//        //url (portalUrl + "ClientAdmin/UserVer2/UserAdmin.aspx")
//        //click i360HomeLogo
//        click "#Menu2 > ul > li:nth-child(2) > a"
//        click "User Admin"
//        //locateWindowWithTitleText "i360 - User Admin"
//        describe "on i360 - User Admin page ..."
//        displayed "User Admin"
//        displayed "Select Organization:"
//        click "#ctl00_MainContent_btnNew"
//        printfn "HLOC: (%A, %A, %A, %A)" row.High row.Low row.Open row.Close

  //printfn "HLOC: (%d, %d, %d, %d)" Open High Low Close

let sample = Http.RequestString
                ("https://dev-internalapi.i-360.com/1.0/Synchronization/CreateAndStart/2894", 
                    headers = [ "Content-Type", HttpContentTypes.Json ], body = TextRequest """  { "SyncConfigId": 1, "Name": "Afp Volunteer Synchronization", "Description": "Create Sync From Chrome ARC", "SyncDirection": 1, "NotificationEmailAddresses": "mdube@i-360.com" } """)

reporter <- new LiveHtmlReporter(BrowserStartMode.Chrome, AppDomain.CurrentDomain.BaseDirectory + @"\BrowserSupport") :> reporters.IReporter

// Logging in
"Radial Insight Admin login" &&& fun _ ->
    //go to url
    url "https://admin.radialinsight.com"

    // Assert on login page
    ".body-content h2" == "Log in."

    // Enter credentials and click login button
    "#MainContent_UserName" << "slugo"
    "#MainContent_Password" << "081780"
    click(".btn-default")

    // Assert on home page
    ".jumbotron h1" == "Panel Acquisition Home"

//// Adding a campaign
//"Radial Insight Admin - add campaign" &&& fun _ ->
//    // Click Campaign menu item
//    click("#ctl01 > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li:nth-child(1) > a")
//
//    // Click Campaign Admin menu item
//    click("#ctl01 > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li.dropdown.open > ul > li:nth-child(1) > a")
//
//    // Assert on campaign admin page
//    "#ctl01 > div.container.body-content > h2" == "Campaign Administration"
//
//    // Click last page on grid
//    click("#MainContent_ASPxGridView1_DXPagerBottom > a:nth-child(13)")
//
//    // Click the add campaign button
//    click("#MainContent_ASPxGridView1_DXCBtn0")
//
//    // Assert popup modal visible
//    displayed "#MainContent_ASPxGridView1_DXPEForm_PW-1"
//
//    // Enter title
//    "#MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor2_I" << "Regression Test Campaign"
//
//    // Enter start date
//    "#MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor4_I" << DateTime.Now.ToString("MM/dd/yyyy")
//
//    // Enter end date
//    "#MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor5_I" << DateTime.Now.AddDays(10.0).ToString("MM/dd/yyyy")
//
//    // Select organization
//    click("#MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor7_I")
//    click("#MainContent_ASPxGridView1_DXPEForm_DXEFL_DXEditor7_DDD_L_LBI0T0")
//
//    // Click save button
//    click("#MainContent_ASPxGridView1_DXPEForm_DXEFL_7 > div > a:nth-child(1)")
//
//    // Click last page in grid again (in case a new page has been added)
//    //click("#MainContent_ASPxGridView1_DXPagerBottom > a:nth-child(13)")
//
//    // Assert campaign added by checking last row in grid
//    "#MainContent_ASPxGridView1_DXMainTable > tbody > tr:last-child > td:nth-child(4)" == "Regression Test Campaign"
//
//// Clone campaign
//"Radial Insight Admin - clone campaign" &&& fun _ ->
//    let campaignIdStr = read "#MainContent_ASPxGridView1_DXMainTable > tbody > tr:last-child > td:nth-child(3)"
//    let campaignId = campaignIdStr |> int
//    let clonedCampaignIdStr = (campaignId + 1).ToString()
//    click("#MainContent_ASPxGridView1_DXMainTable > tbody > tr:last-child > td:nth-child(2) > a:nth-child(3)")
//    "#MainContent_ASPxGridView1_DXMainTable > tbody > tr:last-child > td:nth-child(3)" == clonedCampaignIdStr

//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()