using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica se é o Player
        {
            SceneManager.LoadScene(2); // Muda para a cena com índice 2
        }
    }
}