using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu1 : MonoBehaviour
{
    private int currentSceneIndex;

    public void ExitToMenu()
    {
        
        
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadSceneAsync(0);

        
    }
}
