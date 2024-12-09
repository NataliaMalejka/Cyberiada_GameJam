using TMPro;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    [SerializeField] private string password;
    [SerializeField] private TextMeshPro screentext;

    private string userInput;

    private void Start()
    {
        userInput = "";
        UpdateScreeText();
    }

    public void KeyClicked(string number)
    {
        userInput += number;
        UpdateScreeText();

        if (userInput.Length >= 4)
        {
            userInput = userInput.Remove(0, 1);
            UpdateScreeText();
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
        UpdateScreeText();
    }

    public void DeleteInput()
    {
        userInput = "";
        UpdateScreeText();
    }

    private void UpdateScreeText()
    {
        screentext.text = userInput;
    }
}
