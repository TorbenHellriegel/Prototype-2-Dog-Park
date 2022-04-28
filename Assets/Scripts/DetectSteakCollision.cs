using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSteakCollision : MonoBehaviour
{
    // When colliding with a dog destroy the steak unless the dog is a beagle then shrink it
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Dog_Beagle_01(Clone)")
        {
            transform.localScale = transform.localScale * 0.6f;
        }
        else if(other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}
