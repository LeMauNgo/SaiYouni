using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnToggleShop : BtnAbstract
{
    public override void OnClick()
    {
        UiShop.Instance.Toggle();
    }
}
