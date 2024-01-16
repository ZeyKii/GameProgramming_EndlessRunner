using UnityEngine;
using TMPro;

public class GameOverScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assurez-vous d'utiliser TextMeshProUGUI pour une meilleure qualité de texte

    void Start()
    {
        DisplayScore();
    }

    void DisplayScore()
    {
        // Récupérez le score sauvegardé
        int savedScore = PlayerPrefs.GetInt("Score", 0);

        // Affichez le score dans le Text
        scoreText.text = "Score : " + savedScore.ToString();
    }
}
