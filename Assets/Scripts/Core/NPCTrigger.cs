using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public string npcName;
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
            
            ui.ShowSituation(defaultDialogue, npcName);
            gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
}