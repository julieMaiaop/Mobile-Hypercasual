using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpForce = 5f;      // Força do pulo
    private Rigidbody2D rb;
    private bool isAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isAlive) return;

        // Pulo com clique esquerdo
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 newVelocity = rb.linearVelocity;
            newVelocity.y = jumpForce;
            rb.linearVelocity = newVelocity;
        }

        // Limite para não sair da tela (topo e base)
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -4f, 4f); // Ajuste conforme sua câmera
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Se bater em algo, morre (Game Over)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isAlive = false;
            Debug.Log("Game Over!");
            // Aqui podemos depois chamar uma tela de Game Over
        }
    }
}