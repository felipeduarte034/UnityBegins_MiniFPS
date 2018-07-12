using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScore : MonoBehaviour
{
    Text m_TextScore;

    void Awake()
    {
        m_TextScore = GameObject.FindWithTag("TextScore").GetComponent<Text>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_TextScore.text = DataManager.GetScore().ToString(); //Atualiza o valor da UI Text no cena
    }
}
