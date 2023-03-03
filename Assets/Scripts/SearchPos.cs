using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchPos : MonoBehaviour
{
    int dir = 1;
    bool goUp = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LogPos();
        LogRot();
        LogScale();
        /**/

        //transform.position = new Vector3(0, 0, 1f);
        Movement();
        ChangeScale();

        Gravedad();

        Animar();
    }

    private void Gravedad()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.GetComponent<Rigidbody>().useGravity = true;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            this.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void LogScale()
    {
        Debug.Log("Escala X: " + this.GetComponent<Transform>().localScale.x);
        Debug.Log("Escala Y: " + this.transform.localScale.y);
        Debug.Log("Escala Z: " + this.transform.localScale.z);
    }

    private void LogRot()
    {
        Debug.Log("Rotacion X: " + this.GetComponent<Transform>().rotation.x);
        Debug.Log("Rotacion Y: " + this.transform.rotation.y);
        Debug.Log("Rotacion Z: " + this.transform.rotation.z);
    }

    private void LogPos()
    {
        Debug.Log("Posicion X: " + this.GetComponent<Transform>().position.x);
        Debug.Log("Posicion Y: " + this.transform.position.y);
        Debug.Log("Posicion Z: " + this.transform.position.z);
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Time.deltaTime * Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Time.deltaTime * Vector3.back;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Time.deltaTime * Vector3.up;
        }
    }
    private void ChangeScale()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale+=Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale += Vector3.back;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale += Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale += Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale += Vector3.down;
        }
    }

    private void Animar()
    {
        /*if (goUp && this.transform.position.x < 8)
        {
            transform.position += 0.01f * Vector3.right;
            if (this.transform.position.x > 8)
            {
                goUp = false;
            }
        }

        else if (!goUp && this.transform.position.x > 0)
        {
            transform.position -= 0.01f * Vector3.right;
            if (this.transform.position.x < 0)
            {
                goUp = true;
            }
        }*/

        //transform.rotation *= Quaternion.Euler(0,1,0);
        transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);

        //transform.position += new Vector3(0.01f*dir,0,0);
    }

    private void AnimaTime()
    {

    }

}
