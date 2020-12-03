using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAvatar : MonoBehaviour
{
    public GameObject LocalAvatarPrefab;
    public Transform StartPosition;

    void Start()
    {
        var playerAvatar = Instantiate(LocalAvatarPrefab, StartPosition.position, StartPosition.rotation);
    }

}
