using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public NPCDialogueData dialogue;

    private bool hasTalked = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasTalked) return;

        if (other.CompareTag("Player"))
        {
            hasTalked = true;

            NPCDialogueUI.Instance.ShowDialogue(dialogue);
        }
    }
}