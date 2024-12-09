using UnityEngine;

public class Keypad : MonoBehaviour
{
    [SerializeField] private string password;

    private string userInput;

    private void Start()
    {
        userInput = "";
    }

    public void KeyClicked(string number)
    {
        userInput += number;

        if (userInput.Length >= 7)
        {
            userInput = userInput.Remove(0, 1);
        }
    }

    public void CheckPassword()
    {
        if (userInput.Length == password.Length)
        {
            if (userInput == password)
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("incorrect");
            }
        }
        else
        {
            Debug.Log("incorrect");
        }

        userInput = "";
    }
}
