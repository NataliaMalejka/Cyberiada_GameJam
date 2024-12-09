using UnityEngine;
using UnityEngine.Events;

public class Confirmkey : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private UnityEvent confirmPassword;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        light.enabled = false;
    }

    private void OnMouseDown()
    {
        confirmPassword.Invoke();
        spriteRenderer.color = Color.yellow;
        light.enabled = true;
    }

    private void OnMouseUp()
    {
        spriteRenderer.color = Color.white;
        light.enabled = false;
    }
}
