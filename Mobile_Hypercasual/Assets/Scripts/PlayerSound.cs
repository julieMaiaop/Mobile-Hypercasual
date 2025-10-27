using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hitSound;     // som ao bater no cano
    public AudioClip coinSound;    // som ao pegar moeda

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Chamado quando encosta em algo com collider (ex: cano)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe")) // Tag dos canos
        {
            PlaySound(hitSound);
        }
    }

    // Chamado quando entra em trigger (ex: moedas)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin")) // Tag das moedas
        {
            PlaySound(coinSound);
        }
    }

    void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
            audioSource.PlayOneShot(clip);
    }
}
