using UnityEngine;
using UnityEngine.UI;
public class ShopItem : MonoBehaviour
{
    public string itemID; // Ex: "SkinBlue"
    public int price = 20;
    public Button buyButton;

    private void Start()
    {
        buyButton.onClick.AddListener(BuyItem);
    }

    void BuyItem()
    {
        if (CurrencyManager.Instance.SpendCoins(price))
        {
            Debug.Log("Item comprado: " + itemID);
            PlayerSkinManager.Instance.UnlockSkin(itemID);
        }
        else
        {
            Debug.Log("Moedas insuficientes!");
        }
    }
}
