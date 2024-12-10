using Unity.VisualScripting;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] private AudioClip mainMenuMusic;
    [SerializeField] private AudioClip buttonClick;
    [SerializeField] private AudioClip keyPadButtons;
    [SerializeField] private AudioClip connectCable;
    [SerializeField] private AudioClip errorSounds;

    private AudioSource audioSource;
    public enum Sounds
    {
        BackgroundMusic,
        MainMenuMusic,
        ButtonClick,
        KeyPadButtons,
        ConnectCable,
        ErrorSounds
    }
    private void Awake()
    {
        //if (GameObject.FindGameObjectsWithTag("SoundsManager").Length > 1)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);

        //audioSource.Play();
    }

    public void PlaySounds(Sounds sounds)
    {
        switch (sounds)
        {
            case Sounds.BackgroundMusic:
                audioSource.PlayOneShot(backgroundMusic);
                break;
            case Sounds.MainMenuMusic:
                audioSource.PlayOneShot(mainMenuMusic);
                break;
            case Sounds.ButtonClick:
                audioSource.PlayOneShot(buttonClick);
                break;
            case Sounds.KeyPadButtons:
                audioSource.PlayOneShot(keyPadButtons);
                break;
            case Sounds.ConnectCable:
                audioSource.PlayOneShot(connectCable);
                break;
            case Sounds.ErrorSounds:
                audioSource.PlayOneShot(errorSounds);
                break;
            default:
                break;
        }
    }
}
