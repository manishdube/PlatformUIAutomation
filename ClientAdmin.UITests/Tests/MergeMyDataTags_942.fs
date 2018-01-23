module MergeMyDataTags_942
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "MergeMyDataTags_942"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Merge MyData Tags Page" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeContactTags.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge MyData Tags"
        //locateWindowWithTitleText "i360 - Merge MyData Tags"
        describe "on i360 - Merge MyData Tags page ..."
        displayed "Merge MyData Tags"
        displayed "Tag to Keep"
        displayed "Tag to Merge"

    "Merge Tags" &&&& fun _ ->
       let TagToKeepText = (element "#ctl00_MainContent_ddlTag > option:nth-child(1)").Text
       let TagToMergeText = (element "#ctl00_MainContent_ddlMergeTag > option:nth-child(2)").Text

       click "#ctl00_MainContent_ddlTag" 
       click "#ctl00_MainContent_ddlTag > option:nth-child(1)"

       click "#ctl00_MainContent_ddlMergeTag"
       click "#ctl00_MainContent_ddlMergeTag > option:nth-child(2)"

       click "#ctl00_MainContent_btnMerge"
       
       sleep 10
       notContains TagToMergeText (read "#ctl00_MainContent_ddlMergeTag")
       contains "Tags successfully merged" (read "#ctl00_MainContent_lblMsgX")
       describe "done ..."