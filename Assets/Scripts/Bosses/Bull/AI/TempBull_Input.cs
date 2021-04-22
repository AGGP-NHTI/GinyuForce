using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        BullInput.BullTempCtrlMap.BullCharge.performed += bullctx => BullChargeAttack(bullctx);
        BullInput.BullTempCtrlMap.BullJump.performed += bullctx => BullJumpAttack(bullctx);
        BullInput.BullTempCtrlMap.BullSing.performed += bullctx => BullSingAttack(bullctx);
    }

    public void BullJumpAttack(InputAction.CallbackContext ctx)
    {
        Bull.DoAttack3(GameInstanceManager.Main.ThePlayer.Location);
    }

    public void BullChargeAttack(InputAction.CallbackContext ctx)
    {
        Bull.DoAttack1(ctx.ReadValue<Vector2>());
    }

    public void BullSingAttack(InputAction.CallbackContext ctx)
    {
        Bull.DoAttack2();
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
