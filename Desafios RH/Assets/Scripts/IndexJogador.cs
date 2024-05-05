using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexJogador : MonoBehaviour
{
    private GuacamolJuegos guacamol;
    private SaveAndLoad save;
    private Curriculo curriculo;

    void Start()
    {
        /* se for fazer as classes voltar a ser monoBehaviour, tornar codigo denovo
        // Crio um Objeto da unity, e atribuo um nome a ele
        GameObject guacamolGameObject = new GameObject("GuacamolJuegos");
        GameObject saveGameObject = new GameObject("SaveAndLoad");
        // Atribuo o Objeto adicionando a classe a ele na variavel de referencia Guacamol
        guacamol = guacamolGameObject.AddComponent<GuacamolJuegos>();
        save = saveGameObject.AddComponent<SaveAndLoad>();
        */
        guacamol = new GuacamolJuegos();
        save = new SaveAndLoad(guacamol);
        curriculo = new Curriculo(guacamol);
        Debug.Log("Incio");
        
    }

    void Update()
    {

        Testes();
    }

    public void Testes()
    {
        if (guacamol != null)
        {
            // Teste de teclas
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log(guacamol.GetCargo());
            }
            if (Input.GetKeyUp(KeyCode.C))
            {
                guacamol.SetContratados(guacamol.GetContratados() + 1);
            }
            if (Input.GetKeyUp(KeyCode.V))
            {
                Debug.Log(guacamol.GetContratados());
            }
        }

            if (Input.GetKeyUp(KeyCode.S))
            {
                save.SaveToJson();
            }
            if (Input.GetKeyUp(KeyCode.L))
            {
                save.LoadFromJson();
            }
            if (Input.GetKeyUp(KeyCode.C))
            {
                Debug.Log(curriculo.GetNomePessoa());
            }
    }

}
