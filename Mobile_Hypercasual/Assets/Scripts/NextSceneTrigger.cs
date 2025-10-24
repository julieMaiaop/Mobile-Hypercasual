using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneTrigger : MonoBehaviour
{
    [Header("Nome da cena para onde o player vai")]
    public string nextSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Encostou no cano final! Mudando de cena...");
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

