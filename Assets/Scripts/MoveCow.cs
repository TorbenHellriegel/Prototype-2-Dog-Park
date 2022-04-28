using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCow : MonoBehaviour
{
    private float speed = 7;
    private float dodgeSpeed = 7;
    private float dodgeDirection = 1;
    private float changeDirectionCounter = 1;
    private float destructionTimer = 15;

    // Update is called once per frame
    void Update()
    {
        // Move the cow forward as well as left or right depending on the value of dodge direction
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.left * Time.deltaTime * dodgeSpeed * dodgeDirection);

        changeDirectionCounter -= Time.deltaTime;
        destructionTimer -= Time.deltaTime;

        // When the change direction counter reaches 0 change the dodging direction and set a new counter value
        if(changeDirectionCounter < 0)
        {
            dodgeDirection = dodgeDirection * -1;
            changeDirectionCounter = Random.Range(0.3f, 3.0f);
        }

        // After a certain amount of time destroy the game object
        if(destructionTimer < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // When the cow collides with a bone stop its movement
        if(other.name == "Food_Bone(Clone)")
        {
            speed = 0;
            dodgeSpeed = 0;
        }

        // When the cow collides with the player destroy it
        if(other.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
