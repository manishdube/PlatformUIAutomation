module nc4
open canopy
open runner
open etconfig
open lib
open System
open i360Lib
open OpenQA.Selenium

let core _ = 
    context "nc4"
    elementTimeout <- 30.0
    pageTimeout <- 30.0
//    once (fun _ -> portalLogin ())
//    lastly (fun _ -> portalLogout ())

    "Navigate to NC4 Home Page" &&&& fun _ ->
        url ("http://nc4.com") 
        displayed "Home"
        highlight "#menu > li:nth-child(1)"

        //let origWindow = browser.CurrentWindowHandle
        //// do something to open another window
        //// make the new window the focus of tests
        //let newWindow = browser.WindowHandles |> Seq.find (fun w -> w <> origWindow )
        //browser.SwitchTo().Window(newWindow) |> ignore
        //// optionally do asserts on the contents of the new window
        //// close the new window
        //browser.Close()
        //// switch back to the original window
        //browser.SwitchTo().Window(origWindow) |> ignore

        displayed "Company"
        highlight "#menu > li:nth-child(2)"

        displayed "solutions"
        highlight "#menu > li:nth-child(3)"

        displayed "industries"
        highlight "#menu > li:nth-child(4)"

        displayed "products"
        highlight "#menu > li:nth-child(5)"

        displayed "news"
        highlight "#menu > li:nth-child(6)"

        
        click "Home"
        displayed "customer login"
        highlight "#menu > li:nth-child(7)"
        displayed "#subjBdy"
        displayed "#rightSubjectBox"
        displayed "#mainGraphic"
        press Keys.PageUp

        //hover "Home"
        sleep 2
        highlight "#menu > li:nth-child(2) > a"
        hover "#menu > li:nth-child(2) > a"
        //click "Company"
        highlight "#menu > li:nth-child(2) > div > ul > li:nth-child(1) > a"
        displayed "Overview"

        click "Overview"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "#menu > li:nth-child(2) > a"
        highlight "#menu > li:nth-child(2) > div > ul > li:nth-child(2) > a"
        displayed "Contact"
        click "Contact"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"


        hover "#menu > li:nth-child(2) > a"
        highlight "#menu > li:nth-child(2) > div > ul > li:nth-child(3) > a"
        displayed "Operational Status"
        click "Operational Status"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "#menu > li:nth-child(2) > a"
        highlight "#menu > li:nth-child(2) > div > ul > li:nth-child(4) > a"
        displayed "Careers"
        click "Careers"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        sleep 2
        highlight "#menu > li:nth-child(3) > div > div:nth-child(2) > ul > li:nth-child(1) > a"
        displayed "Business Continuity"
        click "Business Continuity"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(2) > ul > li:nth-child(2) > a"
        displayed "Corporate Security"
        click "Corporate Security"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(2) > ul > li:nth-child(3) > a"
        displayed "Enterprise Risk Management"
        click "Enterprise Risk Management"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(2) > ul > li:nth-child(4) > a"
        displayed "Supply Chain Risk Management"
        click "Supply Chain Risk Management"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(2) > ul > li:nth-child(5) > a"
        displayed "Travel Risk Management"
        click "Travel Risk Management"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(3) > ul > li:nth-child(1) > a"
        displayed "Emergency Management"
        click "Emergency Management"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(3) > ul > li:nth-child(2) > a"
        displayed "Fire Response"
        click "Fire Response"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(3) > ul > li:nth-child(3) > a"
        displayed "Health and Hospitals"
        click "Health and Hospitals"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(3) > ul > li:nth-child(4) > a"
        displayed "Law Enforcement"
        click "Law Enforcement"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(4) > ul > li:nth-child(1) > a"
        displayed "Cyber Threat Intelligence Sharing"
        click "Cyber Threat Intelligence Sharing"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(4) > ul > li:nth-child(2) > a"
        displayed "Homeland Security"
        click "Homeland Security"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(4) > ul > li:nth-child(3) > a"
        displayed "Information Protection"
        click "Information Protection"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(4) > ul > li:nth-child(4) > a"
        displayed "Mission Support"
        click "Mission Support"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "solutions"
        highlight "#menu > li:nth-child(3) > div > div:nth-child(4) > ul > li:nth-child(5) > a"
        displayed "Sensitive Procurement"
        click "Sensitive Procurement"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Aerospace & Defense"
        click "Aerospace & Defense"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Banking & Finance"
        click "Banking & Finance"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Education"
        click "Education"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Government"
        click "Government"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Healthcare"
        click "Healthcare"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "High Tech"
        click "High Tech"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "industries"
        displayed "Law Enforcement"
        click "Law Enforcement"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Oil & Gas"
        click "Oil & Gas"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Pharmaceuticals & Biotech"
        click "Pharmaceuticals & Biotech"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Manufacturing"
        click "Manufacturing"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Retail"
        click "Retail"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Strategic Consulting"
        click "Strategic Consulting"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(4)"
        hover "industries"
        displayed "Telecommunications"
        click "Telecommunications"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(1) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(3) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"        

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(4) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"        

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(5) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"        

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(6) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"        

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(7) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"        

        highlight "#menu > li:nth-child(5)"
        hover "products"
        click "#menu > li:nth-child(5) > div > div > ul > li:nth-child(8) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(6)"
        hover "news"
        click "#menu > li:nth-child(6) > div > div > ul > li:nth-child(1) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(6)"
        hover "news"
        click "#menu > li:nth-child(6) > div > div > ul > li:nth-child(2) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(6)"
        hover "news"
        click "#menu > li:nth-child(6) > div > div > ul > li:nth-child(3) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        highlight "#menu > li:nth-child(6)"
        hover "news"
        click "#menu > li:nth-child(6) > div > div > ul > li:nth-child(4) > a"
        sleep 2
        displayed "#subNav"
        highlight "#subNav" 
        click "home"

        hover "customer login"
        displayed "customer login"
        highlight "#menu > li:nth-child(7)"

