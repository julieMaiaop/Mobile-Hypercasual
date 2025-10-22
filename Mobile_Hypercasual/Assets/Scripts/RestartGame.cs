using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f; // garante que o tempo volte ao normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
