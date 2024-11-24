using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TextDiamondCount : TextAbstract
{
    protected virtual void FixedUpdate()
    {
        this.LoadGoldCount();
    }

    protected virtual void LoadGoldCount()
    {
        ItemInventory item = InventoriesManager.Instance.Currency().FindItem(ItemCode.Diamond);
        string diamondCount;
        if (item == null) diamondCount = "0";
        else diamondCount = item.itemCount.ToString();
        this.textPro.text = diamondCount;

    }
}
