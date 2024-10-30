using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MyBehaviour
{
    [SerializeField] protected EnemyCtrl enemyCtrl;
    [SerializeField] protected EnemyState enemyState;
    public EnemyState EnemyState => enemyState;
    private void Start()
    {
        this.ChangeState(EnemyState.Walk);
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        this.enemyCtrl = GetComponent<EnemyCtrl>();
        Debug.LogWarning(gameObject.name + "LoadEnemyCtrl", gameObject);
    }
    public virtual void ChangeState(EnemyState state)
    {
        this.enemyState = state;
        this.enemyCtrl.Animator.EnemyAniState();
    }
}
