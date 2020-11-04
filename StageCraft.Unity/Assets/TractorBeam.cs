using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TractorBeam : MonoBehaviour
{

    public void Update()
    {
        var interactor = GetComponent<XRBaseInteractor>();
        var controller = GetComponent<XRController>();

        XRGrabInteractable grabbable = interactor.selectTarget as XRGrabInteractable;

        if (grabbable != null && grabbable.attachTransform != null)
        {
            InputDevice device = InputDevices.GetDeviceAtXRNode(controller.controllerNode);

            device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 thumbDirection);

            float moveAwayAmount = thumbDirection.y;

            Vector3 vectorToMoveObjectAlong = grabbable.attachTransform.parent.InverseTransformVector(controller.transform.forward);
            grabbable.attachTransform.localPosition += moveAwayAmount * vectorToMoveObjectAlong;

            MethodInfo unity_UpdateInteractorLocalPose = typeof(XRGrabInteractable).GetMethod("UpdateInteractorLocalPose", BindingFlags.NonPublic | BindingFlags.Instance);
            unity_UpdateInteractorLocalPose.Invoke(grabbable, new object[] { interactor });
        }

    }
}
