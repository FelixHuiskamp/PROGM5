using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float health = 3f;  
    public float speed = 2f;
    public float movementDistance = 5f;

    private bool movingRight = true;
    private Vector3 startingPosition;

    private bool isAlive = true;


    protected virtual void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (isAlive)
        {
            Move();
        }
    }

    
    protected virtual void Move()
    {
        if (movingRight)
        {
            
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, startingPosition) >= movementDistance)
            {
                movingRight = false; 
            }
        }
        else
        {
            
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, startingPosition) <= 0)
            {
                movingRight = true; 
            }
        }
    }

    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    
    protected virtual void Die()
    {
        isAlive = false;
        
        Destroy(gameObject); 
    }
}
