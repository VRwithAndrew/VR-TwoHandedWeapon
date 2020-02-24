using UnityEngine.XR.Interaction.Toolkit;

public class GripHold : HandHold
{
    protected override void BeginAction(XRBaseInteractor interactor)
    {
        base.BeginAction(interactor);
    }

    protected override void EndAction(XRBaseInteractor interactor)
    {
        base.BeginAction(interactor);
    }

    protected override void Grab(XRBaseInteractor interactor)
    {
        base.Grab(interactor);
    }

    protected override void Drop(XRBaseInteractor interactor)
    {
        base.Drop(interactor);
    }
}
