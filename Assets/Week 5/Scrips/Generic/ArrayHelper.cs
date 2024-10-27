using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHelper
{ 
    public static T FindMax<T>(T[] Array) where T : IComparable<T>
    {
        if (Array == null || Array.Length <= 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
        T max = Array[0];
        foreach (T t in Array)
        {
            if(max.CompareTo(t) >0) continue;
            max = t;
        }
        return max;
    }
}
