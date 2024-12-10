using UnityEngine;

public class RestartLamps : MonoBehaviour
{
    private LampManager lampManager;
    private SwitchesManager switchesManager;

    private void Start()
    {
        lampManager = FindObjectOfType<LampManager>();
        switchesManager = FindObjectOfType<SwitchesManager>();
    }
    private void OnMouseDown()
    {
        for (int i = 0; i < 10; i++)
        {
            lampManager.GetLamp(i).trunOff();
        }

        for (int i = 0; i < 5; i++)
        {
            switchesManager.getSwitch(i).turnOffSwitch();
        }

        lampManager.RestartLit();
    }
}
