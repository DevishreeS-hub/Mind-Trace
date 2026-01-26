using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 2f;
    public float patrolDistance = 3f;

    private Vector3 startPosition;
    private int direction = 1;
    private bool canMove = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (!canMove) return;

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (Vector2.Distance(startPosition, transform.position) >= patrolDistance)
        {
            direction *= -1; // change direction
            Flip();
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    public void StopMovement()
    {
        canMove = false;
    }

    public void ResumeMovement()
    {
        canMove = true;
    }
}
