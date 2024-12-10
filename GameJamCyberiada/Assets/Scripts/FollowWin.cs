using System.Collections;
using Assets.Scripts;
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
            flaga.maska3 = true;
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
