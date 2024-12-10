using System.Collections;
using Assets.Scripts;
using UnityEngine;

public class LampManager : MonoBehaviour
{
    [SerializeField] private LampScript[] lamps;
    private int lampLitCounter;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public LampScript GetLamp(int number)
    {
        return lamps[number];
        //lampLitCounter = 0;
    }

    public void CheckSolution()
    {
        lampLitCounter = 0;

        for (int i = 0; i < lamps.Length; i++)
        {
            if(lamps[i].getLit())
            {
                lampLitCounter++;
                Debug.Log(lampLitCounter);
            }
        }

        if(lampLitCounter == 10)
        {
            Debug.Log("you win");
            flaga.maska2 = true;
            StartCoroutine(wait());
            gameManager.toHub();
        }
    }

    public void RestartLit()
    {
        lampLitCounter = 0;
        Debug.Log(lampLitCounter);
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
    }
}
