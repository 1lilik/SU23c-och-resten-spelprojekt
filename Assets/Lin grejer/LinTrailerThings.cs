using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LinTrailerThings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string sceneLoad = "lin trailer scen grej";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
