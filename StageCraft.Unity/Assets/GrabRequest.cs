using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;

// Based on XR Grab example: https://forum.unity.com/threads/object-grabbed-event.873097/
// Maybe should try this: https://gist.github.com/cabbibo/59bf1532af2a0a0513f68850e0138e51

public class GrabRequest : MonoBehaviour
{
    private RealtimeView _realtimeView;
    private RealtimeTransform _realtimeTransform;
    private XRDirectInteractor interactor = null;

    private void Awake()
    {
        _realtimeView = GetComponent<RealtimeView>();
        _realtimeTransform = GetComponent<RealtimeTransform>();
        interactor = GetComponent<XRDirectInteractor>();
        Debug.Log("set up GrabRequest.cs");
    }

    private void OnEnable()
    {
        interactor.onSelectEnter.AddListener(GrabObject);
        interactor.onSelectExit.AddListener(ReleaseObject);
    }
    private void OnDisable()
    {
        interactor.onSelectEnter.RemoveListener(ReleaseObject);
        interactor.onSelectExit.RemoveListener(GrabObject);
    }


    private void GrabObject(XRBaseInteractable interactable)
    {
        _realtimeTransform.RequestOwnership();
        Debug.Log("Grabbed object");
    }
    private void ReleaseObject(XRBaseInteractable interactable)
    {
        _realtimeTransform.ClearOwnership();
    }

}

