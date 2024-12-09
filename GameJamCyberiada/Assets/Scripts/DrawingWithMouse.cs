using UnityEngine;

public class DrawingWithMouse : MonoBehaviour
{
    public LineRenderer line;
    private Vector3 previousPosition;

    [SerializeField] private float minDistance = 0.1f;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 0; 

        line.startWidth = 0.1f; 
        line.endWidth = 0.1f;   
    }

    public void StartLine(Vector2 position)
    {
        line.positionCount = 1;
        line.SetPosition(0, position);
    }
    public void UpdateLine()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 startPosition = GetMouseWorldPosition();
            line.positionCount = 1;
            line.SetPosition(0, startPosition);
            previousPosition = startPosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 currentPosition = GetMouseWorldPosition();

            if (Vector3.Distance(currentPosition, previousPosition) > minDistance)
            {
                line.positionCount++;
                line.SetPosition(line.positionCount - 1, currentPosition);
                previousPosition = currentPosition;
            }
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z); 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f; 
        return worldPosition;
    }

}
