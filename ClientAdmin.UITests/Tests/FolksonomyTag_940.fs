module FolksonomyTag_940
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open OpenQA.Selenium

let core _ = 
    context "FolksonomyTag_940"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Folksonomy Tag Linking Page" &&&& fun _ ->
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Folksonomy Tag Linking"
        describe "on i360 - Folksonomy Tag Linking page ..."
        displayed "Folksonomy Tag Linking"

    "Folksonomy Tag Linking grid" &&&& fun _ ->
        describe "Portal - Accounts - Folksonomy Tag Linking Page - flows 1-6"
        describe "flows 1 begins ... "
        click "#ctl00_MainContent_cbxExclude"
        "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
        describe "flows 1 ends"
        describe "flows 2 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        sleep 20
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")

        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        sleep 20
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 2 ends"
        describe "flows 3 begins ... "
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << "AutomatedTest"
        press enter
        sleep 10
        contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        describe "flows 3 ends"

    "Folksonomy Tag Linking " &&&& fun _ ->

        describe "flows 4 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_DXFilterBar > tbody > tr > td.dxgvFilterBarClearButtonCell > a"
        sleep 20
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << "Select Folksonomy"
        press enter
        sleep 30
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")

        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        sleep 30
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 4 ends"
        describe "flows 5 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        press tab
        press tab
        click "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)"
        click "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)"

        press down
        press enter
        press tab
        let newFolksonomyLink = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)" 
        let TagCategory = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(3)"
        let Name = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(4)"
//        "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9) > div.dxgBCTC" << "AutomatedTest"
//        press enter

        contains newFolksonomyLink (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        sleep 20
        describe "Confirm Folksonomy Tag Linking " 
        click "Clear"
        sleep 10
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << TagCategory
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << Name
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << newFolksonomyLink   
        press enter
        sleep 10
        contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        describe "flows 5 ends"
        describe "flows 6 begins ..."
        click "#ctl00_MainContent_cbxOnlyShowUnassigned"
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << TagCategory
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << Name
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << newFolksonomyLink   
        press enter
        sleep 10
        contains newFolksonomyLink (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 6 ends"
        describe "Portal - Accounts - Folksonomy Tag Linking Page - flows 1-6 done ..."
//        describe "Portal - Accounts - Folksonomy Tag Linking Page - flows 7-12"

        describe "flows 7 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_DXFilterBar > tbody > tr > td.dxgvFilterBarClearButtonCell > a"
        click "#ctl00_MainContent_cbxExclude"
        click "#ctl00_MainContent_cbxOnlyShowUnassigned"
        "#ctl00_MainContent_ddlOrg" << cmbxOrg_I
        describe "flows 7 test case needs to be developed further..."
        describe "flows 7 ends"
        describe "flows 8 begins ... "
        click "Clear"
        sleep 20
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")

        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        sleep 20
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 8 ends"
        describe "flows 9 begins ... "
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << "AutomatedTest"
        press enter
        sleep 10
        contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        describe "flows 9 ends"

        describe "flows 10 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_DXFilterBar > tbody > tr > td.dxgvFilterBarClearButtonCell > a"
        sleep 20
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << "Select Folksonomy"
        press enter
        sleep 30
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")

        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        sleep 30
        contains "Select Folksonomy" (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 10 ends"
        describe "flows 11 begins ... "
        click "#ctl00_MainContent_ASPxGridView1_col9 > table > tbody > tr > td.dx-wrap"
        press tab
        press tab
        click "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)"
        click "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)"

        press down
        press enter
        press tab
        let newFolksonomyLink = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)" 
        let TagCategory = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(3)"
        let Name = read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(4)"
//        "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9) > div.dxgBCTC" << "AutomatedTest"
//        press enter

        contains newFolksonomyLink (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
        sleep 20
        describe "Confirm Folksonomy Tag Linking " 
        click "Clear"
        sleep 10
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << TagCategory
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << Name
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << newFolksonomyLink   
        press enter
        sleep 10
        contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1 > tbody > tr > td > div.dxgvCSD")
        describe "flows 11 ends"
        describe "flows 12 begins ..."
        click "#ctl00_MainContent_cbxOnlyShowUnassigned"
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I" << TagCategory
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I" << Name
        "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I" << newFolksonomyLink   
        press enter
        sleep 10
        contains newFolksonomyLink (read "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)")
        describe "flows 12 ends"
        describe "Portal - Accounts - Folksonomy Tag Linking Page - flows 7-12 done ..."