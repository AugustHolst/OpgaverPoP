open System.Text.RegularExpressions

let smallTestUrl = "http://tsponline.dk/pop/links/10.htm"
let bigTestUrl = "http://tsponline.dk/pop/links/1000.htm"

let linkPattern = "(<a href)" 

let url2Stream url =
    let uri = System.Uri url
    let request = System.Net.WebRequest.Create uri
    let response = request.GetResponse ()
    response.GetResponseStream ()

let readUrl url = 
    let reader = new System.IO.StreamReader(url2Stream url)
    reader.ReadToEnd ()

let countLinks (url : string) : int = 
    let mutable numOfLinks = 0
    let html = readUrl url
    let matches = Regex.Matches(html, linkPattern)
    for mtch in matches do
        numOfLinks <- numOfLinks + 1
    numOfLinks

printfn "%A" (countLinks smallTestUrl = 1000)
printfn "%A" (countLinks bigTestUrl = 1000)