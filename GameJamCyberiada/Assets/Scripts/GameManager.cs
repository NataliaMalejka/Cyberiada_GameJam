using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject image;

    private bool deleteDialogue = false;

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("GameManager").Length > 1)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (deleteDialogue)
            {
                Destroy(image);
                panel.SetActive(false);
            }
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

    public void setDeleteDialogue()
    {
        deleteDialogue = true;
    }
}
