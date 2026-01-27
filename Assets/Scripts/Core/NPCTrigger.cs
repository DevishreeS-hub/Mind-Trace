using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public NPCDialogueData dialogue;   // this is what was missing

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

            if (NPCDialogueUI.Instance != null && dialogue != null)
            {
                NPCDialogueUI.Instance.ShowDialogue(dialogue);
            }
            else
            {
                Debug.LogError("NPCDialogueUI or Dialogue is missing!");
            }
        }
    }
}
