module OrganizationalLookupData_36775
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "OrganizationalLookupData_36775"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())

//    let  newItem = [getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20);getRandomString (20)]

    let  mutable newItem1 = new System.Collections.Generic.List<string>()


    "Organization Lookup Data pagination tests" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/RefOrgAdmin.aspx") 
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Organization Lookup Data"
        describe "on i360 - Organization Lookup Data page ..."
        displayed "Organization Lookup Data"
        
        let ddlength = (elements "#ctl00_MainContent_ddlRefOrgType > option").Length
        for i = 0 to 0 do
            click (elements "#ctl00_MainContent_ddlRefOrgType > option").[i]
        //    let  newItem = getRandomString (10)
            for j = 0 to 10 do
              try
                newItem1.Add(getRandomString (20))
                click "#ctl00_MainContent_ASPxGridView1_header0_btnNew"
                "#ctl00_MainContent_ASPxGridView1_DXEFL_DXEditor3_I" << newItem1.[j]
                click "Save"
                sleep 10
                notContains "Cancel" (read "#ctl00_MainContent_ASPxGridView1")
                "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItem1.[j]
                click "#ctl00_MainContent_ASPxGridView1_DXFilterRow > td.dxgvCommandColumn.dxgv"
                sleep 5
                notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
                describe "done ..." 
              with
              | _ ->
                  reporter.write "Saving New item failed"
             
            click "#ctl00_MainContent_ASPxGridView1_DXPagerBottom > a:nth-child(4)"
            sleep 5
            click "#ctl00_MainContent_ASPxGridView1_DXPagerBottom > a:nth-child(3)"
            sleep 5
            describe "paging tests done ..." 

            for j = 0 to 10 do

                "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << newItem1.[j]
                click "#ctl00_MainContent_ASPxGridView1_DXFilterRow > td.dxgvCommandColumn.dxgv"
                sleep 5
                notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
                click "#ctl00_MainContent_ASPxGridView1_DXCBtn2"
                acceptAlert()
                clear "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
                describe "done ..." 
