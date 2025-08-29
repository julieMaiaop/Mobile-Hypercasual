using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas
public class MenuController : MonoBehaviour
{
    // Fun��o para o bot�o Play
    public void PlayGame()
    {
        // Troca para a cena do jogo (coloque o nome da sua cena do jogo)
        SceneManager.LoadScene("SampleScene");
    }

    // Fun��o para o bot�o Exit
    public void ExitGame()
    {
        Debug.Log("Exit!");
        Application.Quit(); // Fecha o jogo
    }
}