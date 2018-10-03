(* Opgave [4g3]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

(* Som et alternativ til tupler kan man bruge lister. Disse liste vil kun holde 2 værdier, da de skal repræsentere 2d vektorer.
 * Så vil index 0 være tilsvarende til x og index 1 er tilsvarende y
 * Til besvarelse af opgaven har vi samt en signaturfil også lavet en implementationsfil og en scriptfil der bruger alternativeVec2d modulet.
 *)
module alternateVec2d

/// The  length  of a vector
val len : float list -> float
/// The  angle of a vector
val ang : float list -> float
/// Multiplication of a float and a vector
val scale : float  -> float list  -> float list
/// Addition  of two  vectors
val add : float list -> float list  -> float list
/// Dot  product  of two  vectors
val dot : float list -> float list  -> float