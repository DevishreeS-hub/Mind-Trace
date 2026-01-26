using UnityEngine;
using TMPro;

public class NPCDialogueUI : MonoBehaviour
{
    public static NPCDialogueUI Instance;

    public GameObject panel;
    public TextMeshProUGUI npcText;
    public NPCChoiceButton[] buttons;

    private NPCDialogueData currentDialogue;

    private void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void ShowDialogue(NPCDialogueData data)
    {
        currentDialogue = data;
        panel.SetActive(true);

        npcText.text = data.npcText;

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].Setup(data.choices[i]);
        }
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}