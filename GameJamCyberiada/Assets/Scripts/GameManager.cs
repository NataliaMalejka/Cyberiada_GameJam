using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void toFollowLine()
    {
        SceneManager.LoadScene(3);
    }

    public void toKeypad()
    {
        SceneManager.LoadScene(2);
    }

    public void toLights()
    {
        SceneManager.LoadScene(4);
    }

    public void toHub()
    {
        Debug.Log("start wait");
        //yield return new WaitForSeconds(5);
        Debug.Log("end wait");
        SceneManager.LoadScene(1);
    }
}
