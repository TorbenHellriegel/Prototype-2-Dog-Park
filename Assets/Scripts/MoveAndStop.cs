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
        if(destroiTimer > 6.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Destroi the steak after a certain amount of time
        destroiTimer -= Time.deltaTime;
        if(destroiTimer < 0)
        {
            Destroy(gameObject);
        }
    }
}
