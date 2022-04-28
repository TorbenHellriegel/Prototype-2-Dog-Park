using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSteakCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
