using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatPendulo : MonoBehaviour
{
    public Transform Target;
    public float Speed;
    public float distanceBat;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {   
        if ( Vector2.Distance(transform.position, Target.position) > distanceBat)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }
    }
}
