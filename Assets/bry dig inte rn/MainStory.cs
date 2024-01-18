using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Gemensam scen", LoadSceneMode.Single);
    }
}
