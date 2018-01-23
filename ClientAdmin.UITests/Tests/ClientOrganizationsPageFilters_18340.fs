module ClientOrganizationsPageFilters_18340
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open FSharp.Data

let core _ = 
    context "ClientOrganizationsPageFilters_18340"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let  availableDataText = new System.Collections.Generic.List<string>()
    let  availableSearchBox = ["#ctl00_MainContent_ASPxGridView1_DXFREditorcol1_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol2_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol4_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol7_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol8_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol9_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol10_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol11_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol12_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol13_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol6_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol5_I";
                               "#ctl00_MainContent_ASPxGridView1_DXFREditorcol3_I"
                               ]

    "Client Organizations Page" &&&& fun _ ->

        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Client Organizations"
        describe "on i360 - Client Organizations page ..."
        displayed "Client Organizations"

    "Client Organizations Page Filter tests" &&&& fun _ ->

        let  menuItem = ["Id";
                         "Organization";
                         "Header Image";
                         "Parent";
                         "Client DB";
                         "Primary Acct Rep";
                         "DB Only";
                         "Active";
                         "Server";
                         "Max Rows";
                         "Welcome Text";
                         "Main Image";
                         "Welcome Image"]

        //let  mutable newItem1 = new System.Collections.Generic.List<string>()

        for j = 0 to menuItem.Length-1 do
            try
            click menuItem.[0]
            click menuItem.[0]
            sleep 5
            for i = 0 to j+1 do
                press tab
            click availableSearchBox.[j]

            click menuItem.[j]
            sleep 5
            click menuItem.[j]
            sleep 5
//            let dataRow0element = "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(" + (j+3).ToString() + ")"
//
//            availableDataText.Add((element dataRow0element).Text)


            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(3)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(4)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(5)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(6)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(7)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(8)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(9)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(10)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(11)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(12)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(13)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(14)").Text)
            availableDataText.Add((element "#ctl00_MainContent_ASPxGridView1_DXDataRow0 > td:nth-child(15)").Text)

            sleep 10
            if (j = 3 ||j = 5 || j = 6 || j = 7 || j = 8 || j = 9 ) then
                describe "dd item ..."
            else
                availableSearchBox.[j] << "random deliberate bad filter search"
                press enter
                sleep 10
                //click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
                contains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")

            clear availableSearchBox.[j]
            press enter

//            if (j = 9 ||j = 10 || j = 11 || j = 12 ) then
//                describe "out of range item ..."
//                for i = j to 12 do
//                    press tab
//                click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
//            else
//                click "#ctl00_MainContent_ASPxGridView1_DXCBtn0"
//            
//            sleep 10
//            notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")

//            click menuItem.[0]
//            for i = 1 to j do
//                press tab
            click availableSearchBox.[j]
            availableSearchBox.[j] << availableDataText.[j]
            sleep 5
//            availableDataText.Clear()
            press enter
            sleep 10
            notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")

            clear availableSearchBox.[j]
            press enter

            if j < 3 then
                availableSearchBox.[j] << availableDataText.[j]
                sleep 5
                press enter
                sleep 5
                availableSearchBox.[j+2] << availableDataText.[j+2]
                press enter
                sleep 5
                notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")

             else if j >= 3 && j < menuItem.Length-1 then
                availableSearchBox.[j] << availableDataText.[j]
                sleep 5
                press enter
                sleep 5
                availableSearchBox.[j-2] << availableDataText.[j-2]
                press enter
                sleep 5
                notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")
            else
                availableSearchBox.[j] << availableDataText.[j]
                sleep 5
                press enter
                sleep 5
                availableSearchBox.[j-1] << availableDataText.[j-1]
                press enter
                sleep 5
                notContains "No data to display" (read "#ctl00_MainContent_ASPxGridView1")

//            clear availableSearchBox.[j]
//            clear availableSearchBox.[j-1]
//            press enter
//
//            sleep 5
            availableDataText.Clear()
            let NegativeTestsSearchBoxPassed        = "  -ve search tests for "     + menuItem.[j].ToString() + " search box passed <-------------------------"
            let PositiveTestsSearchBoxPassed        = "  +ve search tests for "     + menuItem.[j].ToString() + " search box passed <-------------------------"
            let PositiveComboTestsSearchBoxPassed   = "combo search tests for "     + menuItem.[j].ToString() + " search box passed <-------------------------"
            let SortingTestsSearchBoxPassed         = "     sorting tests for "     + menuItem.[j].ToString() + " search box passed <-------------------------"
            
            describe NegativeTestsSearchBoxPassed
            describe PositiveTestsSearchBoxPassed
            describe PositiveComboTestsSearchBoxPassed
            describe SortingTestsSearchBoxPassed
            sleep 5
            click "#Menu2 > ul > li:nth-child(3) > a"
            click "Client Organizations"
            with
            | _ ->
                reporter.write "failures seen"
                availableDataText.Clear()
                click "#Menu2 > ul > li:nth-child(3) > a"
                click "Client Organizations"
                describe "on i360 - Client Organizations page ..."
                displayed "Client Organizations"
             
//            sleep 5
//            describe "Client Organizations Page Filter tests done ..." 

