using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManeger : MonoBehaviour
{
    public static GameManeger instance;
    public int score = 0;
    public int coins = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI CoinsTXT;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void AddCoin()
    {
        coins++;
        CoinsTXT.text = "Coins: " + coins;
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        CoinsTXT.text = "Coins: " + coins;
    }
}


