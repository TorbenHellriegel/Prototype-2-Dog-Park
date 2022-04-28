using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 500;
    public float rotationDirection = 1;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(300, 700);
        rotationDirection = (Random.Range(0, 2) - 0.5f) * 2;
        transform.Rotate(Vector3.up * Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * rotationDirection);
    }
}
