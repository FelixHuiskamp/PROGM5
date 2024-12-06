using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : Unit, IMovable, IDamagable
{
    void Start()
    {
        health = 10; 
        speed = 1f;
        movementDistance = 3f; 
        base.Start();   
    }

    void Update() {
        Move();
        
    }

}
