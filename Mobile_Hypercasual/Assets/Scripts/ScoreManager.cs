using UnityEngine;
using TMPro; // Necessário para usar TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Arraste seu ScoreText aqui no Inspector
    private int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}



