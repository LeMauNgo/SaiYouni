using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListData <T>  
{
    public static List<T> list = new List<T>();
    public void AddDatas(T data)
    {
        list.Add(data);
    }
    public void RemoveData(T data)
    {
        list.Remove(data);
    }
    public List<T> GetList()
    {
        return list;
    }
    public void Check(T data)
    {
        if (list.Contains(data))
        {
            Debug.Log(data.ToString()+ " In list");
        }
    }
}
