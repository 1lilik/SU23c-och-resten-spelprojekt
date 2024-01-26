using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteraction : MonoBehaviour
{
    public string sceneToLoad = "(Continue)";

    public void OnButtonPressed()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
