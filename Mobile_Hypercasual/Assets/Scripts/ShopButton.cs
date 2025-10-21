using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public GameObject shopPanel;

    public void OpenShop()
    {
        shopPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
