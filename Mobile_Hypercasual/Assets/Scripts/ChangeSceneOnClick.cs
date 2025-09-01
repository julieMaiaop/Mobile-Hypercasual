using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneOnClick : MonoBehaviour
{
    public string Darkness; // Nome da cena para onde vai

    void OnMouseDown()
    {
        // Quando o objeto for clicado, troca de cena
        SceneManager.LoadScene(Darkness);
    }
}




