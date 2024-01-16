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

    // M�thode appel�e lors du bouton "Retry"
    public void RetryButtonClicked()
    {
        if (scoreManager != null)
        {
            scoreManager.ResetScore(); // R�initialiser le score avant de recharger la sc�ne du jeu
        }
        else
        {
            Debug.LogError("ScoreManager non initialis� dans Death.");
        }

        SceneManager.LoadScene(1);
    }
}
