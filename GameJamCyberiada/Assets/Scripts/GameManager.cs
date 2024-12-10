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
}
