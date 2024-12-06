using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    public abstract void Move();

    public void Eat()
    {
        Debug.Log("Nom nom!!"); 
    }

}
