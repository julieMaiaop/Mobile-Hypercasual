using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas
public class MenuController : MonoBehaviour
{
    // Função para o botão Play
    public void PlayGame()
    {
        // Troca para a cena do jogo (coloque o nome da sua cena do jogo)
        SceneManager.LoadScene("SampleScene");
    }

    // Função para o botão Exit
    public void ExitGame()
    {
        Debug.Log("Exit!");
        Application.Quit(); // Fecha o jogo
    }
}