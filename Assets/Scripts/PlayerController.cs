using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script controls the vehicle's movement.
*/
public class PlayerController : MonoBehaviour
{
    // Initialize variables
    private float speed = 10.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;
    private bool canRotate = false;

    void LateUpdate() 
    {
        // Check if the vehicle is moving. If moving allow rotation.
        if (forwardInput != 0){
            canRotate = true;
        } else {
            canRotate = false;
        }

        // Get player input for controls
        forwardInput = Input.GetAxis("Vertical"); 
        horizontalInput = Input.GetAxis("Horizontal"); 

        // Moves the vehicle forward or backwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // If the vehicle is moving, rotate vehicle
        if (canRotate) {
            // Rotates car based on horizontal input
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
