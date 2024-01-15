using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenuButtonAndSave : MonoBehaviour
{
    private int currentSceneIndex;

    public void ExitToMenu1()
    {
        
        
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadSceneAsync(0);

        
    }
}
