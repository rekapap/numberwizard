using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber = 1000;
    int minNumber = 1;
    int guess;

    // Use this for initialization
    void Start()
    {

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please, pick a number, but don't tell me what it is...");
        Debug.Log("Your highest number should be " + maxNumber);
        Debug.Log("Your lowest number should be " + minNumber);
        GuessUpdater();
        Debug.Log("Tell me if your number is higher or lower then " + guess + ".");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxNumber++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed Up.");
            minNumber = guess;
            UpdateGameState();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed Down.");
            maxNumber = guess;
            UpdateGameState();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pressed Enter.");
        }
    }

    void GuessUpdater()
    {
        guess = (minNumber + maxNumber) / 2;
    }

    void UpdateGameState()
    {
        GuessUpdater();
        Debug.Log(guess);
    }

}
