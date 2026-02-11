using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    private ResultManager resultManager;
    private PlayerStats stats;

    void Start()
    {
        // ✅ Cache references once (Best Practice)
        resultManager = FindFirstObjectByType<ResultManager>();
        stats = FindFirstObjectByType<PlayerStats>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (stats != null)
            stats.TakeDamage();

        Debug.Log("Player Health = " + health);

        // ✅ AUTO RESULT TRIGGER
        if (health <= 0)
        {
            Debug.Log("AUTO RESULT TRIGGERED");

            if (resultManager != null)
                resultManager.ShowResult();

            gameObject.SetActive(false);
        }
    }
}