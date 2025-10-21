using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Moeda se move para a esquerda junto com o cenário
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroi se sair da tela
        if (transform.position.x < -10f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManeger.instance.AddCoin();
            Destroy(gameObject);
        }
    }
}
