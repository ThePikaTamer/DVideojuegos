using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Juego
{
    public class Juego_HelloWorld : MonoBehaviour
    {
        // Start is called before the first frame update
        private Player player;
        private List<Enemy> enemies;

        void Start()
        {
            Player pl1 = new Player("Alear");
            //Enemy en1 = new Enemy("Sombrom");
            enemies = new List<Enemy>();
            enemies.Add(new Enemy("Cha"));
            enemies.Add(new Enemy("rac"));
            enemies.Add(new Enemy("ter"));
        }

        // Update is called once per frame
        void Update()
        {
            /*foreach (Enemy item in enemies)
            {
                if(item.FirstName=="rac")
                {
                    Debug.Log("THere");
                }
            }*/

            /*var enemy = enemies.First(e => e.FirstName == "rac");
            Debug.Log("THere! "+enemy);*/
        }
    }
}

