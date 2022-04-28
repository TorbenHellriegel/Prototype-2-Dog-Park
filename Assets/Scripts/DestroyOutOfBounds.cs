using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float destructionBoundaryBackZ = -7.0f;
    
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // Get access to the score manager in order to lose life when the dog passes the player
        scoreManager = GameObject.Find("Score_manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the dog passes the player lose life and destroy game object
        if(transform.position.z < destructionBoundaryBackZ)
        {
            scoreManager.LoseLife();
            Destroy(gameObject);
        }
    }
}
