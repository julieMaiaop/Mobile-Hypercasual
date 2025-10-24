using UnityEngine;
using UnityEngine.SceneManagement;


public class EndLevelMoving : MonoBehaviour
{
    public float speed = 2f;                 // Velocidade do movimento (igual dos canos)
    public string nextSceneName = "Bubble";  // Cena para onde vai ao encostar no player
    public float destroyX = -10f;            // Posição X para destruir o objeto (fora da tela)

    void Update()
    {
        // Move o objeto para a esquerda o tempo todo
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Destroi o objeto se ele sair da tela
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Quando o player encosta, muda pra cena "Bubble"
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
