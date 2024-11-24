using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonInputToggler : MyBehaviour
{
    [SerializeField] protected vThirdPersonInput vThirdPersonInput;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadvThirdPersonInput();
    }
    protected virtual void LoadvThirdPersonInput()
    {
        if (vThirdPersonInput != null) return;
        this.vThirdPersonInput = GetComponent<vThirdPersonInput>();
        Debug.LogWarning(gameObject.name + "LoadvThirdPersonInput", gameObject);
    }
    private void FixedUpdate()
    {
        this.Toggler();
    }
    protected virtual void Toggler()
    {
        if (UiInventory.Instance.IsShow) this.vThirdPersonInput.enabled = false;
        this.vThirdPersonInput.enabled = true;
    }

}
