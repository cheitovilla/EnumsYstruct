using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorZombie {
    magenta,cyan, green, Lenght 
}


public enum BodyParts
{
    Cabeza, Brazo, Pierna, Culo, Pito, Lenght
}

public enum NameCiudadano
{
    Juan, Pedro, Mateo, Marcos, Judas, Teo, Wardijestrudis, Barrabas, Willian, Elkin, Abrahan, Santiago,
    Pablo, Cohelo, Daniela, Ramirez, Salomon, Sanson, Aquiles, Goliat, Lenght
}


public struct ZombieInfo
{
    public Color colorZombie;
    public BodyParts favoritePart;
}

public struct CiudadanoInfo {
    public int age;
    public NameCiudadano nameCiudadano;
}


