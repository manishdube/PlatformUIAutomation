module AccountsUsersAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsUsersAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "User Groups" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/UserGroups.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "User Groups"
        //locateWindowWithTitleText "i360 - User Groups"
        describe "on i360 - User Groups page ..."
        displayed "User Groups"
        displayed "Select a Group"

    "Query Constraints" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/QueryConstraints.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Query Constraints"
        //locateWindowWithTitleText "i360 - Query Constraints"
        describe "on i360 - Query Constraints page ..."
        displayed "Query Constraints"
        displayed "User"
        displayed "Query Type"
        displayed "State"

    "Look Up Password" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/Impersonate.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Look Up Password"
        //locateWindowWithTitleText "i360 - Look Up Password"
        describe "on i360 - Look Up Password page ..."
        displayed "Look Up Password"
        displayed "Select User to Impersonate"
        displayed "Select Organization"
        displayed "New Organization Wide Password"

    "Delete Contacts" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/DeleteContacts.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Delete Contacts"
        //locateWindowWithTitleText "i360 - Delete Contacts"
        describe "on i360 - Delete Contacts page ..."
        displayed "Delete Contacts"
