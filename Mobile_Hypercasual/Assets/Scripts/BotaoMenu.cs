using UnityEngine;
using UnityEngine.SceneManagement;
public class BotaoMenu : MonoBehaviour
{
    // Esse m�todo ser� chamado pelo bot�o
    public void CarregarMenu()
    {
        SceneManager.LoadScene("Menu"); // Nome da cena que voc� quer carregar
    }
}