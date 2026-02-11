using UnityEngine;

[CreateAssetMenu(fileName = "NewNPCDialogue", menuName = "MindTrace/NPC Dialogue")]
public class NPCDialogueData : ScriptableObject
{
    [TextArea(3, 6)]
    public string npcText;

    public NPCChoice[] choices;
}

[System.Serializable]
public class  NPCChoice
{
    public string choiceText;

    public int empathy;
    public int logic;
    public int risk;
    public int patience;
    public int aggression;

    [TextArea(2, 4)]
    public string npcResponse;

    public NPCDialogueData nextDialogue;   // 🔥 THIS IS IMPORTANT
}
