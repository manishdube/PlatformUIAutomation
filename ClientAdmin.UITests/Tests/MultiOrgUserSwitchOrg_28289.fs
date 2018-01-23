module MultiOrgUserSwitchOrg_28289
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "MultiOrgUserSwitchOrg_28289"
    compareTimeout <- 30.0
    //once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Successfully Login" &&&& fun _ ->
        url (portalUrl) 
        setFieldValue "input[id='username']" "pkumar"
        setFieldValue "input[id='password']" "abcd1234"
        click "#Login1_Button1"
        sleep 7

    "User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        sleep 3
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."

    "Navigate to Roles Tab" &&&& fun _ ->
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << cmbxOrg_I
        //click "#cmbxOrg_B-1"
        //let dd_cmbxOrg_I = elementWithText ".dxeListBoxItemRow" cmbxOrg_I
        //click dd_cmbxOrg_I 
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "pkumar"
        sleep 5
        doubleClick "#ctl00_MainContent_gvUsers_DXDataRow0"
        describe "done ..."

    "User Details: Look for the Role" &&&& fun _ ->
        displayed "User Details"
        click "Permissions"
//        while (((element "#ctl00_MainContent_lbUnAssignedRoles > option:nth-child(1)").Text) <> "Admin: Client Admin Multi-Org Access") do
//            click "#ctl00_MainContent_lbUnAssignedRoles > option:nth-child(1)"
//            click "#ctl00_MainContent_btnAssignRoles"
//            describe "Admin: Client Admin Multi-Org Access was NOT present in the | Available to Assign | row"

//            let mutable rolesUnAssigned = elements "#ctl00_MainContent_lbUnAssignedRoles > option" 
//            for i = 0 to (rolesUnAssigned.Length-1) do
//               let mutable rolesText = rolesUnAssigned.[i].Text
//               if (rolesText = "Admin: Client Admin Multi-Org Access") then
//                    describe "Admin: Client Admin Multi-Org Access is present in the Available to Assign"
//                    click "#ctl00_MainContent_lbAssignedRoles > option:nth-child(1)"
//                    click "#ctl00_MainContent_btnAssignRoles"
//               else
//                    describe "Admin: Client Admin Multi-Org Access is NOT present in the Available to Assign"


//        let mutable rolesUnAssigned = elements "#ctl00_MainContent_lbUnAssignedRoles > option" 
//        for i = 0 to (rolesUnAssigned.Length-1) do
//           let mutable rolesText = rolesUnAssigned.[i].Text
//           if (rolesText = "Admin: Client Admin Multi-Org Access") then
//                describe "Admin: Client Admin Multi-Org Access is present in the Available to Assign"
//                click "#ctl00_MainContent_lbAssignedRoles > option:nth-child(1)"
//                click "#ctl00_MainContent_btnAssignRoles"
//           else
//                describe "Admin: Client Admin Multi-Org Access is NOT present in the Available to Assign"
//
        describe "done ..."

    "Check for Switch Oganization" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(4) > a"
        notContains "Switch Organizations" (read "#Menu2 > ul > li:nth-child(4) > a")
        describe "done ..."