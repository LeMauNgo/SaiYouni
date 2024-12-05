using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyCtrl : PoolObj
{
    [SerializeField] protected NavMeshAgent agent;
    public NavMeshAgent Agent => agent;
    [SerializeField] protected Animator animator;
    public Animator Animator => animator;
    [SerializeField] protected EnemyDamageReceiver damageReceiver;
    public EnemyDamageReceiver EnemyDamageReceiver => damageReceiver;
    [SerializeField] protected EnemyLevel enemyLevel;
    public EnemyLevel EnemyLevel => enemyLevel;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadAgent();
        this.LoadAnimator();
        this.LoadEnemyDamageReceiver();
        this.LoadEnemyLevel();

    }
    protected virtual void LoadEnemyLevel()
    {
        if (this.enemyLevel != null) return;
        this.enemyLevel = GetComponentInChildren<EnemyLevel>();
        Debug.LogWarning(gameObject.name + " LoadEnemyLevel", gameObject);
    }
    void LoadAgent()
    {
        if (agent != null) return;
        this.agent = GetComponent<NavMeshAgent>();
        Debug.Log("LoadAgent", gameObject);
    }
    void LoadAnimator()
    {
        if (animator != null) return;
        this.animator = GetComponentInChildren<Animator>();
        Debug.Log("LoadAnimator", gameObject);
    }
    protected virtual void LoadEnemyDamageReceiver()
    {
        if (damageReceiver != null) return;
        this.damageReceiver = GetComponentInChildren<EnemyDamageReceiver>();
        Debug.Log("LoadEnemyDamageReceiver", gameObject);
    }
}
