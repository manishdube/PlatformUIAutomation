module GrassrootsVolunteerTagAdmin
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "GrassrootsVolunteerTagAdmin"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Volunteer Tags" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VtagAdmin.aspx")
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Tags"
        //locateWindowWithTitleText "i360 - Volunteer Tags"
        describe "on i360 - Volunteer Tags page ..."
        displayed "Volunteer Tags"

    "Volunteer Categories" &&&& fun _ ->
        //url (portalUrl + "Grassroots/Volunteers/VCatAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu1 > ul > li:nth-child(3) > a"
        click "Volunteer Categories"
        //locateWindowWithTitleText "i360 - Volunteer Categories"
        describe "on i360 - Volunteer Categories page ..."
        displayed "Volunteer Categories"