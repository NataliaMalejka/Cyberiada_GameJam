using UnityEngine;

public class OpenPicture : MonoBehaviour
{
    [SerializeField] private GameObject picture;
    [SerializeField] private GameObject scena;

    private bool isActive;

    private void Start()
    {
    }

    private void OnMouseDown()
    {

            picture.SetActive(true);
            isActive = true;

    }
}
