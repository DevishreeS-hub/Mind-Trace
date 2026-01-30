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
        DecisionTracker.Instance.RegisterDecision(
            choice.risk,
            choice.empathy,
            choice.logic,
            choice.patience
        );

        // Store next dialogue
        if (choice.nextDialogue != null)
        {
            DialogueFlowManager.Instance.nextDialogue = choice.nextDialogue;
        }

        NPCDialogueUI.Instance.ShowResponse(choice.npcResponse);
    }
}
