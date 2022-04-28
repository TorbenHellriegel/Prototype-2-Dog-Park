using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRotated : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Give the game object a random rotation
        transform.Rotate(Vector3.up * Random.Range(0, 360));
    }
}
