using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene2 : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(2); // 2 � o �ndice da cena no Build Settings
    }
}
