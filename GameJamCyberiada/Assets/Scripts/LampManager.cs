using UnityEngine;

public class LampManager : MonoBehaviour
{
    [SerializeField] private LampScript[] lamps;
    private int lampLitCounter;

    public LampScript GetLamp(int number)
    {
        return lamps[number];
        lampLitCounter = 0;
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
        }
    }
}
