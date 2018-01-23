module OrganizationalLookupData_948
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalLookupData_948"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let newItem = getRandomString (25)
    let newItemChanged = "Automated Test changed"

    "Organization Lookup Data save newItem and grid tests" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"
        
        let ddlength = (elements "#ctl00_MainContent_ddlRefOrgType > option").Length
        for i = 0 to 0 do
          try
//              portalLogout ()
//              portalLogin ()
              click "#Menu2 > ul > li:nth-child(3) > a"
              click "Organization Lookup Data"
              
              click (elements "#ctl00_MainContent_ddlRefOrgType > option").[i]
              "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << "RandomValue"
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
              sleep 5
              contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
              sleep 5
              clear "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
              "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItem
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
              sleep 5
              contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
              sleep 5
              clear "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
              sleep 5
              click "#ctl00_MainContent_ASPxGridView1_header0_btnNew"
              "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor3_I" << newItem
              click "Save"
              sleep 5
              notContains "Cancel" (read "#ctl00_MainContent_ASPxGridView1")
              "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItem
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn1"
              sleep 5
              click "#ctl00_MainContent_ASPxGridView1_DXFilterRow > td.dxgvCommandColumn.dxgv"
              sleep 5
              "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor3_I" << newItemChanged
              click "Save"
              sleep 5
              notContains "Cancel" (read "#ctl00_MainContent_ASPxGridView1")
              "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItemChanged
              sleep 5
              notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn2"
              acceptAlert()
              clear "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
              describe "done ..." 
          with
          | _ ->
              reporter.write "Saving New item failed"