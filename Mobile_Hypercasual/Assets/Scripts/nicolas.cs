using UnityEngine;
using UnityEngine.SceneManagement;
public class nicolas : MonoBehaviour
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class NomeDoScript : MonoBehaviour
    {
        [SerializeField] string Final;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Estrelinha"))
            {
                Destroy(collision.gameObject);

                SceneManager.LoadScene(Final);
            }
        }
    }
}