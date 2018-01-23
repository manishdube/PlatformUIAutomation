module InternalMetadata
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "InternalMetadata"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Search Page Sections" &&&& fun _ ->
        //url (portalUrl + "Admin/SearchSectionAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Page Sections"
        //locateWindowWithTitleText "i360 - Search Section Administration"
        describe "on i360 - Search Section Administration page ..."
        displayed "Search Section Administration"

    "Search Page Detail" &&&& fun _ ->
        //url (portalUrl + "Admin/SearchMetaData.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Page Detail"
        //locateWindowWithTitleText "i360 - Search Metadata"
        describe "on i360 - Search Metadata page ..."
        displayed "Search Metadata"
        
    "Search Columns" &&&& fun _ ->
        //url (portalUrl + "Admin/SearchColumnAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Columns"
        //locateWindowWithTitleText "i360 - Search Column Administration"
        describe "on i360 - Search Column Administration page ..."
        displayed "Search Column Administration"

    "Search Column Groups" &&&& fun _ ->
        //url (portalUrl + "Admin/SearchColGroupAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Search Column Groups"
        //locateWindowWithTitleText "i360 - Search Col Group Admin"
        describe "on i360 - Search Col Group Admin page ..."
        displayed "Search Col Group Admin"
