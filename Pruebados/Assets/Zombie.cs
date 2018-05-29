using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Zombie z;
    public ZombieInfo zomb;
    GameObject zombieMesh;
    //ZombieInfo zombieParametres;
    //  [SerializeField]
    //  int age;

    BodyParts favoritePart;
    Color colorZombie;


    void Start()
    {

         

           zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
      //  print(/*info.age + */" / " + info.colorZombie + " / " + info.favoritePart.ToString());

   
//z.colorZombie = (ColorZombie)Random.Range(0, (int)ColorZombie.Lenght);
   //     z.favoritePart = (BodyParts)Random.Range(0, (int)BodyParts.Lenght);     
    }
    

    public ZombieInfo GetInfo()
{
        ZombieInfo info = new ZombieInfo()
        {

            colorZombie = colorZombie
    };
    return info;
}
}
