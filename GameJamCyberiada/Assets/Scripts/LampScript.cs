using UnityEngine;

public class LampScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.grey;
    }

    public void ChangeLight()
    {
        
    }
}
