using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{



    private Rigidbody rb;

void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        
        Vector3 movement = new Vector3 (Random.Range(-6F,6f), 0.0f, 	Random.Range(-6F,6F));
		
        rb.AddForce (movement * 30);
    }
}
