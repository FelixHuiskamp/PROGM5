using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromCamera : MonoBehaviour
{
    public GameObject projectilePrefab; 
    private Plane floor;
    public int damage = 1;
    void Start()
    {
        floor = new Plane(Vector3.up, 0);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float dist;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (floor.Raycast(ray, out dist))
            {
                GameObject p = Instantiate(projectilePrefab, transform.position, transform.rotation);
                Vector3 tPos = ray.GetPoint(dist);
                p.transform.LookAt(tPos);
                p.AddComponent<MoveProj>();
                Destroy(p, 5f);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Unit enemy = other.GetComponent<Unit>(); 
        if (enemy != null)
        {
            enemy.TakeDamage(damage); 
            Destroy(gameObject); 
        }
    }
}
public class MoveProj : MonoBehaviour
{
    private float moveSpeed = 20f;
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
