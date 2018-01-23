module AccountsAnalytics
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "AccountsAnalytics"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

    "Tableau Admin" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TableauAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Tableau Admin"
        //locateWindowWithTitleText "i360 - Tableau Administration"
        describe "on i360 - Tableau Administration page ..."
        displayed "Tableau Administration"

    "Tableau Organizations" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/TableauOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Tableau Organizations"
        //locateWindowWithTitleText "i360 - Tableau Organizations"
        describe "on i360 - Tableau Organizations page ..."
        displayed "Tableau Organizations"

    "Pyramid Admin" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/PyramidAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Pyramid Admin"
        //locateWindowWithTitleText "i360 - Pyramid Administration"
        describe "on i360 - Pyramid Administration page ..."
        displayed "Pyramid Administration"
