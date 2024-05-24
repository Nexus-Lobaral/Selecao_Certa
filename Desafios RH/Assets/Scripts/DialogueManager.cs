using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI nameBoxText;
    private Story currentStory;
    private bool DialogueIsPlaying;
    [SerializeField] private TextAsset jsonAsset; // somente para teste, quando ter o sistema de criar personagens, não vou anexar o dialogo json por inspector, e sim por script
    [SerializeField] private GameObject personagemGameObject;


    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("tem mais de um dialogue manager na cena"); // somente para teste, quando ter o sistema de criar personagens, não vou anexar o dialogo json por inspector, e sim por script
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
        nameBoxText.text = "Nome Personagem";
        EnterDialogueMode(jsonAsset);
    }

    private void Update()
    {
        if (!DialogueIsPlaying)
        {
            return;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ContinueButton();
        }
        
    }

    public void EnterDialogueMode(TextAsset inkjson)
    {
        currentStory = new Story(inkjson.text);
        // currentStory.variablesState["nomePersonagem"] = nomePessoa;
        DialogueIsPlaying = true;

        ContinueStory();
    }

    // posso deixar IEnumerator neste metodo para adicionar um leve delay no fim do dialogo para ocorrer alguma animação...
    private void ExitDialogueMode()
    {

        DialogueIsPlaying = false;
        dialogueText.text = "";
    }

    public void ContinueButton()
    {
        if (currentStory.currentChoices.Count == 0)
        {
            ContinueStory();
        }

    }
    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //dialogueText.text = currentStory.Continue();
            string nextLine = currentStory.Continue();
            Debug.Log("Próxima linha do diálogo: " + nextLine);
            dialogueText.text = nextLine;

            DisplayChoices();
        }

        else
        {
            Debug.Log("Fim da história.");
            ExitDialogueMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // checagem de precaução para que se o numero de escolhas for diferente do numero de de objetos de escolha
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("Falta mais escolhas para que a UI fique completa, numero de escolhas abaixo do esperado. Numero de escolhas dadas: "
                + currentChoices.Count);
        }

        int index = 0;
        // ativa e iniciar as escolhas da historia atual nos objetos de escolha da cena jogo 
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // analise as opções restantes que a IU suporta e certifique-se de que estejam ocultas
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        // StartCoroutine(SelectFirstChoice());
    }
    
    public void MakeChoice(int choiceIndex)
    {
        Debug.Log("MakeChoice chamado com índice: " + choiceIndex);
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

    /* isto é para caso algum dia eu quero que o menu seja utilizado com teclas do teclado tambem
    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }
    */

}

