using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaDeSeleção : MonoBehaviour
{
    protected GameObject obj;
    protected TextMeshProUGUI text;
    private Pessoa pessoa;

    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Texto");
        pessoa = new Pessoa();
        DefinirTextoNome(pessoa.GetNome());
    }


    void Update()
    {
        
    }

    public void DefinirTextoNome(string texto)
    {
        if (obj != null)
        {
            text = obj.GetComponent<TextMeshProUGUI>();
            text.SetText(texto);
        }
        else
        {
            Debug.Log("Nada foi adicionado ao objeto de referencia para os textos");
        }
    }

}
