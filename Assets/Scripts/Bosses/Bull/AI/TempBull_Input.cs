using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempBull_Input : Core
{
    public static TempBull_Input Self = null;

    public BullController Bull;

    private BullTempControls BullInput;

    private void Awake()
    {
        if (Self)
        {
            Destroy(this);
        }
        Self = this;

        Bull = gameObject.GetComponent<BullController>();

        BullInput = new BullTempControls();
        BullInput.BullTempCtrlMap.BullCharge.performed += bullctx => BullChargeAttack();
        BullInput.BullTempCtrlMap.BullJump.performed += bullctx => BullJumpAttack();
        BullInput.BullTempCtrlMap.BullSing.performed += bullctx => BullSingAttack();
    }

    public void BullJumpAttack()
    {
        Bull.DoJumpAttack();
    }

    public void BullChargeAttack()
    {
        Bull.DoChargeAttack();
    }

    public void BullSingAttack()
    {
        Bull.DoSingAttack();
    }

    private void OnEnable()
    {
        BullInput.Enable();
    }

    private void OnDisable()
    {
        BullInput.Disable();   
    }
}
