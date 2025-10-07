using UnityEngine;
using UnityEngine.UI;
public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance;
    public int coins = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UIManager.Instance.UpdateCoinText(coins);
    }

    public bool SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            UIManager.Instance.UpdateCoinText(coins);
            return true;
        }
        else
        {
            Debug.Log("Moedas insuficientes!");
            return false;
        }
    }
}