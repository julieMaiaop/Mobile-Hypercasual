using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public float speed = 2f;

    void Update()
    {
        // Movimento para a esquerda
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Se sair da tela, destruir
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}