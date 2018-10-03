#load "vec2d.fs"
(* Opgave [4g1]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

(*
 * Vi har lavet en white-box test for funktionerne i vec2d.fs. Vi har ladet vores variabler kunne have værdierne 1, 0 og -1,
 * og har kombineret dem på alle mulige måder. Derudover har vi også lavet en unitesting ved at skrives det forventede resultat ned og sammenlinge med det reele resultat. 
 * Dette har vi gjort for alle de forskellige funktioner som vi har defineret i filen vec2d.fs
 *)

///<remarks>
///No declared functions here. Only print statements serving as tests
///</remarks>

//Test for vec2d length
printfn "\nEdge cases for vec2d length: \n"
for i=(-1) to 1 do
    for j=(-1) to 1 do
        let x = float i
        let y = float j
        printfn "len(%A,%A) = %A" x y (vec2d.len (x,y))

printfn "\nUnit tests for vec2d length: "
printfn "Length of vector (103.420, 360.1) is expected to be 374.6568 and the actual output is %A" (vec2d.len (103.420, 360.1))
printfn "Length of vector (-305.87231, 0) is expected to be 305.87231 and the actual output is %A" (vec2d.len (-305.87231, 0.)) 

//Test for vec2d angle
printfn "\nEdge cases for vec2d angle: \n"
for i=(-1) to 1 do
    for j=(-1) to 1 do
        let x = float i
        let y = float j
        printfn "ang(%A,%A) = %A rad" x y (vec2d.ang (x,y))

printfn "\nUnit tests for vec2d angle: "
printfn "Angle of vector (103.420, 360.1) is expected to be 1.29113rad and the actual output is %Arad" (vec2d.ang (103.420, 360.1))
printfn "Angle of vector (-305.87231, 0) is expected to be 3.14159rad and the actual output is %Arad" (vec2d.ang (-305.87231, 0.))

//Test for vec2d scale
printfn "\nEdge cases for vec2d scale: \n"
for i=(-1) to 1 do
    for j=(-1) to 1 do
        for k=(-1) to 1 do
            let x = float i
            let y = float j
            let a = float k
            printfn "%A * (%A,%A) = %A" a x y (vec2d.scale a (x,y))

printfn "\nUnit tests for vec2d scale: "
printfn "Scaling vector (103.420, 360.1) by 247 is expected to be (25544.7, 88944.7) and the actual output is %A" (vec2d.scale 247. (103.420, 360.1))
printfn "Scaling vector (-305.87231, 0) by -8 is expected to be (2446.98, 0) and the actual output is %A" (vec2d.scale -8. (-305.87231, 0.))

//Test for vec2d add
printfn "\nEdge cases for vec2d add: \n"
for i=(-1) to 1 do
    for j=(-1) to 1 do
        for k=(-1) to 1 do
            for l=(-1) to 1 do
                let x1 = float i
                let x2 = float j
                let y1 = float k
                let y2 = float l
                printfn "(%A,%A) + (%A,%A) = %A" x1 y1 x2 y2 (vec2d.add (x1, y1) (x2, y2))

printfn "\nUnit tests for vec2d add: "
printfn "Adding vector (103.420, 360.1) and (7.7, -8) is expected to be (111.12, 352.1) and the actual output is %A" (vec2d.add (103.420, 360.1) (7.7, -8.))
printfn "Adding vector (-305.87231, 0) and (0.5, -35) is expected to be (-305.37231, -35) and the actual output is %A" (vec2d.add (-305.87231, 0.) (0.5, -35.))

//Test for vec2d dot
printfn "\nEdge cases for vec2d dot product: \n"
for i=(-1) to 1 do
    for j=(-1) to 1 do
        for k=(-1) to 1 do
            for l=(-1) to 1 do
                let x1 = float i
                let x2 = float j
                let y1 = float k
                let y2 = float l
                printfn "(%A,%A) dot (%A,%A) = %A" x1 y1 x2 y2 (vec2d.dot (x1, y1) (x2, y2))

printfn "\nUnit tests for vec2d dot: "
printfn "Dot product of (103.420, 360.1) and (7.7, -8) is expected to be -2074.466 and the actual output is %A" (vec2d.dot (103.420, 360.1) (7.7, -8.))
printfn "Dot product of (-305.87231, 0) and (0.5, -35) is expected to be -152.936155 and the actual output is %A" (vec2d.dot (-305.87231, 0.) (0.5, -35.))