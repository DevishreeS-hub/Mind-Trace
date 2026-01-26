using UnityEngine;

[CreateAssetMenu(menuName = "MindTrace/Situation")]
public class SituationData : ScriptableObject
{
    [TextArea(4, 6)]
    public string situationText;

    public ChoiceData[] choices;

    public int requiredEmpathy;
    public int requiredAggression;
}

[System.Serializable]
public class ChoiceData
{
    public string choiceText;

    public int risk;
    public int empathy;
    public int patience;
    public int aggression;
}
