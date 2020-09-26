using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public Text textField;
	public int score;
    
    void Start()
    {
        Debug.Log("Hello, I'm score!");
        PrintScore();

        textField.text = "hello !";

        textField.fontSize = 70;
    }

    public void PrintScore()
    {
	    Debug.Log(score.ToString());
    }

    public void AddScore(int scoreToBeAdded)
    {
	    score += scoreToBeAdded;
    }
}
