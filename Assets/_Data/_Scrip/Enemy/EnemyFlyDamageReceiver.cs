using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyDamageReceiver : EnemyDamageReceiver
{
    [SerializeField] protected bool canDrop;
    protected override void OnDead()
    {
        base.OnDead();
        this.canDrop = true;
    }
    private void FixedUpdate()
    {
        this.EnemyDrop();
    }
    protected virtual void EnemyDrop()
    {
        if (!this.canDrop) return;
        if (this.ctrl.Agent.baseOffset <= 0) return;
        if (this.ctrl.Agent.baseOffset <= 0) return;
        this.ctrl.Agent.baseOffset -= Time.fixedDeltaTime * 5;
    }
    protected override void Rebone()
    {
        base.Rebone();
        this.ctrl.Agent.baseOffset = 5;
        this.canDrop = false;
    }
}
