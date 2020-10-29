using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
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
        interactor.onSelectEnter.AddListener(ReleaseObject);
        interactor.onSelectExit.AddListener(GrabObject);
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

