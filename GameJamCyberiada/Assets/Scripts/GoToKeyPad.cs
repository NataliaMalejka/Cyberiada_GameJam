using UnityEngine;

public class GoToKeyPad : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.toKeypad();
        Debug.Log("toKeyPad");
    }


}
