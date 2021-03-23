using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float StoppingDistance;
    public float detectionDistance;
    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > StoppingDistance && Vector2.Distance(transform.position, target.position) < detectionDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position,speed * Time.deltaTime);
        }
    }
}
