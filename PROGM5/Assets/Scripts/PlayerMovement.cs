using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f; 
    void Update()
    {
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
         
        transform.Translate(0, 0, moveZ);

        transform.Rotate(0, rotationY, 0);
    }
}
