using UnityEngine;

public class PauseToggle : MonoBehaviour
{
    private bool isPaused = false;

    public void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1f; // volta ao normal
            isPaused = false;
            Debug.Log("Jogo retomado");
        }
        else
        {
            Time.timeScale = 0f; // pausa tudo
            isPaused = true;
            Debug.Log("Jogo pausado");
        }
    }
}