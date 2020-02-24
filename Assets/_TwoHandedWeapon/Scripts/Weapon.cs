using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Weapon : XRGrabInteractable
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void SetupHolds()
    {

    }

    private void SetupExtras()
    {

    }

    private void OnDestroy()
    {

    }

    private void SetInitialRotation(XRBaseInteractor interactor)
    {

    }

    public void SetGripHand(XRBaseInteractor interactor)
    {

    }

    public void ClearGripHand(XRBaseInteractor interactor)
    {

    }

    public void SetGuardHand(XRBaseInteractor interactor)
    {

    }

    public void ClearGuardHand(XRBaseInteractor interactor)
    {

    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);
    }

    private void SetGripRotation()
    {

    }

    private void CheckDistance(XRBaseInteractor interactor, HandHold handHold)
    {

    }

    public void PullTrigger()
    {

    }

    public void ReleaseTrigger()
    {

    }

    public void ApplyRecoil()
    {

    }
}
