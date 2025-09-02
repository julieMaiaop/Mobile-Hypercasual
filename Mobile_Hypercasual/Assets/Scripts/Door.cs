using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] GameObject startScene, LoadScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            startScene.SetActive(false);
            LoadScene.SetActive(true);
        }
    }
}