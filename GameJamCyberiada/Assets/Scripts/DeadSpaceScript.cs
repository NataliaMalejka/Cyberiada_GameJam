using UnityEngine;

public class DeadSpaceScript : MonoBehaviour
{
    [SerializeField] private Vector3 position;
    [SerializeField] private GameObject player;

    //private DrawingWithMouse drawingWithMouse;
    //private ComponentFollowLine followLine;

    private void Start()
    {
        //drawingWithMouse = FindObjectOfType<DrawingWithMouse>();
        //followLine = FindObjectOfType<ComponentFollowLine>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = position;
        }

        //drawingWithMouse.deleteLine(position);
        //followLine.setStartMovement();
    }
}
