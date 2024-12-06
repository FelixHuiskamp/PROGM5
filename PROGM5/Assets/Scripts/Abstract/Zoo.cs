using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    List<Animal> Animals;
    void Start()
    {
       Animals = new List<Animal> {new Bird(), new Dog(), new Elephant()};
        foreach (Animal v in Animals)
        {
            v.Move();
            v.Eat();
        }
    }

}





