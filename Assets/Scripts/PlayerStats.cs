using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int attackCount = 0;
    public int damageTaken = 0;
    public int rewardsCollected = 0;
    public int score = 0;

    public void AddAttack()
    {
        attackCount++;
        score += 10;
    }

    public void TakeDamage()
    {
        damageTaken++;
        score -= 5;
    }

    public void CollectReward()
    {
        rewardsCollected++;
        score += 50;
    }
}