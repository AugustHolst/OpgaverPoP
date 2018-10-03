(* Opgave [4g3]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

module alternateVec2d
let len (vec : float list) : float = sqrt(vec.[0]*vec.[0]+vec.[1]*vec.[1])

let ang (vec : float list) : float = atan2 vec.[1] vec.[0]

let scale a (vec : float list) :  float list = List.map (fun x -> a*x)  vec

let add (vec1 : float list) (vec2 : float list) : float list = [vec1.[0]+vec2.[0];vec1.[1]+vec2.[1]]

let dot (vec1 : float list) (vec2 : float list) : float = vec1.[0]*vec2.[0]+vec1.[1]*vec2.[1]