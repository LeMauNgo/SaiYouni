using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerbyTarget : MyBehaviour
{
    [SerializeField] protected EnemyCtrl enemyNearest;
    
    [SerializeField]
    private void FixedUpdate()
    {
        this.FindNearestEnemy();
    }
    protected void FindNearestEnemy()
    {
        float nearestDis = Mathf.Infinity;
        float targetDis;
        foreach (EnemyCtrl enemy in EnemyManager.Instance.Enemies) 
        { 
            targetDis = Vector3.Distance(transform.position, enemy.transform.position);
            if (targetDis > nearestDis) continue;
            nearestDis = targetDis;
            this.enemyNearest = enemy;
        }
    }
}
