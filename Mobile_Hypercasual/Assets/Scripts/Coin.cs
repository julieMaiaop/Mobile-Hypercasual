using UnityEngine;
public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Quanto a moeda vale

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Encontra o ScoreManager e adiciona pontos
            FindObjectOfType<ScoreManager>().AddScore(coinValue);

            // Destroi a moeda quando o player pega
            Destroy(gameObject);
        }
    }
}