using UnityEngine;
using UnityEngine.SceneManagement;

public class Ebutton: MonoBehaviour
{
    public float maxDistance = 2f; // Відстань для взаємодії з кнопкою
    private int currentSceneIndex;

    void Update()
    {
        // Перевірте, чи натиснута клавіша 'F' та чи гравець достатньо близько до кнопки
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerCloseEnough())
        {
            ExitToMenu();
        }
    }

    public void ExitToMenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadSceneAsync(0);
    }

    // Функція для перевірки, чи гравець достатньо близько до кнопки.
    private bool IsPlayerCloseEnough()
    {
        // Замініть "Player" на реальний тег або шар вашого об'єкта гравця.
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            return distance <= maxDistance;
        }

        return false;
    }
}
