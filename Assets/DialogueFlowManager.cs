using UnityEngine;

public class DialogueFlowManager : MonoBehaviour
{
    public static DialogueFlowManager Instance;

    public NPCDialogueData nextDialogue;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
}
