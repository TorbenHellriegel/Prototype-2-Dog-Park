using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float lives;
    public float score;

    public Text scoreText;
    public Text livesText;
    public GameOverScript gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        resetScore();
        DisplayLivesScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife()
    {
        lives --;
        DisplayLivesScore();
        if(lives <= 0)
        {
            gameOverScreen.Setup(score);
        }
    }

    public void resetScore()
    {
        lives = 3;
        score = 0;
    }
    
    public void GainLife()
    {
        lives ++;
        DisplayLivesScore();
    }
    
    public void IncreaseScore()
    {
        score += 100;
        DisplayLivesScore();
    }

    void DisplayLivesScore()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }
}
