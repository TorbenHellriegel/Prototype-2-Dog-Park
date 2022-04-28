using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndStop : MonoBehaviour
{
    private float speed = 10.0f;
    private float destroiTimer;

    // Start is called before the first frame update
    void Start()
    {
        destroiTimer = 7.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the steak forward for only a short amount of time
        if(destroiTimer > 6.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Destroy the steak after a certain amount of time
        destroiTimer -= Time.deltaTime;
        if(destroiTimer < 0)
        {
            Destroy(gameObject);
        }
    }
}
