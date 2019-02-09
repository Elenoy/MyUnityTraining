using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] Text pageNumberText;
    [SerializeField] State startigState;
    private State currentState;
    private UInt16 currentPageNumber = 1;
	// Use this for initialization
	void Start () {
        currentState = startigState;
        textComponent.text = currentState.GetStoryText();
        pageNumberText.text = currentPageNumber.ToString();

    }
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = UpdatePage(currentState, 0, ref currentPageNumber);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = UpdatePage(currentState, 1, ref currentPageNumber);
        }
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    currentState = nextStates[2];
        //}

        

        
    }

    private State UpdatePage(State state, int nextStateNumber, ref UInt16 pageNumber)
    {
        var nextStates = state.GetNextStates();
        state = nextStates[nextStateNumber];

        if (state == startigState)
        {
            pageNumber = 1;
        }
        else
        {
            pageNumber++;
        }
        textComponent.text = state.GetStoryText();
        pageNumberText.text = pageNumber.ToString();

        return state;
    }
}
