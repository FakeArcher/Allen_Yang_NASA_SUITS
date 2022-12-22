using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    // Declaring a public float variable for user input on the horizontal axis
    public float horizontalInput;

    // Variable for speed factor
    public float speed = 10.0f;
    
    // Variable for limiting player movement
    public float xRange = 10.0f;

    void Update()
    {
        // To check if player is moving past the left or right bounds respectively
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
