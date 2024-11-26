using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyMove : EnemyMove
{
    protected override void OnEnable()
    {
        base.OnEnable();
        this.pointDistanceMin = 5f;
    }
}
