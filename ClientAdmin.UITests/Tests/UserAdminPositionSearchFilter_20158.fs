module UserAdminPositionSearchFilter_20158
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "UserAdminPositionSearchFilter_20158"
    compareTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."

    "Position Column" &&&& fun _ ->
        doubleClick "#gvShowFilters"
        click "#ctl00_MainContent_gvUsers_DXFREditorcol9_I"
        contains "None" (read "#ctl00_MainContent_gvUsers_DXFREditorcol9_DDD_L_LBT")
        contains "Field Staff" (read "#ctl00_MainContent_gvUsers_DXFREditorcol9_DDD_L_LBI1T0")
//        contains "Field Manager" (read "#ctl00_MainContent_gvUsers_DXFREditorcol9_DDD_L_LBI2T0")
//        contains "State Director" (read "#ctl00_MainContent_gvUsers_DXFREditorcol9_DDD_L_LBI3T0")   
        click "#ctl00_MainContent_gvUsers_DXFREditorcol20_I"
        contains "Active" (read "#ctl00_MainContent_gvUsers_DXFREditorcol20_DDD_L_LBI0T0")
        contains "Inactive" (read "#ctl00_MainContent_gvUsers_DXFREditorcol20_DDD_L_LBI1T0")
        describe "done ..."