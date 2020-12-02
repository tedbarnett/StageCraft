using Normal.Realtime;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRMultiplayer : MonoBehaviour
{
    public void RequestOwnership(XRBaseInteractable xrBaseInteractable)
    {
        var realtimeView = xrBaseInteractable.GetComponent<RealtimeView>();
        var realtimeTransform = xrBaseInteractable.GetComponent<RealtimeTransform>();

        if (realtimeView != null)
        {
            realtimeView.RequestOwnership();
        }

        if (realtimeTransform != null)
        {
            realtimeTransform.RequestOwnership();
        }
    }
}
