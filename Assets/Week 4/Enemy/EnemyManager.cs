using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MySingleton<EnemyManager>
{
    [SerializeField] protected List<EnemyCtrl> enemies;
    public List<EnemyCtrl> Enemies => enemies;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadEnemies();
    }
    protected virtual void LoadEnemies()
    {
        if (enemies.Count > 0) return;
        foreach (Transform t in transform)
        {
            EnemyCtrl enemyCtrl = t.GetComponent<EnemyCtrl>();
            if (enemyCtrl == null) continue;
            this.enemies.Add(enemyCtrl);
        }
    }
}
