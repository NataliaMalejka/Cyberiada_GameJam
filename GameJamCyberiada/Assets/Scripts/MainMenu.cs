using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    
    public  AudioMixer audioMixer;
    public void Graj()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Wyjdz()
    {
        Application.Quit();
    }

    public void Ustawglos(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }
    public void UstawFullScreen(bool CzyFullscreen)
    {
        Screen.fullScreen = CzyFullscreen;
    }
}
