using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private float turnAroundTimer = 0;
    private Quaternion forwardDirecton = new Quaternion(0, 1, 0, 180);
    private Quaternion backwardDirecton = new Quaternion(0, 1, 0, 0);

    public int dogSize;
    public int dogHealth;
    public HealthbarSlider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnAroundTimer -= Time.deltaTime;
        if(turnAroundTimer <= 0)
        {
            transform.rotation = backwardDirecton;
        }
        else
        {
            transform.rotation = forwardDirecton;
        }

        //healthSlider.transform.position = transform.position + Vector3.up * 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Food_Bone(Clone)")
        {
            turnAroundTimer = 3;
        }
        else if(other.name == "Food_Steak(Clone)")
        {
            dogHealth ++;
            healthSlider.GainHealth(2/dogSize);
            if(dogHealth == dogSize)
            {
                Destroy(gameObject, 0.1f);
            }
        }
    }
}
