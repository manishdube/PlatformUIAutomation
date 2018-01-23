module i360Lib
open System
open canopy
open canopy.configuration
open canopy.types
open etconfig
open OpenQA.Selenium

let login (userId : string) (password: string) =
    try
        url (portalUrl)
        "#username" << userId
        "#password" << password
        click "#Login1_Button1"
        displayed "Check the Wiki"
        sleep 7
    with
    | _ ->
        reporter.write "Portal Login Failed"

let portalLogout () =
    try
        sleep 3
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Logout"
    //    url (portalUrl + "Logout.aspx") 
        displayed "Sign In"
    //    displayed "Forgot?"
        displayed "Remember me?"
    with
    | _ ->
        reporter.write "Portal Logout failed"

let portalLogin () = login config.userId config.password
