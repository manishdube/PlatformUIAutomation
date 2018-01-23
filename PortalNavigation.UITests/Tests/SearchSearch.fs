module SearchSearch
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "SearchSearch"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Basic Search" &&&& fun _ ->
        //url (portalUrl + "Search/Search/StandardSearch.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"        
        click "#Menu1\3a submenu\3a 4 > li:nth-child(1) > a"
        click "#btnStartClose"
        //locateWindowWithTitleText "i360 - Basic Search"
        describe "on i360 - Basic Search page ..."
        //displayed "Basic Search"
        
    "Combined Searches" &&&& fun _ ->
        //url (portalUrl + "Search/Search/CombinedSearch.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "#Menu1\3a submenu\3a 4 > li:nth-child(2) > a"
        //locateWindowWithTitleText "i360 - Combined Searches"
        describe "on i360 - Combined Searches page ..."
        displayed "Combined Searches"
        displayed "Criteria"
        displayed "Overview"
        displayed "Find" 

(*
    "Export" &&&& fun _ ->
        //url (gatewayUrl + "Search/Search/SearchExport.aspx")
        click ".aliciasminions1"
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Export"
        click "#MainContent_gvxLoadSearches_DXDataRow0 > td:nth-child(4)"
        click "#btnLoad"
        click "#btnLegalAccept"
        click "#MainContent_lvChoice_lbtnChoice_1"
        //locateWindowWithTitleText "i360 - Export"
        describe "on i360 - Export page ..."
        displayed "Export"
*)

    "Individual i360 Search" &&&& fun _ ->
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Individual i360 Search"
        //locateWindowWithTitleText "i360 - Individual i360 Search"
        describe "on Individual i360 Search page ..."
        displayed "Individual i360 Search"
        displayed "Drag a column header here to group by that column"  
        displayed "State"
        displayed "First Name"
        displayed "Last Name"
        displayed "Birth Year"

    "MyData" &&&& fun _ ->
        //url (portalUrl + "Search/CRM/Contacts.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "MyData"
        //locateWindowWithTitleText "i360 - MyData"
        describe "on i360 - MyData page ..."
        displayed "MyData"
        displayed "Tag Checked"

    "Individual MyData Search" &&&& fun _ ->
        //url (portalUrl + "Search/Search/IndividualSearchContact.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Individual MyData Search"
        //locateWindowWithTitleText "i360 - Individual MyData Search"
        describe "on i360 - Individual MyData Search page ..."
        displayed "Individual MyData Search"
        displayed "State"
        displayed "Birth Year"
        displayed "City"
        displayed "Zip"
        displayed "Party"

    "Add Contact" &&&& fun _ ->
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Add Contact"
        //locateWindowWithTitleText "i360 - Contact Detail"
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

    "Last Contact" &&&& fun _ ->
        //url (portalUrl + "Search/CRM/ContactRedirect.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Last Contact"
//        //locateWindowWithTitleText "i360 - Contact Detail"
        describe "on i360 - Contact Detail page ..." 
//        displayed "Contact Details"
//        displayed "Contact Tags"
//        //displayed "Other Household Members"
//        displayed "Relationships"
//        displayed "Contact Notes"       
