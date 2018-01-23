module ShortCutToSwitchOrg28290
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open System.IO
open OpenQA.Selenium

let core _ = 
    context "ShortCutToSwitchOrg28290"
    compareTimeout <- 30.0
    lastly (fun _ -> portalLogout ()) 
    let cmbxOrg_I = cmbxOrg_I

    "Successfully Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "pkumar"
        setFieldValue "input[id='password']" "abcd1234"
        click "#Login1_Button1"
        sleep 5

    "User Admin" &&&& fun _ ->
        //url (portalUrl + "ClientAdmin/UserVer2/UserAdmin.aspx")
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
        describe "done ..."
   
    "Navigate to Roles Tab" &&&& fun _ ->
        click "#cmbxOrg_I"
        "#cmbxOrg_I" << cmbxOrg_I
        sleep 20
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
                click "#ctl00_MainContent_lbAssignedRoles > option:nth-child(1)"
           //     click "#ctl00_MainContent_btnAssignRoles"
           else
                describe "Admin: Client Admin Multi-Org Access is NOT present in the Assigned to Client"

        click "#ctl00_ctl16_imgMasterHdrLogo"
        sleep 10
        press Keys.LeftAlt
        press "S"

     //   SendKeys.Send("%S")
       
        
        //displayed 
        //SendKeys.Send("%S")
        //SendKeys.Send("%(fs)");
        //driver.findElement(By.xpath(id("anything")).sendKeys(Keys.CONTROL + "s");
        //element.send_keys(:control, 'S')

        describe "done ..."