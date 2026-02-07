using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public NPCDialogueData defaultDialogue;
public NPCDialogueUI ui;
    private bool hasTalked = false;
    private NPCMovement movement;

    void Start()
    {
        movement = GetComponent<NPCMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasTalked) return;

        if (other.CompareTag("Player"))
        {
            hasTalked = true;

            if (movement != null)
                movement.enabled = false;

            NPCDialogueData dialogueToShow = defaultDialogue;

            if (DialogueFlowManager.Instance.nextDialogue != null)
                dialogueToShow = DialogueFlowManager.Instance.nextDialogue;

            NPCDialogueUI.Instance.ShowDialogue(dialogueToShow);
        }
    }
}