using UnityEngine;

public class RainZone : MonoBehaviour
{


    public GameObject rainEffect;
    public GameObject darkScreen;
    public GameObject extraObstacles;

    private bool activated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!activated && other.CompareTag("Player"))
        {
            activated = true;
            if (rainEffect != null) rainEffect.SetActive(true);
            if (darkScreen != null) darkScreen.SetActive(true);
            if (extraObstacles != null) extraObstacles.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (activated && other.CompareTag("Player"))
        {
            activated = false;
            if (rainEffect != null) rainEffect.SetActive(false);
            if (darkScreen != null) darkScreen.SetActive(false);
            if (extraObstacles != null) extraObstacles.SetActive(false);
        }
    }
}