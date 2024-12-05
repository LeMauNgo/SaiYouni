using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.Playables;

public class UiShop : MySingleton<UiShop>
{
    [SerializeField] protected bool isShow = true;
    public bool IsShow => isShow;

    [SerializeField] protected Transform showHide;

    //[SerializeField] protected BtnItemInventory defaultItemInventoryUI;
    [SerializeField] protected List<BtnBuyItem> btnItems = new();


    private void Start()
    {
        this.Hide();
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadShowHide();
        this.LoadBtnBuyItem();
    }
    protected virtual void LoadBtnBuyItem()
    {
        if (this.btnItems.Count > 0) return;
        BtnBuyItem[] btnBuyItems = GetComponentsInChildren<BtnBuyItem>();
        this.btnItems = btnBuyItems.ToList();
        Debug.LogWarning(gameObject.name + " LoadBtnBuyItem", gameObject);
    }
    protected virtual void LoadShowHide()
    {
        if (this.showHide != null) return;
        this.showHide = transform.Find("ShowHide");
        Debug.LogWarning(transform.name + ": LoadShowHide", gameObject);
    }
    public virtual void Show()
    {
        this.isShow = true;
        this.showHide.gameObject.SetActive(this.isShow);
    }

    public virtual void Hide()
    {
        this.showHide.gameObject.SetActive(false);
        this.isShow = false;
    }

    public virtual void Toggle()
    {
        if (this.isShow) this.Hide();
        else this.Show();
    }
}
