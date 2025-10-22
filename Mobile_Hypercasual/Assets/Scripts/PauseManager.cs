using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel; // Arraste o painel aqui no Inspector
    private bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;
        pausePanel.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f; // pausa o jogo
    }

    public void Resume()
    {
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}