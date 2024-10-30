using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyRagDoll : EnemyAbstract
{
    [SerializeField] protected List<Rigidbody> rigidbodies;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadRigidbodies();
    }
    protected virtual void LoadRigidbodies()
    {
        if (this.rigidbodies.Count > 0) return;
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        this.rigidbodies = rigidbodies.ToList();
        foreach(var rigidbody in this.rigidbodies)
        {
            rigidbody.isKinematic = true;
        }
    }
    public void SetRagdollState(bool state)
    {
        this.enemyCtrl.Animator.Ani.enabled = !state;

        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = !state; 
        }
    }
}
