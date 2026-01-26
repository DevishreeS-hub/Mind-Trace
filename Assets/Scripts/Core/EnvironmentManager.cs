using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        var tracker = AnswerTracker.Instance;

        if (tracker.aggression > 3)
            mainCamera.backgroundColor = Color.red;
        else if (tracker.empathy > 3)
            mainCamera.backgroundColor = Color.green;
        else
            mainCamera.backgroundColor = Color.gray;
    }
}
