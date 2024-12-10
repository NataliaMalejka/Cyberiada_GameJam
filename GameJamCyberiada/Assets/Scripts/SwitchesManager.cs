using UnityEngine;

public class SwitchesManager : MonoBehaviour
{
    [SerializeField] private Switch[] switches;

    public Switch getSwitch(int number)
    {
        return switches[number];
    }
}
