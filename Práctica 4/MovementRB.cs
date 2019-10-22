using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRB : MonoBehaviour
{
    public float speed = 10;
    public int counter = 0;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
	   Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        //rend.material.shader = Shader.Find("_");
        rend.material.SetColor("_Color", Color.white);

        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 	moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Sphere")
        {
            counter++;
            Debug.Log("Contador de colisiones: " + counter);
        }
Debug.Log("Entrando");
 Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        //rend.material.shader = Shader.Find("_");
        rend.material.SetColor("_Color", Color.blue);

    }

     /*private void OnCollisionEnter(Collision other)
    {
            Debug.Log("Entrando");
 Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        //rend.material.shader = Shader.Find("_");
        rend.material.SetColor("_Color", Color.blue);
        
    }*/

	
	private void OnTriggerStay(Collider other){
Renderer rend = GetComponent<Renderer>();
		 Debug.Log("Permaneciendo");
rend.material.SetColor("_Color", Color.red);
	}

	private void OnTriggerExit(Collider other){
Renderer rend = GetComponent<Renderer>();
		 Debug.Log("Saliendo");
rend.material.SetColor("_Color", Color.green);
	}

}
