using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneButton : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(3); // 3 � o �ndice da cena no Build Settings
    }
}
