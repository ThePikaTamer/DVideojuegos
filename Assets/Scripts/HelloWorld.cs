using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    const int MAxEnemies = 10;
    Enemy[] lEn= new Enemy[MAxEnemies];
    void Start()
    {
        Debug.Log("You where expecting a debug message but it was me, "+this.name+"!");
        Player pl1 = new Player("Alear");
        //Enemy en1 = new Enemy("Sombrom");
        for(int i=0; i<MAxEnemies;i++)
        {
            Enemy en1 = new Enemy("Char"+i);
            lEn[i] = en1;
        }


        Debug.Log("Faia emburem, engage");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello " + this.name);

        Debug.Log("You where expecting a debug message but it was me, "+this.name+"!");
        Debug.LogWarning("You where expecting a warning message pero era yo, "+this.name+"!");
        Debug.LogError("You where expecting a log error demo, kono "+this.name+" da!");
    }
}
