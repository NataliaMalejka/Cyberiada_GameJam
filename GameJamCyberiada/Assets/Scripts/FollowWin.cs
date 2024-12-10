using System.Collections;
using UnityEngine;

public class FollowWin : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(wait());
            gameManager.toHub();
        }
    }

    IEnumerator wait()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(5);
    }
}
