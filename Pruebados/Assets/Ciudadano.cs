using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour {

    public GameObject ciudadanoMesh;
    int age;
    NameCiudadano nameCiudadano;
    // Use this for initialization
    void Start() {
        ciudadanoMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
        nameCiudadano = (NameCiudadano)Random.Range(0, (int)NameCiudadano.Lenght);
        age = Random.Range(15, 100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public CiudadanoInfo GetInfo()
    {
        CiudadanoInfo info = new CiudadanoInfo()
        {
            age = age,
            nameCiudadano = nameCiudadano
        };
        return info;
    }

}
