using UnityEngine;

public class SituationTrigger : MonoBehaviour
{
    public SituationData situation;

    [SerializeField] private SituationManager manager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger touched by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger from " + situation.name + gameObject.name);
            gameObject.SetActive(false);

            if (manager != null)
            {
                manager.ShowSituation(situation);
                Time.timeScale = 0;
                Debug.Log("Situation shown");
            }
            else
            {
                Debug.LogError("SituationManager NOT found!");
            }
        }
    }
}
