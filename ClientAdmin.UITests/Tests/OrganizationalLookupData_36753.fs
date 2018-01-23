module OrganizationalLookupData_36753
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalLookupData_36753"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let newItem = getRandomString (25)

    "Organization Lookup Data save newItem tests" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"
        
        let ddlength = (elements "#ctl00_MainContent_ddlRefOrgType > option").Length
        for i = 0 to ddlength do
          try
//              portalLogout ()
//              portalLogin ()
              click "#Menu2 > ul > li:nth-child(3) > a"
              click "Organization Lookup Data"
              
              click (elements "#ctl00_MainContent_ddlRefOrgType > option").[i]
              click "#ctl00_MainContent_ASPxGridView1_header0_btnNew"
              "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor3_I" << newItem 
              click "Save"
              sleep 5
              "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItem
              click "#ctl00_MainContent_ASPxGridView1_DXFilterRow > td.dxgvCommandColumn.dxgv"
              sleep 5
              notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
              click "#ctl00_MainContent_ASPxGridView1_DXCBtn2"
              acceptAlert()
              clear "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
              describe "done ..." 
          with
          | _ ->
              reporter.write "Saving New item failed"
