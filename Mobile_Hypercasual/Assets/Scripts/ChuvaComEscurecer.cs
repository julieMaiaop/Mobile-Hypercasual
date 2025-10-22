using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChuvaComEscurecer : MonoBehaviour
{
    public ParticleSystem chuva;       // Particle System da chuva
    public Image escurecerPainel;      // Imagem preta sobre a tela
    public float delay = 5f;           // Delay antes da chuva
    public float escurecerTempo = 3f;  // Tempo para escurecer totalmente

    void Start()
    {
        chuva.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        escurecerPainel.color = new Color(0, 0, 0, 0); // transparente no início
        StartCoroutine(AtivarChuvaEEscurecer());
    }

    IEnumerator AtivarChuvaEEscurecer()
    {
        yield return new WaitForSeconds(delay);

        // Ativa a chuva
        chuva.Play();

        // Escurecer aos poucos
        float t = 0;
        while (t < escurecerTempo)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Clamp01(t / escurecerTempo);
            // Atualiza a cor
            Color c = escurecerPainel.color;
            c.a = alpha;
            escurecerPainel.color = c;
            yield return null;
        }
    }
}