using UnityEngine;
using TMPro;

public class NPCBehavior : MonoBehaviour
{
    public TextMeshProUGUI npcDialogueText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        ShowReaction();
    }

    void ShowReaction()
    {
        var tracker = AnswerTracker.Instance;

        if (tracker.empathy > tracker.aggression)
        {
            npcDialogueText.text = 
                "NPC: I trust you. You seem kind.";
        }
        else if (tracker.aggression > tracker.empathy)
        {
            npcDialogueText.text = 
                "NPC: Stay away from me!";
        }
        else
        {
            npcDialogueText.text = 
                "NPC: I am watching you.";
        }
    }
}
