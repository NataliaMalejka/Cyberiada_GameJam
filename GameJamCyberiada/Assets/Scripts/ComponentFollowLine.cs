using UnityEngine;

public class ComponentFollowLine : MonoBehaviour
{
    public DrawingWithMouse drawingControll;
    public float speed = 10f;

    Vector3[] positions;
    bool startMovement = false;
    int movementIndex = 0;

    private void OnMouseDown()
    {
        drawingControll.StartLine(transform.position);
    }

    private void OnMouseDrag()
    {
        drawingControll.UpdateLine();
    }

    private void OnMouseUp()
    {
        positions = new Vector3[drawingControll.line.positionCount];

        for (int i = 0; i < drawingControll.line.positionCount; i++)
        {
            positions[i] = drawingControll.line.GetPosition(i);
        }

        startMovement = true;
        movementIndex = 0;
    }

    private void Update()
    {
        if (startMovement == true)
        {
            Vector2 currentPos = positions[movementIndex];
            transform.position = Vector2.MoveTowards(transform.position, currentPos, speed * Time.deltaTime);

            //Vector2 dir = currentPos - (Vector2)transform.position;
            //float angle = Mathf.Atan2(dir.normalized.y, dir.normalized.x);
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg + 90f), speed);

            float distance = Vector2.Distance(currentPos, transform.position);
            if (distance <= 0.05f)
            {
                movementIndex++;
            }

            if (movementIndex > positions.Length - 1)
            {
                startMovement = false;
            }
        }
    }
}
