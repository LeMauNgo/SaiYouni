using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbstract : MyBehaviour
{
    [SerializeField] protected PlayerCtrl enemyCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (enemyCtrl != null) return;
        this.enemyCtrl = GetComponentInParent<PlayerCtrl>();
        Debug.Log("LoadPlayerCtrl", gameObject);
    }
}
