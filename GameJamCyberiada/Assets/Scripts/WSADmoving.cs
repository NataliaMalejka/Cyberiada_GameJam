using UnityEngine;

public class WSADmoving : MonoBehaviour
{
    [SerializeField] private float velocity;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * velocity * Time.deltaTime, 0, 0);
        transform.localScale = new Vector3(4 * horizontalInput, 4, 1);

    }
}
