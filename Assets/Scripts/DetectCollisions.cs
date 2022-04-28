using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private float turnAroundTimer = 0;
    private Quaternion forwardDirecton = new Quaternion(0, 1, 0, 180);
    private Quaternion backwardDirecton = new Quaternion(0, 1, 0, 0);

    public int dogSize;
    public int dogHealth;
    public HealthbarSlider healthSlider;

    // Update is called once per frame
    void Update()
    {
        // Constantly counts down a timer and turns the dog around to run back towards the player when the timer reaches 0
        turnAroundTimer -= Time.deltaTime;
        if(turnAroundTimer <= 0)
        {
            transform.rotation = backwardDirecton;
        }
        else
        {
            transform.rotation = forwardDirecton;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the bone hits the dog reset the timer so he turns around
        if(other.name == "Food_Bone(Clone)")
        {
            turnAroundTimer = 3;
        }
        else if(other.name == "Food_Steak(Clone)")
        {
            // If the steak hits the dog increase the dogs healthbar slider and destroy the gameobject when its full
            dogHealth ++;
            healthSlider.GainHealth(2/dogSize);
            if(dogHealth == dogSize)
            {
                Destroy(gameObject, 0.1f);
            }
        }
    }
}
