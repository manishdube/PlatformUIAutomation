module SwitchOrg_28289P2
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "SwitchOrg_28289P2"
    compareTimeout <- 30.0
    //once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Successfully Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "pkumar"
        setFieldValue "input[id='password']" "abcd1234"
        click "#Login1_Button1"

    "User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"  
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //url "https://test-portalv3.i-360.com/ClientAdmin/UserVer2/UserAdmin.aspx"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
       
    "Navigate to Roles Tab" &&&& fun _ ->
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << "All"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "pkumar"
        sleep 5
        doubleClick "#ctl00_MainContent_gvUsers_DXDataRow0"
        describe "done ..."

    "User Details: Look for the Role" &&&& fun _ ->
        displayed "User Details"
        click "Permissions"

        let mutable rolesUnAssigned = elements "#ctl00_MainContent_lbUnAssignedRoles > option" 
        for i = 0 to (rolesUnAssigned.Length-1) do
           let mutable rolesText = rolesUnAssigned.[i].Text
           if (rolesText = "Admin: Client Admin Multi-Org Access") then
                   describe "Admin: Client Admin Multi-Org Access is present in the Available to Assign"
                   click  rolesUnAssigned.[i]
               //    click "#ctl00_MainContent_btnAssignRoles"                   
           else
                   describe "Admin: Client Admin Multi-Org Access is NOT present in the Assigned to Client"
        describe "done ..."

    "Successfully Logout" &&&& fun _ ->
        url (portalUrl + "Logout.aspx")
        displayed "Sign In"
        displayed "Forgot?"
        displayed "Remember me?"
        describe "done ..."

    "Login Again" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "pkumar"
        setFieldValue "input[id='password']" "abcd1234"
        click "#Login1_Button1"
        describe "done ..."

    "Switch Oganization" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(5) > a" 
        click "#Menu2 > ul > li:nth-child(5) > a" 
        click "Switch Organizations"    
        switchToTab 2
        displayed "Organization" 
        "#cmbxOrg_I" << "SHIELD - Avengers"
        click "#btnxChgOrg_CD"
        switchToTab 1
        describe "done ..."

    "Check for change in org : User Admin" &&&& fun _ ->
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."
         
    "Check for change in org :Navigate to Roles Tab" &&&& fun _ ->
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << "All"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "pkumar"
        sleep 5
        doubleClick "#ctl00_MainContent_gvUsers_DXDataRow0"
        describe "done ..."

    "Check for change in org : Assert org change" &&&& fun _ ->
         displayed "User Details"
         contains "A" ( read "#ctl00_MainContent_FormView1_lblOrganization")
         describe "done ..."

    "Remove the permission" &&&& fun _ ->
         displayed "User Details"
         click "Permissions"
         
         let mutable rolesAssigned = elements "#ctl00_MainContent_lbAssignedRoles > option"
         let mutable flag = false 
         for i = 0 to (rolesAssigned.Length-1) do
              
              if (flag = false ) then  
                   let mutable rolesText = rolesAssigned.[i].Text             
                   if (rolesText = "Admin: Client Admin Multi-Org Access") then
                         describe "Admin: Client Admin Multi-Org Access is present in the Available to Assign"
                         click  rolesAssigned.[i]
                        // click "#ctl00_MainContent_btnUnAssignRoles"
                         flag <- true
                 
                   else
                         describe "Admin: Client Admin Multi-Org Access is NOT present in the Available to Assign"
         describe "done ..."
                                      
    "Switch back to Previous Oganization" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Switch Organizations"
        switchToTab 2
        "#cmbxOrg_I" << cmbxOrg_I
        press enter
        switchToTab 1
        describe "done ..."   