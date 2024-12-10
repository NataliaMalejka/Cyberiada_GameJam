using UnityEngine;

public class LampScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool lit;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.grey;
        lit = false;
    }

    public void ChangeLight()
    {
        if (spriteRenderer.color == Color.grey)
        {
            spriteRenderer.color = Color.yellow;
            lit = true;
        }
        else
        {
            spriteRenderer.color = Color.grey;
            lit = false;
        }
    }

    public bool getLit()
    {
        return lit;
    }

    public void trunOff()
    {
        spriteRenderer.color = Color.grey;
        lit = false;
    }
}
