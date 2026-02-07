using UnityEngine;
using TMPro;

public class NPCDialogueUI : MonoBehaviour
{
    public static NPCDialogueUI Instance;

    public CanvasGroup canvasGroup;
    public TextMeshProUGUI npcText;
    public NPCChoiceButton[] buttons;

    private void Awake()
    {
        Instance = this;
        Hide();
    }

    public void ShowDialogue(NPCDialogueData data)
{
    if (data == null)
    {
        Debug.LogError("Dialogue data is NULL!");
        return;
    }

    canvasGroup.alpha = 1;
    canvasGroup.interactable = true;
    canvasGroup.blocksRaycasts = true;

    npcText.text = data.npcText;

    // Hide all buttons first
    for (int i = 0; i < buttons.Length; i++)
    {
        buttons[i].gameObject.SetActive(false);
    }

    // Show only required buttons
    for (int i = 0; i < data.choices.Length; i++)
    {
        if (i < buttons.Length)
        {
            buttons[i].gameObject.SetActive(true);
            buttons[i].Setup(data.choices[i]);
        }
    }
}


    public void Hide()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void ShowResponse(string response)
    {
        npcText.text = response;

        foreach (var btn in buttons)
            btn.gameObject.SetActive(false);

        Invoke(nameof(Hide), 2f);
    }
}
