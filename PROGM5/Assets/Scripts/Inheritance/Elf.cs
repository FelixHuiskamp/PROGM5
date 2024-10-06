using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer elfRenderer; 

   
    void Start()
    {
        health = 2f;  
        speed = 5f;
        movementDistance = 8f; 
        elfRenderer = GetComponentInChildren<Renderer>(); 
        StartCoroutine(ToggleVisibility());
        base.Start();
    }

    
    private IEnumerator ToggleVisibility()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f); 
            elfRenderer.enabled = false;        
            yield return new WaitForSeconds(0.5f); 
            elfRenderer.enabled = true;         
        }
    }
}
