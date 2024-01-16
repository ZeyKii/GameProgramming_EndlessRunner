using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public int destroyedEnnemy;

    void Start()
    {
        UpdateScoreText();

    }

    void Update()
    {
        // Mettez � jour le score pendant le jeu si n�cessaire
    }

    public void IncrementScore()
    {
        destroyedEnnemy++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // Mettez � jour le texte du score
        ScoreText.text = "Score : " + destroyedEnnemy.ToString();
    }

    public void SaveScore()
    {
        // Sauvegarder le score
        PlayerPrefs.SetInt("Score", destroyedEnnemy);
        PlayerPrefs.Save();
    }

    public void ResetScore()
    {
        // R�initialiser le score � z�ro
        destroyedEnnemy = 0;
        UpdateScoreText();
    }
}
