using UnityEngine;
using UnityEngine.SceneManagement;

public class YesButton : MonoBehaviour
{
    public string sceneToLoad = "BadEnding";

    public void OnButtonPressed()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
