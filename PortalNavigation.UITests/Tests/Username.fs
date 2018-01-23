module Username
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "Username"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "About i360" &&&& fun _ ->
        //url (portalUrl + "About.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "About i360"
        //locateWindowWithTitleText "i360 - About"
        describe "on i360 - About page ..."
        displayed "About"

    "Contact i360" &&&& fun _ ->
        //url (portalUrl + "Contact.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Contact i360"
        //locateWindowWithTitleText "i360 - Contact i360"
        describe "on i360 - Contact i360 page ..."
        displayed "Contact i360"
        displayed "Your Account Rep"
        displayed "Main Phone"
        displayed "Main Email"

(*
    "Help Request" &&&& fun _ ->
        //url (portalUrl + "HelpRequest.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Help Request"
        //locateWindowWithTitleText "i360 - Help Request"
        describe "on i360 - Help Request page ..."
        displayed "Help Request"
        displayed "Type:"
        displayed "Subject:"
        displayed "Request:"
*)

//    "Help Guides" &&&& fun _ ->
//        //url (portalUrl + "Help/HelpGuide.aspx") 
//        //click i360HomeLogo
//        click "#Menu2 > ul > li:nth-child(5) > a"
//        click "Help Guides"
//        //locateWindowWithTitleText "i360 -"
//        describe "on i360 - page ..."
//        displayed "Help Guides"

    "Release Notes" &&&& fun _ ->
        //url (portalUrl + "ReleaseNotes.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Release Notes"
        //locateWindowWithTitleText "i360 - i360 Portal Release Notes"
        describe "on i360 - i360 Portal Release Notes page ..."
        displayed "Release Notes"

    "Change Password" &&&& fun _ ->
        //url (portalUrl + "Account/ChangePassword.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Change Password"
        //locateWindowWithTitleText "i360 - Change Password"
        describe "on i360 - Change Password page ..."
        displayed "Change Password"
        displayed "Current password"
        displayed "New password"
        displayed "Confirm new password"
        displayed "Password"
        displayed "Security question"
        displayed "Answer"

    "Reset Password" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PasswordReset.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Reset Password"
        //locateWindowWithTitleText "i360 - Reset Password"
        describe "on i360 - Reset Password page ..."
        displayed "Reset Password"
        displayed "User Name:"

    "Switch Organizations" &&&& fun _ ->
        ////click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(4) > a"
        click "Switch Organizations"
        //locateWindowWithTitleText "Switch Organization"
        describe "on Switch Organization page ..."
//        displayed "Organization"
