using UnityEngine;
using UnityEngine.UI;

public class BuySkin : MonoBehaviour
{
    public Image playerImage;
    public Sprite newSkin;

    public void Buy()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0);
        if (coins >= 5)
        {
            coins -= 5;
            PlayerPrefs.SetInt("Coins", coins);
            PlayerPrefs.SetInt("SkinBought", 1);
            GameManeger.instance.CoinsTXT.text = "Coins: " + coins;
            playerImage.sprite = newSkin;
        }
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("SkinBought", 0) == 1)
        {
            playerImage.sprite = newSkin;
        }
    }
}



