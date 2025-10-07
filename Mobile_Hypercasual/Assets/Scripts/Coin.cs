using UnityEngine;
public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CurrencyManager.Instance.AddCoins(coinValue);
            Destroy(gameObject); // some após coleta
        }
    }
}