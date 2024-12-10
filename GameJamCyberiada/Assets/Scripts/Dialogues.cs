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
    private string[] lines;
    public float textSpeed;

    private GameManager gameManager;

    private int index;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (flaga.flagadialog == true)
        {
            canva.SetActive(true);
            lines = new string[7];
            lines[0] = "Ah, widz� ze uda�o Ci si� dotrze� w jednym kawa�ku\nblachy...�wietnie!";
            lines[1] = "Potrzebuj� twojej pomocy.";
            lines[2] = "Przyszed� do mnie Polifazy z pro�b� o stworzenie dla niego maski samego BLADAWCA!";
            lines[3] = "Nie powiedzia� z jakiego powodu ale zaoferowa� mi\n300 sztuk z�otych �rubek typu A, wi�c nie mog�em\nodrzuci� jego oferty.";
            lines[4] = "Musz� ci� przeprosi� za tak nag�e wezwanie, ale\nmusz� zaj�� si� murkwiami, przez co nie jestem w\nstanie pom�c w tworzeniu maski.";
            lines[5] = "Ale zajrzyj do mojego warsztatu, w nim znajd� si�\nwszystkie potrzebne ci elementy. Prosz� wi�c, zr�b to za mnie...";
            lines[6] = "A i jeszcze zanim p�jd�...wszystkie szafki w moim\nwarsztacie s� zabezpieczone zagadk�. Postaraj si�\nnic nie zepsu�!!";
            textComponent.text = string.Empty;
            StartDialogue();
        }
        
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
        }
    }
}
