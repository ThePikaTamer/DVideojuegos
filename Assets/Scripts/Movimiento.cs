using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Serialize]
    public int speed=5;

    int counter = 0;

    //Transform[] allKids;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        RemoveBagon();
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Time.deltaTime * Vector3.up * speed;
        }
    }

    private void RemoveBagon()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (counter == 0) 
            {
                Transform removedWagon = transform.Find("Bagon (1)");
                removedWagon.parent = null;
                counter++;
            }
            else if (counter == 1)
            {
                Transform removedWagon = transform.Find("Bagon");
                removedWagon.parent = null;
                counter++;
            }
            /*
            foreach (Transform child in this.transform)
            {
                Debug.Log("THere! " + child.name);
                if (child.name != "Heart"|| child.name != "F")
                {
                    Debug.Log("removed " + child.name);
                    child.parent = null;
                }
            }*/
        }
    }

}
