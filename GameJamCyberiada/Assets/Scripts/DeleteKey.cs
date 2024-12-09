using UnityEngine;
using UnityEngine.Events;

public class DeleteKey : MonoBehaviour
{
    [SerializeField] private UnityEvent deleteLats;
    [SerializeField] private Light light;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        light.enabled = false;
    }
    private void OnMouseDown()
    {
        deleteLats.Invoke();
        spriteRenderer.color = Color.yellow;
        light.enabled = true;     
    }

    private void OnMouseUp()
    {
        spriteRenderer.color = Color.white;
        light.enabled=false;
    }
}
