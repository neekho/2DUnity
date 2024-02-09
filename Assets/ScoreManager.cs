using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreLabel;

    public TextMeshProUGUI highScoreLabel;
    
    private static int currentScore;


    private string highScoreString;

    private int highScore;


    void Awake() {

        if (!instance) {

            instance = this;
        }
    }



    void Start()
    {
        setScoreLabel(currentScore);
        GetHighScore();
        setHighScoreLabel();
    }





    public void addScore() {
        currentScore++;
        setScoreLabel(currentScore);

        if (currentScore > highScore) {
            SetHighScore();
            setHighScoreLabel();
        }

        setScoreLabel(currentScore);
    }

    public void setScoreLabel(int score) {
        scoreLabel.text = "Score: " + ScoreManager.currentScore;
    }


    public void resetScore() {
        currentScore = 0;
    }










    private void setHighScoreLabel() {
        highScoreLabel.text = "High Score: " + highScore;
    }



     private void GetHighScore() {
        
        highScore = PlayerPrefs.GetInt(highScoreString, highScore);

    }

    private void SetHighScore() {
        
        PlayerPrefs.SetInt(highScoreString, currentScore);


    }
}
