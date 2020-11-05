using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MakePlayerUnique : MonoBehaviour
{
    public TextMeshPro playerName;
    public GameObject playerHeadModel;
    public GameObject playerWatchModel;

    private Color playerColor;
    Renderer m_HeadRenderer;
    Renderer m_WatchRenderer;


    void Awake()
    {
        
        playerColor = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1.0f, 1.0f);
        playerName.text = "Actor " + Mathf.RoundToInt(Random.Range(0.0f, 100.0f));

        m_HeadRenderer = playerHeadModel.GetComponent<Renderer>();
        m_WatchRenderer = playerWatchModel.GetComponent<Renderer>();

        m_HeadRenderer.material.color = playerColor;
        m_WatchRenderer.material.color = playerColor;
    }

}
