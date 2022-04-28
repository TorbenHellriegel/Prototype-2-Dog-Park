using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float nextDogTimer = 0.5f;

    // Update is called once per frame
    void Update()
    {
        nextDogTimer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if(nextDogTimer <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextDogTimer = 0.5f;
            }
        }
    }
}
