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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.left * Time.deltaTime * dodgeSpeed * dodgeDirection);

        changeDirectionCounter -= Time.deltaTime;
        destructionTimer -= Time.deltaTime;

        if(changeDirectionCounter < 0)
        {
            dodgeDirection = dodgeDirection * -1;
            changeDirectionCounter = Random.Range(0.3f, 3.0f);
        }

        if(destructionTimer < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Food_Bone(Clone)")
        {
            speed = 0;
            dodgeSpeed = 0;
        }

        if(other.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
