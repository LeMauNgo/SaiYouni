using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBuyItem : BtnAbstract
{
    [SerializeField] protected ItemCode itemCode;
    public override void OnClick()
    {
        this.DeducGold();
    }
    protected virtual void DeducGold()
    {
        if(!InventoriesManager.Instance.RemoveItem(ItemCode.Gold, 10)) return;
        InventoriesManager.Instance.AddItem(this.itemCode, 1);
    }
}
