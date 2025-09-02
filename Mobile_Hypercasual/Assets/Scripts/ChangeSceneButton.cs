using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneButton : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(3); // 3 é o índice da cena no Build Settings
    }
}
