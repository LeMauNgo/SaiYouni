using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAni : EnemyAbstract
{
    [SerializeField] protected Animator ani;
    public Animator Ani => ani;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadAnimator();
    }
    protected virtual void LoadAnimator()
    {
        if (this.ani != null) return;
        ani = GetComponent<Animator>();
        Debug.Log(gameObject.name + "LoadAnimator", gameObject);
    }
    public virtual void EnemyAniState()
    {
        switch (this.enemyCtrl.EnemyStateMachine.EnemyState)
        {
            case (EnemyState.Idel):
                this.ani.SetInteger("Status", 0);
                break;
            case (EnemyState.Walk):
                this.ani.SetInteger("Status", 1);
                break;
            case (EnemyState.Hit):
                this.ani.SetInteger("Status", 2);
                break;
            case (EnemyState.Death):
                this.ani.SetTrigger("IsDeath");
                break;
        }
    }
}
