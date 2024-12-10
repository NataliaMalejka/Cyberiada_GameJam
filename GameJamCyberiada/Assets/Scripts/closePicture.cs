using UnityEngine;

public class closePicture : MonoBehaviour
{
    [SerializeField] private GameObject picture;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
       
            picture.SetActive(false);

    }
}
