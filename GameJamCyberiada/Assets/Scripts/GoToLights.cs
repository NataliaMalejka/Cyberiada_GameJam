using UnityEngine;

public class GoToLights : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.toLights();
        Debug.Log("toLights");
    }
}
