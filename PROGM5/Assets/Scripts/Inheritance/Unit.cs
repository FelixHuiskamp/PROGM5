using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    [SerializeField]public int health = 100;  
    public int Health { get { return health; } }

   [SerializeField] public float speed = 2f;
   [SerializeField] public float movementDistance = 5f;

    private bool movingRight = true;
    private Vector3 startingPosition;

    private bool isAlive = true;

    
    protected void Start()
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
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("@@");

    }

    public virtual void Move()
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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Damage Genomen");
        TakeDamage(10); 
    }

    public void TakeDamage(int damage)
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
