using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform targetPoint;
    public float moveSpeed = 120f;

    private bool isMoving = false;

    public void MoveToTarget()
    {
        isMoving = true;
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPoint.position,
                moveSpeed * Time.deltaTime
            );

            if (transform.position == targetPoint.position)
            {
                isMoving = false;
            }
        }
    }
}