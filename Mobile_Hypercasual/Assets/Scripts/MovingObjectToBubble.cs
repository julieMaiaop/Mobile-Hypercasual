using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObjectToBubble : MonoBehaviour
{
    public float speed = 2f;            // Velocidade do movimento
    public float moveDistance = 1f;     // Distância máxima de movimento
    public bool moveVertically = false; // Se verdadeiro, move pra cima e pra baixo

    private Vector3 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        if (moveVertically)
        {
            transform.position += Vector3.up * speed * direction * Time.deltaTime;
            if (Mathf.Abs(transform.position.y - startPos.y) >= moveDistance)
            {
                direction *= -1;
            }
        }
        else
        {
            transform.position += Vector3.right * speed * direction * Time.deltaTime;
            if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
            {
                direction *= -1;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Bubble");
        }
    }
}