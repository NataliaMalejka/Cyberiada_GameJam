using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    private string[] lines;
    public float textSpeed;

    private int index;

    void Start()
    {
        lines = new string[6];
        lines[0] = "Klapaucjusz: Ah, widzê ze uda³o Ci siê dotrzeæ w\njednym kawa³ku blachy...Œwietnie!";
        lines[1] = "Potrzebujê twojej pomocy";
        lines[2] = "Przyszed³ do mnie Polifazy z proœb¹ o stworzenie dla niego maski samego BLADAWCA!";
        lines[3] = "Nie powiedzia³ z jakiego powodu ale zaoferowa³ mi\n300 sztuk z³otych œrubek typu A, wiêc nie mog³em\nodrzuciæ jego oferty.";
        lines[4] = "Muszê ciê przeprosiæ za tak nag³e wezwanie, ale\nmuszê zaj¹æ siê murkwiami, przez co nie jestem w\nstanie pomóc w tworzeniu maski.";
        lines[5] = "Ale zajrzyj do mojego warsztatu, w nim znajd¹ siê\nwszystkie potrzebne ci elementy. Proszê wiêc, zrób to za mnie...";
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    private void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
