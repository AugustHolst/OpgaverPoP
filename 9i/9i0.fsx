let testArr = [| 0; 1; 2 |]

let safeIndexIf (arr : 'a []) (i : int) : 'a =
    match i with 
    | i when i >= 0 && i < arr.Length -> arr.[i]
    | _ -> printf "Index out of bounds of given array, first element of array returned:  "
           arr.[0]

let safeIndexTry (arr : 'a []) (i : int) : 'a = 
    try
        arr.[i]
    with
        | :? System.IndexOutOfRangeException -> failwith (sprintf "Index: %d out of bounds" i)

let safeIndexOption (arr : 'a []) (i : int) : 'a option =
    try
        Some arr.[i]
    with
        | :? System.IndexOutOfRangeException -> None

printfn "%A" (safeIndexIf testArr 1)
printfn "%A" (safeIndexOption testArr 1).Value
printfn "%A" (safeIndexTry testArr 1)

printfn "%A" (safeIndexIf testArr 3)
printfn "%A" (safeIndexOption testArr 3)
safeIndexTry testArr 3