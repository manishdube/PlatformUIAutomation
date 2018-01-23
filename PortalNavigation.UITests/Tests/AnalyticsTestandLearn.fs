module AnalyticsTestandLearn
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AnalyticsTestandLearn"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Upload Documents" &&&& fun _ ->
        //url (portalUrl + "Analytics/Docs/DocsM.aspx") 
        //click i360HomeLogo
        click "Analytics"
//        click "//*[@id='Menu1:submenu:75']/li[1]/a"
//        //locateWindowWithTitleText "i360 - Test and Learn: Upload Documents"
        describe "on i360 - Test and Learn: Upload Documents page ..."
//        displayed "Test and Learn: Upload Documents"
//        displayed "Poll Date:"
//        displayed "Description:"
//        displayed "Tags:"

    "View Documents" &&&& fun _ ->
        //url (portalUrl + "Analytics/Docs/EditDocsM.aspx") 
        //click i360HomeLogo
        click "Analytics"
//        click "//*[@id='Menu1:submenu:76']/li[2]/a"
//        //locateWindowWithTitleText "i360 - Test and Learn: View Documents"
        describe "on i360 - Test and Learn: View Documents page ..."
//        displayed "Test and Learn: View Documents"