let exampleList = [[1; 2; 3]; [4; 5; 6]]
let incorrectList1 = [[1; 2; 3];[4; 5; 6];[]]
let incorrectList2 = [[1; 2; 3];[4; 5; 6];[0;0;4;3]]

let isTable (table : 'a list list) : bool = 
    let firstRowLen = table.Head.Length
    let boolConjunct acc (row : 'a list) = not row.IsEmpty && row.Length = firstRowLen && acc    
    List.fold boolConjunct true table
(*
printfn "%b" (isTable exampleList)
printfn "%b" (isTable incorrectList1)
printfn "%b" (isTable incorrectList2)
*)
let firstColumn (table : 'a list list) : 'a list = 
    List.map (fun (x : 'a list) -> x.Head) table

printfn "%A" (firstColumn exampleList)

let dropFirstColumn (table : 'a list list) : 'a list list = 
    List.map (fun (x : 'a list) -> x.Tail) table

printfn "%A" (dropFirstColumn exampleList)

let rec transpose (table : 'a list list) : 'a list list =
    if table.Head.Length = 0 then []
    else firstColumn table :: transpose (dropFirstColumn table)

printfn "%A" (transpose exampleList)
