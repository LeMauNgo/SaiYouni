using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility 
{
    public static void Swap<T>(ref T x, ref T y)
    {
       T temp = x; x = y; y = temp;
    }
}
