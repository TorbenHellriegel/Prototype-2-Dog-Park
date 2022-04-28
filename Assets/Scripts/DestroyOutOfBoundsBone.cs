using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsBone : MonoBehaviour
{
    private float destructionBoundaryFrontZ = 23.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy objects out of screen
        if(transform.position.z > destructionBoundaryFrontZ)
        {
            Destroy(gameObject);
        }
    }
}
