using UnityEngine;

public class OpenPicture : MonoBehaviour
{
    [SerializeField] private GameObject picture;
    [SerializeField] private GameObject scena;

    private bool isActive;

    private void Start()
    {
        isActive = false;
    }

    private void OnMouseDown()
    {
        if (isActive)
        {
            picture.SetActive(false);
            isActive = false;
        }
        else
        {
            picture.SetActive(true);
            isActive = true;
        }
    }
}
