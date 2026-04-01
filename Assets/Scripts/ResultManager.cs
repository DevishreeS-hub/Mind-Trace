using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public GameObject resultPanel;

    public TMP_Text characterText;
    public TMP_Text rewardText;
    public TMP_Text suggestionText;
    public TMP_Text scoreText;

    private PlayerStats stats;

    void Start()
    {
        // ✅ SAFE MODERN FIND PLAYER STATS
        stats = FindFirstObjectByType<PlayerStats>();

        // ✅ AUTO FIND RESULT PANEL FROM SCENE
        resultPanel = GameObject.Find("ResultPanel");

        if (resultPanel != null)
            resultPanel.SetActive(false);
        else
            Debug.LogError("ResultPanel NOT FOUND IN SCENE");
    }

    public void ShowResult()
    {
        Debug.Log("SHOW RESULT CALLED");

        if (stats == null)
        {
            Debug.LogError("PlayerStats NOT FOUND");
            return;
        }

        if (resultPanel == null)
            resultPanel = GameObject.Find("ResultPanel");

        // 🎭 CHARACTER TYPE
        string characterType = stats.attackCount >= 20 ? "Warrior" :
                               stats.damageTaken <= 5 ? "Tank" :
                               "Balanced Player";

        // 🎁 REWARD
        string reward = stats.score >= 500 ? "Golden Sword" :
                        stats.rewardsCollected >= 5 ? "Treasure Box" :
                        "Silver Coin";

        // 💡 SUGGESTION
        string suggestion = characterType == "Warrior" ? "Improve speed and movement" :
                            characterType == "Tank" ? "Improve attack timing" :
                            "Balance attack and defense";

        // ✅ UI SAFE UPDATE
        if (characterText != null)
            characterText.text = "Character : " + characterType;

        if (rewardText != null)
            rewardText.text = "Reward : " + reward;

        if (suggestionText != null)
            suggestionText.text = "Suggestion : " + suggestion;

        if (scoreText != null)
            scoreText.text = "Score : " + stats.score;

        if (resultPanel != null)
            resultPanel.SetActive(true);

        // ⏸ Pause Game
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game Called");
        Application.Quit();
    }
}