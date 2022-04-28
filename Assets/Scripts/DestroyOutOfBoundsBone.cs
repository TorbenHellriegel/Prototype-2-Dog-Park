using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsBone : MonoBehaviour
{
    private float destructionBoundaryFrontZ = 23.0f;

    // Update is called once per frame
    void Update()
    {
        // Destroy objects out of bounds
        if(transform.position.z > destructionBoundaryFrontZ)
        {
            Destroy(gameObject);
        }
    }
}
