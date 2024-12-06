using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Unit, IMovable, IDamagable
{
   public float moveSpeed = 5f;
    public float rotationSpeed = 10f; 
   public void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    public void Update() {
        Move();
    }
    
}
