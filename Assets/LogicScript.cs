using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore = 0;
    public Text ScoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = "Score: " + PlayerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
