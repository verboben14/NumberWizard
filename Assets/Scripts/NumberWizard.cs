using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int minimumNumber = 0;
    [SerializeField] int maximumNumber = 0;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        minimumNumber = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maximumNumber = guess;
        NextGuess();
    }

    void StartGame()
    {
        maximumNumber += 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(minimumNumber, maximumNumber);
        guessText.text = guess.ToString();
    }
}
