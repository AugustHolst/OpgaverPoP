#load "vec2d.fs"
(* Opgave [4g2]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

(* a *)

///<summary>
///polyLen: calculates the sum of all side lengths of a nth sided regular polygon fit within a unit circle.
///Done by storing one of the polygon's sides as vector and using vec2d.len to get the length times the amount of sides of the regular polygon.
///</summary>
///<param name="n">
///the n amount of sides of the polygon of type int
///</param>
///<returns>
///the sum of all sides of the polygon of type float
///</returns>
let polyLen (n:int) : float =
    if n = 2 then 2.
    else
        let theta1 = (2.*System.Math.PI*2.)/float n
        let theta2 = (2.*System.Math.PI*3.)/float n
        let sideVec = (cos(theta2)-cos(theta1), sin(theta2)-sin(theta1))
        (vec2d.len sideVec)*float n

///<summary>
///this function prints a table comparing polylen for n = 2 to 350 with 2pi
///</summary>
///<returns>
///the comparison table as a string.
///</returns>
let polyTable =
    let mutable table = ""
    table <- sprintf "%8s | %8s | %s" "n" "polyLen" "circumference of unit circle\n"
    for i=2 to 350 do
        table <- table + sprintf "%8d | %8f | %8f\n" i (polyLen i) (System.Math.PI*2.)
    table

printfn "%s" polyTable

(* b *)

(*Når n -> infinity så vil længden af polygon gå mod 2pi, da polygonet vil ligne enhedscirklen mere og mere jo større n bliver.
 *N vil aldrig være lig med 2pi, da pi er et irrationelt tal.
 *)