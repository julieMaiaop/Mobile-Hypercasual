using UnityEngine;
using UnityEngine.SceneManagement;
public class BotaoMenu : MonoBehaviour
{
    // Esse método será chamado pelo botão
    public void CarregarMenu()
    {
        SceneManager.LoadScene("Menu"); // Nome da cena que você quer carregar
    }
}