using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendData : MonoBehaviour
{
    [Header("BT1")]
    DataStorage<int> Number = new DataStorage<int>();
    DataStorage<string> String = new DataStorage<string>();
    DataStorage<float> Float = new DataStorage<float>();
    [Header("BT2")]
    private int[] ints = { 3, 6, 1, 8, 12 };
    private float[] floats = { 1.5f, 5.3f, 12.4f, 4, 9 };
    private void Start()
    {
        // BT1
        this.Number.Data(0);
        this.String.Data("String");
        this.Float.Data(1.2f);
        //BT2
        Debug.Log(ArrayHelper.FindMax(ints).ToString());
        Debug.Log(ArrayHelper.FindMax(floats).ToString());
        //Bt3
        string x = "Hi"; string y = "Hello";
        Utility.Swap(ref x,ref y);
        Debug.Log(x.ToString() + y.ToString());
        //Bt4
        ListData<int> list = new ListData<int>();
        list.AddDatas(1);
        list.AddDatas(2);
        list.AddDatas(3);
        foreach (int i in list.GetList())
        {
            Debug.Log(i.ToString());
        }
        //Bt5
        list.Check(2);
        list.Check(5);
    }
}
