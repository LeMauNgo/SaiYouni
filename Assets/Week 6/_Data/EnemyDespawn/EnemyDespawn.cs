using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyDespawn : Despawn<EnemyCtrl> 
{
    private void OnEnable()
    {
        this.isDespawnByTime = false;
    }
}
