using UnityEngine;
using UnityEngine.UI;

public class BuySkin : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Sprite newSkin;

    public void Buy()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0);

        if (coins >= 5)
        {
            coins -= 5;
            PlayerPrefs.SetInt("Coins", coins);
            PlayerPrefs.SetInt("SkinBought", 1);

            GameManeger.instance.coins = coins;
            GameManeger.instance.CoinsTXT.text = "Coins: " + coins;

            playerSprite.sprite = newSkin; // muda skin na hora
        }
        else
        {
            Debug.Log("Moedas insuficientes!");
        }
    }

    private void Start()
    {
        // Se a skin já foi comprada antes, mantém ela
        if (PlayerPrefs.GetInt("SkinBought", 0) == 1)
        {
            playerSprite.sprite = newSkin;
        }
    }
}




