using UnityEngine;
using UnityEngine.SceneManagement;

public class MorteDoPLayer : MonoBehaviour
{
    // Nome da cena para reiniciar quando morrer
    public string sceneToLoad = "SampleScene"; // coloque o nome da sua cena de jogo

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cano"))
        {
            Die();
        }
    }

    // Se usar Trigger:
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cano"))
        {
            Die();
        }
    }

    void Die()
    {
        // Aqui você pode colocar animação, som, etc
        Debug.Log("Morreu!");
        SceneManager.LoadScene(sceneToLoad);
    }
}