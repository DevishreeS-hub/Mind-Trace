using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 2f;
    public float leftPoint = -3f;
    public float rightPoint = 3f;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= rightPoint)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= leftPoint)
                movingRight = true;
        }
    }
}
