using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public float speed;
    
    void Start()

    {

        transform.position = new Vector3(0, 0, 0);

    }

    
    void Update()

    {
        if (transform.position.y >= 4.5f)

        {

            transform.position = new Vector3(transform.position.x, 4.5f, 0);

        }

        else if (transform.position.y <= -4.5f)

        {

            transform.position = new Vector3(transform.position.x, -4.5f, 0);

        }

        else if (transform.position.x <= -10.1f)

        {

            transform.position = new Vector3(-10.1f, transform.position.y, 0);

        }

        else if (transform.position.x >= 10.1f)

        {

            transform.position = new Vector3(10.1f, transform.position.y, 0);

        }

            
        transform.Translate(Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal"));

        transform.Translate(Vector3.up * Time.deltaTime * speed * Input.GetAxis("Vertical"));
    }
}
