using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance;
    public TextMeshProUGUI coinText; // <-- mudei aqui

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void UpdateCoinText(int coins)
    {
        coinText.text = coins.ToString();
    }
}