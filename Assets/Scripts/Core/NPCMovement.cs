using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 2f;

    public Transform leftPoint;
    public Transform rightPoint;

    private Vector3 target;

    void Start()
    {
        target = rightPoint.position; // first move right
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );

        // reached target
        if (Vector3.Distance(transform.position, target) < 0.05f)
        {
            if (target == rightPoint.position)
                target = leftPoint.position;
            else
                target = rightPoint.position;
        }
    }
}