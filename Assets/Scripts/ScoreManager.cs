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

    // Lose life and display the new lives and score
    public void LoseLife()
    {
        lives --;
        DisplayLivesScore();

        // Call the game over screen when life reaches 0
        if(lives <= 0)
        {
            gameOverScreen.Setup(score);
        }
    }

    // Reset the score to 0 and lives to 3
    public void resetScore()
    {
        lives = 3;
        score = 0;
    }
    
    // Increase the score and display the new score and life
    public void IncreaseScore()
    {
        score += 100;
        DisplayLivesScore();
    }

    // Display the score and life
    void DisplayLivesScore()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }
}
