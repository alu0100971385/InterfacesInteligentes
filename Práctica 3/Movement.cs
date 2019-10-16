using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 20;
    public int Rotate = 1;
    public Vector3 v = new Vector3();
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey("up"))
        {
            v.Set(0, 0, Speed);
            transform.Translate(v * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            v.Set(0, 0, -Speed);
            transform.Translate(v * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            v.Set(-Speed, 0, 0);
            transform.Translate(v * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            v.Set(Speed, 0, 0);
            transform.Translate(v * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0,10, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -10, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, -10, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 10, 0);
        }


    }

}
