using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPCDialogueUI : MonoBehaviour
{
    [Header("UI References")]
    public GameObject panel;
    public TextMeshProUGUI situationText;
    public Button[] choiceButtons;

    public NPCTrigger npc_1;
    public NPCTrigger npc_2;
    public NPCTrigger npc_3;
    
    private NPCDialogueData currentSituation;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void ShowSituation(NPCDialogueData situation, string npcName)
    {
        currentSituation = situation;

        gameObject.SetActive(true);
        situationText.text = situation.npcText;

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            if (i < situation.choices.Length)
            {
                choiceButtons[i].gameObject.SetActive(true);
                choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text =
                    situation.choices[i].choiceText;

                int index = i;
                choiceButtons[i].onClick.RemoveAllListeners();
                choiceButtons[i].onClick.AddListener(() =>
                    SelectChoice(situation.choices[index], npcName)
                );
            }
            else
            {
                choiceButtons[i].gameObject.SetActive(false);
            }
        }
    }

    void SelectChoice(NPCChoice choice, string npcName)
    {
        if (npcName == npc_1.npcName)
        {
            npc_2.defaultDialogue = choice.nextDialogue;
        }else if (npcName == npc_2.npcName)
        {
            npc_3.defaultDialogue = choice.nextDialogue;
        }
        
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    
}
