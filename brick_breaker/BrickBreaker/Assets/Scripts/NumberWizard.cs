﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    //SceneLoader sceneLoader;

    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        //max = max + 1;
    }

    public void OnPressHigher()
    {
        //min = guess;
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        //max = guess;
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        Debug.Log("Is it higher or lower than..." + guess);
        guessText.text = guess.ToString();
    }
}
