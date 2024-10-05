using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<EnemyAbstract> enemyAbstracts = new List<EnemyAbstract>();
    public List<EnemyAbstract> EnemyAbstracts => enemyAbstracts;
    private void Reset()
    {
        this.LoadEnemyAbstract();

    }
    void LoadEnemyAbstract()
    {
        foreach(Transform enemy in transform)
        {
            if (enemy.GetComponent<EnemyAbstract>() == null) return;
            this.enemyAbstracts.Add(enemy.GetComponent<EnemyAbstract>());
        }
    }
}
