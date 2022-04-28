using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text scoreText;
    public Text hint1;
    public Text hint2;
    private string[] hints = {
        "You only get a new steak once every 5 seconds. Don't waste them!",
        "Throw bones to distract the dogs for a short time.",
        "Catching a cow restores 1 steak.",
        "You can stop the cows from running away by throwing bones at them.",
        "The large dogs need to be fed at least 2 steaks.",
        "The small dogs don't eat the entire steak. With clever planning and positioning you can feed more than one dog with a single steak."
        };

    // When setup is called activate the gameover screen
    public void Setup(float score)
    {
        gameObject.SetActive(true);

        // Set the text for the final score and select 2 random hints to display
        scoreText.text = "Final Score: " + score;
        hint1.text = "Random hint 1: " + hints[Random.Range(0, hints.Length)];
        hint2.text = "Random hint 2: " + hints[Random.Range(0, hints.Length)];

        // Stop the game from running in the background
        Time.timeScale = 0;
    }

    // Allow time to run again and reload the first scene restarting the game
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Prototype 2");
    }
}
