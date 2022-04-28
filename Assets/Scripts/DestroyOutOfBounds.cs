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
        scoreManager = GameObject.Find("Score_manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < destructionBoundaryBackZ)
        {
            scoreManager.LoseLife();
            Destroy(gameObject);
        }
    }
}
