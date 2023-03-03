using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorTheWorld : MonoBehaviour
{
    Object[] allGameObjectss;

    [Serialize]
    public Color colorea;
    [Serialize]
    public bool findWithTag;
    [Serialize]
    public string ChooseTag;


    // Start is called before the first frame update
    void Start()
    {
        if(findWithTag==true)
        {
            allGameObjectss = GameObject.FindGameObjectsWithTag(ChooseTag);
        }
        else
        {
            allGameObjectss = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in allGameObjectss)
        {
            if (item.GetComponent<MeshRenderer>())
            {
                item.GetComponent<MeshRenderer>().material.color = colorea;
            }
        }
    }
}
