using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colore : MonoBehaviour
{
    public Color colorea;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola soy " + this.name);
        this.GetComponent<MeshRenderer>().material.color = colorea;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
