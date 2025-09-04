using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{

    public void GoToFinal()
    {
        SceneManager.LoadScene("Final"); // Nome da sua cena final
        Debug.Log("Mudando para a cena Final...");
     
    }
}