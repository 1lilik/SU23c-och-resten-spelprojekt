using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int sceneIndex;
    public void DelaySwitchScene(float delay)
    {
        Invoke("SwitchScene", delay);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
