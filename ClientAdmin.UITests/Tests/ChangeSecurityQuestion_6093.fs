module ChangeSecurityQuestion_6093
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "ChangeSecurityQuestion_6093"
    elementTimeout <- 30.0
    let user = "Dube, Manish"
    once (fun _ -> portalLogin ())
    lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

       
    "Navigate to Change Password Page" &&&& fun _ ->
        //url (portalUrl + "Account/ChangePassword.aspx") 
//        click "#ctl15_imgMasterHdrLogo"
        click "#Menu2 > ul > li:nth-child(5) > a"
        click "Change Password"
        locateWindowWithTitleText "i360 - Change Password"
        describe "on i360 - Change Password page ..."
        displayed "Change Password"
        displayed "Current password"
        displayed "New password"
        displayed "Confirm new password"
        displayed "Password"
        displayed "Security question"
        displayed "Answer"
        describe "done ..."

    "Change Security Question" &&&& fun _ ->
        "#MainContent_PasswordTextbox" << password
        "#QuestionTextbox" << "What is the name of my first pet?"
        "#AnswerTextbox" << "Tweety"
        click "#MainContent_ChangePasswordQuestionButton"
        contains "Security question and answer changed." (read "#MainContent_Msg")
        describe "done ..."
        portalLogout ()

    "Test Security Question" &&&& fun _ ->
        url (portalUrl)
        click "#forgot-password"
        "#pwRec_UserNameContainerID_UserName" << username
        click "#pwRec_UserNameContainerID_SubmitButton"
        contains "What is the name of my first pet?" (read "#pwRec > tbody > tr > td > table > tbody > tr:nth-child(4) > td:nth-child(2)")
        "#pwRec_QuestionContainerID_Answer" << "Tweety"
        click "#pwRec_QuestionContainerID_SubmitButton"
//        contains "Recover Password" (read "#form1 > div:nth-child(4) > h1")
        describe "done ..."

        // expect a User Credential Reminder email to the username's email