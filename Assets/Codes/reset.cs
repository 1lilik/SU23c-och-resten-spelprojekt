using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public float time = 15;
    private void OnEnable()
    {
        Invoke("GoToMenu", time);
    }
    private void GoToMenu()
    {
         SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
