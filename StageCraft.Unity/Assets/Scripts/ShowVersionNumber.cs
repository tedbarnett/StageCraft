using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowVersionNumber : MonoBehaviour
{
    public GameObject versionTextObject;
    private TextMeshProUGUI textMeshComponent;
    // Start is called before the first frame update
    void Start()
    {
        textMeshComponent = versionTextObject.GetComponent(typeof(TextMeshProUGUI)) as TextMeshProUGUI;
        textMeshComponent.text = "version: alpha " + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
