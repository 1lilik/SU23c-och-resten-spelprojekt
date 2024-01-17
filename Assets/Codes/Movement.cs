using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
//using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
        }
        //if (Input.GetKey(KeyCode.Escape))
        {

          //  SceneManager.LoadSceneAsync(0);
        }
    }


}






