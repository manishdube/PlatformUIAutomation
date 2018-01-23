module i360Lib
open System
open canopy
open canopy.configuration
open canopy.types
open etconfig
open etreporter
open OpenQA.Selenium

let login (userId : string) (password: string) =
    try
        url (portalUrl + "Logout.aspx")
        //https://test-portalv3.i-360.com/Logout.aspx
        displayed "Sign In"
    //    displayed "Forgot?"
        displayed "Remember me?"
        sleep 2 
        url (portalUrl) 
        //coverage (portalUrl)
        "#username" << userId
        "#password" << password
        click "#Login1_Button1"
        on (portalUrl)
        sleep 10
    with
    | _ ->
        reporter.write "Portal Login Failed"

let portalLogout () =
    try
        sleep 3
        url (portalUrl + "Logout.aspx")
        //https://test-portalv3.i-360.com/Logout.aspx
        displayed "Sign In"
     //   displayed "Forgot?"
        displayed "Remember me?"
    with
    | _ ->
        reporter.write "Portal Logout failed"

let portalLogin () = login config.userId config.password
