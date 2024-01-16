using UnityEngine;
using TMPro;

public class GameOverScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assurez-vous d'utiliser TextMeshProUGUI pour une meilleure qualit� de texte

    void Start()
    {
        DisplayScore();
    }

    void DisplayScore()
    {
        // R�cup�rez le score sauvegard�
        int savedScore = PlayerPrefs.GetInt("Score", 0);

        // Affichez le score dans le Text
        scoreText.text = "Score : " + savedScore.ToString();
    }
}
