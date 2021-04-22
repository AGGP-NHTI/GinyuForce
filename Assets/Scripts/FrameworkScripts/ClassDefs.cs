using UnityEngine;

// Made using code from https://answers.unity.com/questions/949851/how-do-i-change-one-value-of-a-vector.html?childToView=1543516#comment-1543516
/// <summary>
/// Edit the value of a structure by assigning the structure to the return of this function. (Ex. Vector2 = Change.X(Vector2, 3))
/// </summary>
public static class Change
{
    /// <summary>
    /// Changes the X value of a Vector2 to the desired value. Will return the desired Vector2.
    /// </summary>
    /// <param name="v">Vector2 to change</param>
    /// <param name="x">Desired new X value</param>
    /// <returns></returns>
    public static Vector2 X(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }

    /// <summary>
    /// Changes the Y value of a Vector2 to the desired value. Will return the desired Vector2
    /// </summary>
    /// <param name="v">Vector2 to change</param>
    /// <param name="y">Desired new Y value</param>
    /// <returns></returns>
    public static Vector2 Y(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }
}
