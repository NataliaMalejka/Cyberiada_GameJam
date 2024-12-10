using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField] GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale  == 0)
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
        }
    }
  
    public void Graj()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void WyjdzDoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Ustawglos(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
    public void UstawFullScreen(bool CzyFullscreen)
    {
        Screen.fullScreen = CzyFullscreen;
    }
    public void Powtorz()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
