using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject image;

    private Dialogues dialogues;

    private void Awake()
    {
        dialogues = FindObjectOfType<Dialogues>();

        if(SceneManager.GetActiveScene().buildIndex == 1 && dialogues.getDeleteDialogue())
        {
            Destroy(image);
            panel.SetActive(false);
        }
    }
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
