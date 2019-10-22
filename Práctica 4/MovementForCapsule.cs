using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForCapsule : MonoBehaviour
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

        float moveHorizontal = 0;
        float moveVertical = 0;
	   if(Input.GetKey(KeyCode.I)){
		 moveVertical = 1;
	   }
	   if(Input.GetKey(KeyCode.J)){
		 moveHorizontal = -1;
	   }

	   if(Input.GetKey(KeyCode.L)){
		 moveHorizontal = 1;
	   }
	   if(Input.GetKey(KeyCode.M)){
		 moveVertical = -1;
	   }



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
    }

     private void OnTriggerEnter(Collider other)
    {
            Debug.Log("Entrando");
 Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        //rend.material.shader = Shader.Find("_");
        rend.material.SetColor("_Color", Color.blue);
        
    }

	
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


