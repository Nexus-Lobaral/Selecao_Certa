using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textComp; // Componente de referencia
    public string[] linhas; // Array com varias strings que serão os linhas de dialogos
    public float textVelocidade; // velocidade do texto

    private int index; // indice de cada dialogo

    // Start is called before the first frame update
    void Start()
    {
        textComp.text = string.Empty;
        StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
        {
            if (textComp.text == linhas[index]) // se o texto exibido for igual ao texto completo do especifico indice de dialogo
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines(); 
                textComp.text = linhas[index]; // faz com que o texto do dialogo seja setado para a string completa automaticamente
            }
        }
    }

    void StartDialog()
    {
        index = 0; // Começa no primeiro dialogo
        StartCoroutine(TypeLine()); // Coroutine é a forma q chama uma interface iterador (como o IEnumerator) e pode ter pausas dentro dele, é uma rotina de ações... foi oq entendi
        
    }

    IEnumerator TypeLine() // Interface propria para fazer iterações de listas
    {
        foreach(char c in linhas[index].ToCharArray()) // para cada letra da linha de dialogo do indice
        {
            textComp.text += c; // escreve uma por uma
            yield return new WaitForSeconds(textVelocidade); // é a forma de pausar no coroutine, ele exige uma condição de tempo para passar
        }
        
    }

    void NextLine()
    {
        if (index < linhas.Length - 1) // se n tiver passado todas as linhas de dialogo
        {
            index++;
            textComp.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
