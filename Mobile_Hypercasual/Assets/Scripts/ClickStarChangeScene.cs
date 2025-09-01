using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickStarChangeScene : MonoBehaviour
{
    public string Final; // Nome da cena para ir

    private void OnMouseDown()
    {
        // Quando clicar no objeto com esse script, muda de cena
        SceneManager.LoadScene(Final);
    }
}