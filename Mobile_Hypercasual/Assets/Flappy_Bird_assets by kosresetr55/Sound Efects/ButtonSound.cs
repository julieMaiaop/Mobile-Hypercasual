using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    void Start()
    {
        // Cria ou pega o AudioSource
        audioSource = FindAnyObjectByType<AudioSource>();
        if (audioSource == null)
        {
            GameObject audioObj = new GameObject("ButtonSoundSource");
            audioSource = audioObj.AddComponent<AudioSource>();
            DontDestroyOnLoad(audioObj);
        }

        // Adiciona o som no clique do botão
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(PlayClickSound);
        }
    }

    void PlayClickSound()
    {
        if (clickSound != null)
            audioSource.PlayOneShot(clickSound);
    }
}
