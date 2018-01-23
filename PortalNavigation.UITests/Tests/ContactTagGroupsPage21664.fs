module ContactTagGroupsPage21664
open canopy
open runner
open etconfig
open lib
open System

let core _ = 
    context "ContactTagGroupsPage21664"
    elementTimeout <- 30.0
    pageTimeout <- 30.0

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

    "Basic Search" &&& fun _ ->
        //url (portalUrl + "Search/Search/StandardSearch.aspx")
        click i360HomeLogo
        click "Create New Group"        
        click "create group"
        click "#btnStartClose"
        locateWindowWithTitleText ""
        describe ""
        //displayed "Basic Search"

