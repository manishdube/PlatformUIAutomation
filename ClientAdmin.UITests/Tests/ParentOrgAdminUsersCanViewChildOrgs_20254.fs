module ParentOrgAdminUsersCanViewChildOrgs_20254
open canopy
open runner
open etconfig
open lib
open System
open i360Lib

let core _ = 
    context "ParentOrgAdminUsersCanViewChildOrgs_20254"
    compareTimeout <- 30.0
    //once (fun _ -> portalLogin ())
    //lastly (fun _ -> portalLogout ())
    let cmbxOrg_I = cmbxOrg_I

    "Parent.1 Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "Parent.1"
        setFieldValue "input[id='password']" "parentpassword"
        click "#Login1_Button1"

    "Navigate to User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"  
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //url "https://test-portalv3.i-360.com/ClientAdmin/UserVer2/UserAdmin.aspx"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
        displayed "Select Organization:"
       
    "Org - Parent - Child combinationt tests" &&&& fun _ ->

        click "#cmbxOrg_I"
        "#cmbxOrg_I" << "PARENT ORG TEST AUTOMATION"
        sleep 10
        describe "selected PARENT ORG TEST AUTOMATION"        
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        contains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        notContains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        notContains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        notContains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"

        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        sleep 10
        "#cmbxOrg_I" << "CHILD ORG1 TEST AUTOMATION"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        contains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        notContains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        notContains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"

        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        sleep 10
        "#cmbxOrg_I" << "CHILD ORG2 TEST AUTOMATION"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        notContains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        contains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        notContains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"
        
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        sleep 10
        "#cmbxOrg_I" << "CHILD ORG3 TEST AUTOMATION"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        notContains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        notContains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        contains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG3 TEST AUTOMATION user Child.3"
         
        describe "done ..."

        portalLogout ()


    "Child.1 Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "Child.1"
        setFieldValue "input[id='password']" "child1password"
        click "#Login1_Button1"

    "Navigate to User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"  
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //url "https://test-portalv3.i-360.com/ClientAdmin/UserVer2/UserAdmin.aspx"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
       
    "Org - Child - Parent combinationt tests" &&&& fun _ ->

        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        contains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        notContains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        notContains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"

        describe "done ..."

        portalLogout ()

    "Child.2 Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "Child.2"
        setFieldValue "input[id='password']" "child2password"
        click "#Login1_Button1"

    "Navigate to User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"  
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //url "https://test-portalv3.i-360.com/ClientAdmin/UserVer2/UserAdmin.aspx"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
       
    "Org - Child - Parent combinationt tests" &&&& fun _ ->

        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        notContains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        contains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        notContains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"

        describe "done ..."

        portalLogout ()

    "Child.3 Login" &&&& fun _ ->
        url (portalUrl)
        setFieldValue "input[id='username']" "Child.3"
        setFieldValue "input[id='password']" "child3password"
        click "#Login1_Button1"

    "Navigate to User Admin" &&&& fun _ ->
//        click "#ctl15_imgMasterHdrLogo"  
        sleep 5
        click "#Menu2 > ul > li:nth-child(2) > a"
        click "User Admin"
        //url "https://test-portalv3.i-360.com/ClientAdmin/UserVer2/UserAdmin.aspx"
        locateWindowWithTitleText "i360 - User Admin"
        describe "on i360 - User Admin page ..."
        displayed "User Admin"
       
    "Org - Child - Parent combinationt tests" &&&& fun _ ->

        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Parent.1"
        sleep 5
        notContains "Parent.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain PARENT ORG TEST AUTOMATION user Parent.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.1"
        sleep 5
        notContains "Child.1" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG1 TEST AUTOMATION user Child.1"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.2"
        sleep 5
        notContains "Child.2" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "contains CHILD ORG2 TEST AUTOMATION user Child.2"
        "#ctl00_MainContent_gvUsers_DXFREditorcol3_I" << "Child.3"
        sleep 5
        contains "Child.3" ( read "#ctl00_MainContent_gvUsers > tbody > tr > td > div.dxgvCSD")
        describe "does not contain CHILD ORG3 TEST AUTOMATION user Child.3"
         
        describe "done ..."

        portalLogout ()