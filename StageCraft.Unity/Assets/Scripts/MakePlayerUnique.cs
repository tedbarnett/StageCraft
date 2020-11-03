using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MakePlayerUnique : MonoBehaviour
{
    public TextMeshPro playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = "Player " + Mathf.RoundToInt(Random.Range(0.0f, 100.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
