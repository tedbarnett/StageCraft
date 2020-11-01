using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowVersionNumber : MonoBehaviour
{
    public TextMeshPro versionText;
    // Start is called before the first frame update
    void Start()
    {
        versionText.text = "alpha " + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
