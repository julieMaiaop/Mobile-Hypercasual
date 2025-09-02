using UnityEngine;
using UnityEngine.UI; // Necess�rio se usar UI Text

public class CoinCollector : MonoBehaviour
{

    public int coins = 0;                   // Total de moedas coletadas
    public Text coinsText;                  // Refer�ncia ao texto da UI

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(other.gameObject);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        if (coinsText != null)
            coinsText.text = "Moedas: " + coins;
    }
}