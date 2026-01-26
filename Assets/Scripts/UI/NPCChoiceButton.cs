using UnityEngine;
using TMPro;

public class NPCChoiceButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    private NPCChoice choice;

    public void Setup(NPCChoice data)
    {
        choice = data;
        buttonText.text = data.choiceText;
    }

    public void OnClick()
    {
        // Update player psychology
        DecisionTracker.Instance.RegisterDecision(
            choice.risk,
            choice.empathy,
            choice.logic,
            choice.patience
        );

        Debug.Log("NPC Response: " + choice.npcResponse);

        NPCDialogueUI.Instance.Hide();
    }
}