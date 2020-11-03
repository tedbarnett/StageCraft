using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MakePlayerUnique : MonoBehaviour
{
    public TextMeshPro playerName;
    public GameObject playerHeadModel;
    public GameObject playerLeftHandModel;
    public GameObject playerRightHandModel;
    private Color playerColor;
    Renderer m_HeadRenderer;
    Renderer m_LeftHandRenderer;
    Renderer m_RightHandRenderer;


    void Awake()
    {
        
        playerColor = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1.0f, 1.0f);
        playerName.text = "Actor " + Mathf.RoundToInt(Random.Range(0.0f, 100.0f));

        m_HeadRenderer = playerHeadModel.GetComponent<Renderer>();
        m_LeftHandRenderer = playerLeftHandModel.GetComponent<Renderer>();
        m_RightHandRenderer = playerRightHandModel.GetComponent<Renderer>();
        m_HeadRenderer.material.color = playerColor;
        m_LeftHandRenderer.material.color = playerColor;
        m_RightHandRenderer.material.color = playerColor;
    }

}
