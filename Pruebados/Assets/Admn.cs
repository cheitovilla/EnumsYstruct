using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admn : MonoBehaviour
{
    Hero hero;
    Zombie zombie;
   // Zombie zombie;

    void Start() {
        int s = 0;
        int r = Random.Range(10, 20);
        for (int i = 0; i < r; i++)
        {
            switch (s) {
                case 0:
                    new Hero();
                    hero.tag = "Hero";
                    return;
                case 1:
                    new Zombie();
                    hero.tag = "Zombie";
                    return;
               
            }
        }


    }





}
