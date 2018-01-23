module SearchImporting
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "SearchImporting"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Import" &&&& fun _ ->
        //url (portalUrl + "Import/Imports.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Import"
        //locateWindowWithTitleText "i360 - Imports"
        describe "on i360 - Imports page ..." 
        displayed "Imports Home"
        displayed "Click on a row to view more information in the review section below."
        displayed "Status Legend:"
        //displayed "My Imports Only"
        displayed "Import Name"
        displayed "New Import"
        displayed "By"
        displayed "Previous"

    "Tag-Phone Import" &&&& fun _ ->
        //url (portalUrl + "Import/PhoneTagImport.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(2) > a"
        click "Tag-Phone Import" 
        //locateWindowWithTitleText "i360 - Phone Tag Import"
        describe "on i360 - Phone Tag Import page ..."
        displayed "Phone Tag Import"
        displayed "Telephone Numbers"
        displayed "Notes:"
        displayed "Category:"

    "Logout" &&&& fun _ ->
        url (portalUrl + "Logout.aspx") 
       
