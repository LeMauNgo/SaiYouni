using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    public EnemyManager enemyManager;
    //----------------------Edit below here --------------------
    public EnemyAbstract FindEnemyWithSmallestHealth()
    {
        int minHP = enemyManager.EnemyAbstracts[0].curentHealth;
        EnemyAbstract enemyMinHP = enemyManager.EnemyAbstracts[0];
        foreach (EnemyAbstract enemy in enemyManager.EnemyAbstracts)
        {
            if(enemy.curentHealth > minHP) continue;
            minHP = enemy.curentHealth;
            enemyMinHP = enemy;
        }
        return enemyMinHP;
    }

    public EnemyAbstract FindEnemyWithLargestHealth()
    {
        int maxHP = enemyManager.EnemyAbstracts[0].curentHealth;
        EnemyAbstract enemyMaxHP = enemyManager.EnemyAbstracts[0];
        foreach (EnemyAbstract enemy in enemyManager.EnemyAbstracts)
        {
            if (enemy.curentHealth < maxHP) continue;
            maxHP = enemy.curentHealth;
            enemyMaxHP = enemy;
        }
        return enemyMaxHP;
    }
    private void Start()
    {
        Debug.Log("Enemy Larges Heath" + FindEnemyWithLargestHealth().gameObject.name + FindEnemyWithLargestHealth().gameObject );
        Debug.Log("Enemy Smallest Heath"  + FindEnemyWithSmallestHealth().gameObject.name + FindEnemyWithSmallestHealth().gameObject);
    }
    //----------------------Edit above here --------------------
}
