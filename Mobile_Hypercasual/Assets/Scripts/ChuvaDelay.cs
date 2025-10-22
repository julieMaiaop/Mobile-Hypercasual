using UnityEngine;

public class ChuvaDelay : MonoBehaviour
{
    public GameObject chuva; // Arraste seu sistema de partículas aqui
    public float delay = 5f; // Delay em segundos

    void Start()
    {
        // Desativa a chuva no começo
        chuva.SetActive(false);
        // Inicia a coroutine que vai ativar a chuva
        StartCoroutine(AtivarChuvaDepoisDelay());
    }

    System.Collections.IEnumerator AtivarChuvaDepoisDelay()
    {
        yield return new WaitForSeconds(delay); // Espera o tempo definido
        chuva.SetActive(true); // Ativa a chuva
    }
}