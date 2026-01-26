using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public SituationTrigger[] allTriggers;

    void Start()
    {
        UpdateStoryFlow();
    }

    public void UpdateStoryFlow()
    {
        var tracker = AnswerTracker.Instance;

        foreach (SituationTrigger trigger in allTriggers)
        {
            var data = trigger.situation;

            bool canActivate =
                tracker.empathy >= data.requiredEmpathy &&
                tracker.aggression >= data.requiredAggression;

            trigger.gameObject.SetActive(canActivate);
        }
    }
}
