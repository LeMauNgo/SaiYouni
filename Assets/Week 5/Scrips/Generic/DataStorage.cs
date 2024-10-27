using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataStorage<T>
{
    private T _value;
    public void Data(T value)
    {
        this._value = value;
        Debug.Log(this._value.ToString());
    }
}

