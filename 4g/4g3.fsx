(* Opgave [4g3]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

#load "4g3.fs"
open alternateVec2d
let vec1 = [103.420; 360.1]
let vec2 = [7.7; -8.]

printfn "%A" (len vec1)
printfn "%A" (ang vec1)
printfn "%A" (scale 247. vec1)
printfn "%A" (add vec1 vec2)
printfn "%A" (dot vec1 vec2)