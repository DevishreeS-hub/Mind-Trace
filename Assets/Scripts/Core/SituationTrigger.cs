using UnityEngine;

public class SituationTrigger : MonoBehaviour
{
    public SituationData situation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger touched by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");

            SituationManager manager =
                FindObjectOfType<SituationManager>();

            if (manager != null)
            {
                manager.ShowSituation(situation);
                Debug.Log("Situation shown");
            }
            else
            {
                Debug.LogError("SituationManager NOT found!");
            }
        }
    }
}
