module googleCSVtest
#load "refs.fsx"
open canopy

let run (row:Csv.Row) =

  start chrome
  
  describe <| "Go to Google.com and search for " + row.Search
  url "http://google.com"
  "input[type=text]" << row.Search
  press enter
  
  describe "Check that the first result is the Wikipedia page"
  "div.rc h3" == row.Result
  
  describe "Follow link to Wikipedia"
  click "div.rc h3"
  
  describe <| "Check that the first paragraph mentions " + row.Assert
  "p" =~ row.Assert
  
  quit()
