using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    public void Start ()
    {
        StartGame();
	}

    void StartGame()
    {
        //NextGuess();
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
	
	// Update is called once per frame
	 

    public void OnPressHigher()
    {
        min = guess + 1;
        guess = Random.Range(guess,max + 1);
        //NextGuess();
        DisplayGuessText();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        guess = Random.Range(min, guess);
        //NextGuess();
        DisplayGuessText();
    }

    public void NextGuess()
    {
        //guess = (min + max) / 2;
    }

    public void DisplayGuessText()
    {
        guessText.text = guess.ToString();
    }
}
