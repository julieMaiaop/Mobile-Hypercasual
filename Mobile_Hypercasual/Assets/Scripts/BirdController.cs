using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f; // for�a do pulo
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // toque na tela
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // P�ssaro morreu
        Debug.Log("Game Over");
        Time.timeScale = 0; // pausa o jogo
    }
}
