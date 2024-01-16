using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToGame : MonoBehaviour
{
    public Button playButton;
    private ScoreManager scoreManager;

    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
    }

    void PlayGame()
    {
        RetryButtonClicked();
    }

    // Méthode appelée lors du bouton "Retry"
    public void RetryButtonClicked()
    {
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // Réinitialiser le score avant de recharger la scène du jeu
        }
        else
        {
            Debug.LogError("ScoreManager non initialisé dans Death.");
        }

        SceneManager.LoadScene(1);
    }
}
