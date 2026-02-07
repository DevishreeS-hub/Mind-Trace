using UnityEngine;

public class AnswerTracker : MonoBehaviour
{
    public static AnswerTracker Instance;

    public int risk;
    public int empathy;
    public int patience;
    public int aggression;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void RecordChoice(ChoiceData choice)
    {
        risk += choice.risk;
        empathy += choice.empathy;
        patience += choice.patience;
        aggression += choice.aggression;
    }

    public void RecordChoice(NPCChoice choice)
    {
        
    }
}
