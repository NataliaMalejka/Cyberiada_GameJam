using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] private int[] lights;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    private void OnMouseDown()
    {
        if(spriteRenderer.color == Color.red)
            spriteRenderer.color = Color.green;
        else
            spriteRenderer.color = Color.red;

        for (int i = 0; i < lights.Length; i++) 
        {

        }
    }
}
