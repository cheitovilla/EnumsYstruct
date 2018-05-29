using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

   public GameObject heroMesh;
     
    void Start ()
    {
        DisplayMessage();
	}

    private void DisplayMessage()
    {
        heroMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        heroMesh.GetComponent<Renderer>().material.color = Color.black;
        heroMesh.transform.position = new Vector3(0,1,0);
        heroMesh.AddComponent<Camera>();
        heroMesh.AddComponent<FPSMove>();
        heroMesh.AddComponent<FPSAim>();
       // heroMesh.tag = "Hero";
       
        //Debug.Log("");
      
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag== "Zombie")
        {
            print("oli");
        }
    }

    

}
