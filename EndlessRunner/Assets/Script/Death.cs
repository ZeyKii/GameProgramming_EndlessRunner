using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager non assigné dans l'éditeur Unity.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            if (scoreManager != null)
            {
                scoreManager.SaveScore();
            }
            else
            {
                Debug.LogError("ScoreManager non initialisé dans Death.");
            }

            SceneManager.LoadScene(2);
        }
    }
}
