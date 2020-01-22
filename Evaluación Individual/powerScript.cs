using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerScript : MonoBehaviour
{
    public int collisionCount;
    public int energy;
public int dinero;
    public Text texto;
    public Text energia;
	public Text money;
    public Button boton;
public GameObject typec;
public int eskere;
public GameObject[] respawns;



    void Start()
    {
        collisionCount = 0;
        energy = 0;
		dinero = 5;
        
 	boton.onClick.AddListener(OnClick);

    }

    
    void OnCollisionStay(Collision collision)
    {


        if (collision.gameObject.tag == "Coin")
        {

			


        	if (Input.GetKeyDown(KeyCode.F))
        	{
          		Debug.Log(energy);
            	collision.gameObject.transform.localScale -= new Vector3(energy*0.05f, energy*0.05f, energy*0.05f);
			collisionCount--;
			texto.text = collisionCount.ToString();
        	}
    
    	}



		


        
        else
        if (collision.gameObject.tag == "Mummy")
        {
			collisionCount++;
			texto.text = collisionCount.ToString();
			
			
            	respawns = GameObject.FindGameObjectsWithTag("C");
			
		    foreach (GameObject respawn in respawns)
		    {
		    	Debug.Log("eyy");
		        respawn.transform.position += new Vector3(0.001f*collisionCount,0.001f*collisionCount,0.001f*collisionCount);
		    }
		}

    	if (Input.GetKeyDown(KeyCode.G))
        {
          	Debug.Log(energy);
            collision.gameObject.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
			dinero++;
			money.text = dinero.ToString();
        }
    
    

    }
	

    void OnClick(){
		if(dinero > 0){
		dinero--;
		energy++;
		energia.text = energy.ToString();
		money.text = dinero.ToString();
		}

	}
}
