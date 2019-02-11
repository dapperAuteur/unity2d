using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
            Debug.Log("Alpha1");
            Debug.Log(nextState[0]);
            Debug.Log(nextState);
            Debug.Log(state);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
            Debug.Log("Alpha2");
            Debug.Log(nextState[1]);
            Debug.Log(nextState);
            Debug.Log(state);
        }
        textComponent.text = state.GetStateStory();
    }
}
