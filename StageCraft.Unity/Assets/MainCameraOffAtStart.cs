using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraOffAtStart : MonoBehaviour
{
    public GameObject mainCamera;
    void Start()
    {
        mainCamera.SetActive(false);
    }

}
