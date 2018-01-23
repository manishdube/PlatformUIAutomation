module MergeVoulunteerTags_944
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "MergeVoulunteerTags_944"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Merge Volunteer Tags" &&&& fun _ ->
        //url (portalUrl + "Accounts/AcctRep/MergeVolunteerTags.aspx")
        //click i360HomeLogo
        click "#Menu2 > ul > li:nth-child(3) > a"
        click "Merge Volunteer Tags"
        //locateWindowWithTitleText "i360 - Merge Volunteer Tags"
        describe "on i360 - Merge Volunteer Tags page ..."
        displayed "Merge Volunteer Tags"
        displayed "Tag to keep:"
        displayed "Tag to merge:"

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
