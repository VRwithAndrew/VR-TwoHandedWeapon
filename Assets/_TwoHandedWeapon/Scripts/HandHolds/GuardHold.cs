using UnityEngine.XR.Interaction.Toolkit;

public class GuardHold : HandHold
{
    protected override void Grab(XRBaseInteractor interactor)
    {
        base.Grab(interactor);
    }

    protected override void Drop(XRBaseInteractor interactor)
    {
        base.Drop(interactor);
    }
}
