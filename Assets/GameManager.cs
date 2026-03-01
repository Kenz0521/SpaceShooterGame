using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;

    public TextMeshProUGUI scoreText;

    public GameObject gameOverText;

    public GameObject restartButton;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;

        scoreText.text =
        "Score : " + score;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);

        restartButton.SetActive(true);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(
        SceneManager.GetActiveScene().name);
    }
}
