using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour //Centralizar o uso da classe PlayerPrefs - ter mais controle
{
	// Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //SCORE
    public static int GetScore() { return PlayerPrefs.GetInt(Constants.KEY_VALUE_SCORE, 0); }
    public static void SetScore(int value) { PlayerPrefs.SetInt(Constants.KEY_VALUE_SCORE, value); }
}
