using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string FirstName { get; private set; }

    //constructor
    public Character(string name)
    {
        FirstName = name;

        Debug.Log($"Hola, soy {name}");
    }

    //destructor
    ~Character()
    {
        Debug.Log("Destroyed");
    }
}
class Player : Character
{
    public Player(string name):base(name)
    {

    }
}

class Enemy : Character
{
    public Enemy(string name) : base(name)
    {

    }
}