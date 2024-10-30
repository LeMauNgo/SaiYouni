using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.AI;

public abstract class EnemyCtrl : PoolObj
{
    [SerializeField] protected NavMeshAgent agent;
    public NavMeshAgent Agent => agent;
    [SerializeField] protected EnemyAni animator;
    public EnemyAni Animator => animator;
    [SerializeField] protected EnemyStateMachine enemyStateMachine;
    public EnemyStateMachine EnemyStateMachine => enemyStateMachine;
    [SerializeField] protected EnemyRagDoll enemyRagDoll;
    public EnemyRagDoll EnemyRagDoll => enemyRagDoll;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadAgent();
        this.LoadAnimator();
        this.LoadEnemyStateMachine();
        this.LoadEnemyRagDoll();
    }
    protected virtual void LoadAgent()
    {
        if (agent != null) return;
        this.agent = GetComponent<NavMeshAgent>();
        Debug.Log("LoadAgent", gameObject);
    }
    protected virtual void LoadAnimator()
    {
        if (animator != null) return;
        this.animator = GetComponentInChildren<EnemyAni>();
        Debug.Log("LoadAnimator", gameObject);
    }
    protected virtual void LoadEnemyStateMachine()
    {
        if (enemyStateMachine != null) return;
        this.enemyStateMachine = GetComponent<EnemyStateMachine>();
        Debug.Log("LoadEnemyStateMachine", gameObject);
    }
    protected virtual void LoadEnemyRagDoll()
    {
        if (enemyRagDoll != null) return;
        this.enemyRagDoll = GetComponentInChildren<EnemyRagDoll>();
        Debug.Log("LoadEnemyStateMachine", gameObject);
    }
}
