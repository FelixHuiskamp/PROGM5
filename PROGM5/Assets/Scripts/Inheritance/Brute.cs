using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        health = 10f; 
        speed = 1f;
        movementDistance = 3f; 
        base.Start();   
    }
}
