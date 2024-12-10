using UnityEngine;

public class WSADmoving : MonoBehaviour
{
    [SerializeField] private float velocity;
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(horizontalInput * velocity * Time.deltaTime, verticalInput * velocity * Time.deltaTime, 0);

        if(horizontalInput != 0)
            transform.localScale = new Vector3(4 * horizontalInput, 4, 1);
    }
}
