using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbstract : MonoBehaviour
{
    public int maxHealth = 100;
    public int minHealth = 0;
    public int curentHealth;
    private void Awake()
    {
        this.RandomHealth();
    }
    public void RandomHealth()
    {
        this.curentHealth = Random.Range(minHealth, maxHealth + 1);
    }
}
