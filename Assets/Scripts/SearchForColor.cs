using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SearchForColor : MonoBehaviour
{
    //GameObject objetos;
    Object[] allGameObjectss;
    

    [Serialize]
    public Color colorea;

    [Serialize]
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        //this.name = nombre;
        //allGameObjectss = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
        /*
        Object objeto = GameObject.Find(nombre);*/
        allGameObjectss = GameObject.FindGameObjectsWithTag("Enemy");
        //objeto.GetComponent<MeshRenderer>().material.color = colorea;
    }

    // Update is called once per frame
    void Update()
    {
        /*foreach (var item in allGameObjectss)
        {
            if (item.GetComponent<MeshRenderer>())
            {
                item.GetComponent<MeshRenderer>().material.color = colorea;
            }
        }*/
        foreach (var item in allGameObjectss)
        {
            if (item.GetComponent<MeshRenderer>())
            {
                item.GetComponent<MeshRenderer>().material.color = colorea;
            }
        }
    }
}
