using UnityEngine;
using UnityEngine.UI;

public class GoldManager : MonoBehaviour
{
    public Text scoreText; // UI'deki puan text'i
    private int score = 0;

    // Puan ekleme fonksiyonu
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    // Puanı UI'de güncelleme
    private void UpdateScoreUI()
    {
        scoreText.text = ": " + score;
    }
}
