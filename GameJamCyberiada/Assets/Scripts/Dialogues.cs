using System.Collections;
using Assets.Scripts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private GameObject image;
    [SerializeField] GameObject canva;
    [SerializeField] GameObject Obmaska1;
    [SerializeField] GameObject Obmaska2;
    [SerializeField] GameObject Obmaska3;
    [SerializeField] GameObject Obkey;
    [SerializeField] GameObject Obkod;
    [SerializeField] GameObject Obkot;
    private string[] lines;
    public float textSpeed;

    private GameManager gameManager;

    private int index;

    void Start()
    {
        if (flaga.maska1 == true)
        {
            Obmaska1.SetActive(true);
        }
        if (flaga.maska2 == true)
        {
            Obmaska2.SetActive(true);
        }
        if (flaga.maska3 == true)
        {
            Obmaska3.SetActive(true);
        }
        if (flaga.maska1 == true && flaga.maska2 == true && flaga.maska3 == true)
        {

        }
        gameManager = FindObjectOfType<GameManager>();
        if (flaga.flagadialog == true)
        {
            canva.SetActive(true);
            lines = new string[7];
            lines[0] = "Ah, widzê ze uda³o Ci siê dotrzeæ w jednym kawa³ku\nblachy...Œwietnie!";
            lines[1] = "Potrzebujê twojej pomocy.";
            lines[2] = "Przyszed³ do mnie Polifazy z proœb¹ o stworzenie dla niego maski samego BLADAWCA!";
            lines[3] = "Nie powiedzia³ z jakiego powodu ale zaoferowa³ mi\n300 sztuk z³otych œrubek typu A, wiêc nie mog³em\nodrzuciæ jego oferty.";
            lines[4] = "Muszê ciê przeprosiæ za tak nag³e wezwanie, ale\nmuszê zaj¹æ siê murkwiami, przez co nie jestem w\nstanie pomóc w tworzeniu maski.";
            lines[5] = "Ale zajrzyj do mojego warsztatu, w nim znajd¹ siê\nwszystkie potrzebne ci elementy. Proszê wiêc, zrób to za mnie...";
            lines[6] = "A i jeszcze zanim pójdê...wszystkie szafki w moim\nwarsztacie s¹ zabezpieczone zagadk¹. Postaraj siê\nnic nie zepsuæ!!";
            textComponent.text = string.Empty;
            StartDialogue();
        }
        
    }

    void Update()
    {
        if (!flaga.flagadialog == true)
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
        
    }

    private void StartDialogue()
    {
        if (flaga.flagadialog == true)
        {
            index = 0;
            StartCoroutine(TypeLine());

        }
        flaga.flagadialog = false;


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
            canva.SetActive(false);
            Obkey.SetActive(true);
            Obkod.SetActive(true);
            Obkot.SetActive(true);
        }
    }
}
