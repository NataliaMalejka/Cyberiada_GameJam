using UnityEngine;

public class closePicture : MonoBehaviour
{
    [SerializeField] private GameObject picture;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        if (picture.activeSelf==true)
        {
            picture.SetActive(false);
        }
    }
}
