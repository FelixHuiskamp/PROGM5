using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject prefab;
    private void CreateBall()
    {
        Instantiate(prefab);
    }

    private float elapsedTime = 0f;
    public void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            CreateBall();
            elapsedTime = 0f;
        }
    }

    private void CreateBall(Color c)
    {

        GameObject ball = Instantiate(prefab);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
    }



}