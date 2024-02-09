using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("GoToMenu", 15);
    }
    private void GoToMenu()
    {
         SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
