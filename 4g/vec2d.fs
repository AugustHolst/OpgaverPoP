(* Opgave [4g0]
 *
 * Gruppe:
 *   Andrea
 *   August
 *   Jean-Claude
 *)

module vec2d

///<summary>
///len: Calculates the length of a vector
///</summary>
///<param name="(x,y)">
///type float tuple: vector to be evaluated
///</param>
///<return>
///Type float: the length of the vector
///<return>
let len (x,y) : float = sqrt(x*x+y*y)

///<summary>
///len: Calculates the angle of a vector using the in-built atan2 function.
///</summary>
///<param name="(x,y)">
///type float tuple: the vector to be evaluated.
///</param>
///<returns>
///type float: the angle in radians.
///</returns>
let ang (x,y) : float = atan2 y x

///<summary>
///scale: Scales a vector by a given constant.
///</summary>
///<param name="a">
///type float: the scaling factor.
///</param>
///<param name=(x,y)>
///type float tuple: the vector to be scaled by a.
///</param>
///<returns>
///type float tuple: the scaled vector
///</returns>
let scale a (x,y) : (float*float) = (a*x,a*y)

///<summary>
///add: The function adds two vectors together.
///</summary>
///<param name="(x1, y1)">
///type float tuple: the one vector to be added together with the other vector.
///</param>
///<param name="(x2, y2)">
///type float tuple: other vector.
///</param>
///<returns>
///type float: the sum of both vectors.
///</returns>
let add (x1, y1) (x2, y2) : (float*float) = (x1+x2, y1+y2)

///<summary>
///dot: Calculates x1 times x2 added up with y1 times y2. Which is the dot product of two vectors.
///</summary>
///<param name="(x1, y1)">
///type float tuple: one vector.
///</param>
///<param name="(x2, y2)">
///type float tuple: other vector.
///</param>
///<return>
///Type float: the dot product of both of the given vector.
///<return>
let dot (x1, y1) (x2, y2) : float = x1*x2+y1*y2