using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteraction : MonoBehaviour
{
    public string sceneToLoad = "NextScene";

    public void OnButtonPressed()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
