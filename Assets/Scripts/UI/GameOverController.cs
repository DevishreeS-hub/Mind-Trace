using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI riskText;
    public TextMeshProUGUI empathyText;
    public TextMeshProUGUI patienceText;
    public TextMeshProUGUI aggressionText;

    void Start()
    {
        gameObject.SetActive(false);
    }

    // CALL THIS when game ends
    public void ShowGameOver()
    {
        gameObject.SetActive(true);

        // Get values from AnswerTracker
        riskText.text = "Risk: " + AnswerTracker.Instance.risk;
        empathyText.text = "Empathy: " + AnswerTracker.Instance.empathy;
        patienceText.text = "Patience: " + AnswerTracker.Instance.patience;
        aggressionText.text = "Aggression: " + AnswerTracker.Instance.aggression;
    }

    public void OnRestartClicked()
    {
        SceneManager.LoadScene(0);
    }
}