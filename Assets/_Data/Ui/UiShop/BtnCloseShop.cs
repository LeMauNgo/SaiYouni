using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCloseShop : BtnAbstract
{
    [SerializeField] protected UiShop uiShop;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadUiShop();
    }
    protected virtual void LoadUiShop()
    {
        if (this.uiShop != null) return;
        this.uiShop = GetComponentInParent<UiShop>();
        Debug.Log(gameObject.name + "LoadUiInventory", gameObject);
    }
    public override void OnClick()
    {
        this.uiShop.Hide();
    }
}
