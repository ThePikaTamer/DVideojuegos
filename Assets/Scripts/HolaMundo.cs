using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("You where expecting a debug message but it was me, " + this.name + "!");
        //Debug.Log("This is my child: " + this.GetComponentInChildren(name) + "!");
        //this.GetComponent<MeshRenderer>().materials.SetValue
    }
}
