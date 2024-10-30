using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider))]
public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected CapsuleCollider capsuleCollider;
    [SerializeField] protected EnemyCtrl enemyCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCapsuleCollider();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        this.enemyCtrl = GetComponentInParent<EnemyCtrl>();
        Debug.LogWarning(gameObject.name + "LoadEnemyCtrl", gameObject);
    }
    protected virtual void LoadCapsuleCollider()
    {
        if (this.capsuleCollider != null) return;
        this.capsuleCollider = transform.GetComponent<CapsuleCollider>();
        this.capsuleCollider.radius = 0.3f;
        this.capsuleCollider.height = 2;
        this.capsuleCollider.center = new Vector3(0, 1, 0);
        Debug.LogWarning(gameObject.name + "LoadCapsuleCollider", gameObject);
    }
    protected override void OnDead()
    {
        //throw new System.NotImplementedException();
        this.enemyCtrl.EnemyStateMachine.ChangeState(EnemyState.Death);
        this.enemyCtrl.Agent.enabled = false;
        Invoke(nameof(OnRagDoll), 3);
        this.gameObject.SetActive(false);
    }

    protected override void OnHurt()
    {
        //throw new System.NotImplementedException();
        this.enemyCtrl.EnemyStateMachine.ChangeState(EnemyState.Hit);
        Invoke(nameof(OffHurt), 2.05f);
    }
    protected virtual void OffHurt()
    {
        if (this.enemyCtrl.EnemyStateMachine.EnemyState != EnemyState.Hit) return;
        this.enemyCtrl.EnemyStateMachine.ChangeState(EnemyState.Walk);
    }
    protected virtual void OnRagDoll()
    {
        this.enemyCtrl.EnemyRagDoll.SetRagdollState(true);
    }
}
