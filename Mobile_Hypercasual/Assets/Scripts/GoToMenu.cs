using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void GoMenu()
    {
        Time.timeScale = 1f; // garante que o jogo n�o fique pausado
        SceneManager.LoadScene("Menu"); // nome exato da cena do menu
    }
}
