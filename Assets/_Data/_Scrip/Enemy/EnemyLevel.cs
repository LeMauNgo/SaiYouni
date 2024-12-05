using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class EnemyLevel : LevelAbstract
{
    [SerializeField] protected float time;
    [SerializeField] protected int exp;
    protected override bool DeductExp(int exp)
    {
        if(this.exp < exp) return false;
        this.exp -= exp;
        return true;
    }

    protected override int GetCurrentExp()
    {
        time += Time.fixedDeltaTime;
        if (this.time <= 5) return 0;
        this.time = 0;
        this.exp += 10;
        return exp;
    }
}
