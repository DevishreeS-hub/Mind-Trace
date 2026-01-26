using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SituationManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject panel;
    public TextMeshProUGUI situationText;
    public Button[] choiceButtons;

    private SituationData currentSituation;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void ShowSituation(SituationData situation)
    {
        currentSituation = situation;

        panel.SetActive(true);
        situationText.text = situation.situationText;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            if (i < situation.choices.Length)
            {
                choiceButtons[i].gameObject.SetActive(true);
                choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text =
                    situation.choices[i].choiceText;

                int index = i;
                choiceButtons[i].onClick.RemoveAllListeners();
                choiceButtons[i].onClick.AddListener(() =>
                    SelectChoice(situation.choices[index])
                );
            }
            else
            {
                choiceButtons[i].gameObject.SetActive(false);
            }
        }
    }

    void SelectChoice(ChoiceData choice)
    {
        AnswerTracker.Instance.RecordChoice(choice);
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}
