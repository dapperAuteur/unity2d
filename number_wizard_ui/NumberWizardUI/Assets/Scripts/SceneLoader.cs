using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int max;
    int min;
    int guess;

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
    }

    void Start()
    {
        Debug.Log("start: " + max + " " + min + " " + guess);
        StartGame();
        Debug.Log(max + " " + min + " " + guess);
    }

    /*
    private void Update()
    {
        Debug.Log("update");
    }
    */

    public void ItsHigher()
    {
        Debug.Log("its higher: " + max + " " + min + " " + guess);
        min = guess;
        Debug.Log(max + " " + min + " " + guess);
        guess = (max + min) / 2;
        Debug.Log(max + " " + min + " " + guess);
    }

    public void ItsLower()
    {
        Debug.Log("its lower: " + max + " " + min + " " + guess);
        max = guess;
        Debug.Log(max + " " + min + " " + guess);
        guess = (max + min) / 2;
        Debug.Log(max + " " + min + " " + guess);
    }
}
