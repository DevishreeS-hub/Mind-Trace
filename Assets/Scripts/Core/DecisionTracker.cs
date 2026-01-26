using UnityEngine;

public class DecisionTracker : MonoBehaviour
{
    public static DecisionTracker Instance;

    public MindProfile profile = new MindProfile();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void RegisterDecision(int risk, int empathy, int logic, int patience)
    {
        profile.risk += risk;
        profile.empathy += empathy;
        profile.logic += logic;
        profile.patience += patience;

        Debug.Log($"Updated Profile → Risk:{profile.risk}, Empathy:{profile.empathy}");
    }
}