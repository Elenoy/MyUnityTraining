using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizardCore : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI text;

    int currentGuess;

	// Use this for initialization
	void Start ()
    {
        StartGuess();
	}

    private void StartGuess()
    {
        NextGuess();
    }
	
	public void OnClickHigher()
    {
        min = currentGuess + 1;
        max = max + 1;
        NextGuess();
    }

    public void OnClickLower()
    {
        max = currentGuess - 1;
        min = min - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        currentGuess = Random.Range(min, max);
        text.text = currentGuess.ToString();
    }
}
