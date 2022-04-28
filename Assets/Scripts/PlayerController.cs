using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20f;
    private float boundaryX = 20.0f;
    private float lowerBoundaryZ = -5.0f;
    private float upperBoundaryZ = 20.0f;

    public int numOfSteaks;
    public float nextSteakTimer;
    private GameObject steake1;
    private GameObject steake2;
    private GameObject steake3;
    private GameObject steake4;
    private GameObject steake5;

    public GameObject projectilePrefabBone;
    public GameObject projectilePrefabSteak;
    public GameObject steakCounter;

    // Start is called before the first frame update
    void Start()
    {
        numOfSteaks = 5;
        nextSteakTimer = 5;
        // Generate 5 steaks at the side of the screen
        steake1 = Instantiate(steakCounter, steakCounter.transform.position, steakCounter.transform.rotation);
        steake2 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 1.0f, steakCounter.transform.rotation);
        steake3 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 2.0f, steakCounter.transform.rotation);
        steake4 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 3.0f, steakCounter.transform.rotation);
        steake5 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 4.0f, steakCounter.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if Player is out of bounds
        if(transform.position.x < -boundaryX)
        {
            transform.position = new Vector3(-boundaryX, transform.position.y, transform.position.z);
        }
        if(transform.position.x > boundaryX)
        {
            transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z);
        }
        if(transform.position.z < lowerBoundaryZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, lowerBoundaryZ);
        }
        if(transform.position.z > upperBoundaryZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, upperBoundaryZ);
        }

        // Move Player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        
        // Move Player up and down
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * horizontalInput * speed);

        // Launch objects from player
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch bone from player
            Instantiate(projectilePrefabBone, transform.position, projectilePrefabBone.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.N))
        {
            // Launch steak from player
            if(numOfSteaks > 0)
            {
                TrowSteak();
            }
        }

        // Control the number of steaks available to the player
        if(nextSteakTimer <= 0)
        {
            RegenerateSteak();
        }
        if(numOfSteaks < 5)
        {
            nextSteakTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Animal_Cow_White(Clone)")
        {
            if(numOfSteaks < 5)
            {
                RegenerateSteak();
            }
        }
    }

    // Delete the correct steak at the right of the screen then trow a steak in front of the player
    void TrowSteak()
    {
        switch(numOfSteaks)
        {
            case 5:
                Destroy(steake5);
                break;
            case 4:
                Destroy(steake4);
                break;
            case 3:
                Destroy(steake3);
                break;
            case 2:
                Destroy(steake2);
                break;
            case 1:
                Destroy(steake1);
                break;
            default:
                break;
        }
        Instantiate(projectilePrefabSteak, transform.position, projectilePrefabSteak.transform.rotation);
        numOfSteaks = numOfSteaks - 1;
    }
    // Restore one steak at the right of the screen
    void RegenerateSteak()
    {
        numOfSteaks += 1;
        nextSteakTimer = 5;
        switch(numOfSteaks)
        {
            case 5:
                steake5 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 4.0f, steakCounter.transform.rotation);
                break;
            case 4:
                steake4 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 3.0f, steakCounter.transform.rotation);
                break;
            case 3:
                steake3 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 2.0f, steakCounter.transform.rotation);
                break;
            case 2:
                steake2 = Instantiate(steakCounter, steakCounter.transform.position + Vector3.forward * 1.0f, steakCounter.transform.rotation);
                break;
            case 1:
                steake1 = Instantiate(steakCounter, steakCounter.transform.position, steakCounter.transform.rotation);
                break;
            default:
                break;
        }
    }
}
