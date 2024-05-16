using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.IO;

public class SistemaDeSeleção : MonoBehaviour
{
    protected GameObject obj;
    protected GameObject obj2;
    protected GameObject obj3;
    protected TextMeshProUGUI text;
    private Pessoa pessoa1;
    private Pessoa pessoa2;
    private Pessoa pessoa3;

    void Start()
    {   
        //pessoa 1
        obj = GameObject.FindGameObjectWithTag("Texto");
        pessoa1 = new Pessoa();
        DefinirTextoNome(pessoa1.GetNome(),obj);

        //pessoa 2 
        obj2 = GameObject.FindGameObjectWithTag("Texto");
        pessoa2 = new Pessoa();
        DefinirTextoNome(pessoa2.GetNome(),obj2);

        // pessoa 3
        obj3 = GameObject.FindGameObjectWithTag("Texto");
        pessoa3 = new Pessoa();
        DefinirTextoNome(pessoa3.GetNome(),obj3);
    }


    void Update()
    {
        
    }

    public void DefinirTextoNome(string texto, GameObject obj)
    {
        if (obj != null)
        {
            text = obj.GetComponent<TextMeshProUGUI>();
            text.text = texto;
        }
        else
        {
            Debug.Log("Nada foi adicionado ao objeto de referencia para os textos");
        }
    }

}
