using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexJogador : MonoBehaviour
{
    // Start is called before the first frame update
    private GuacamolJuegos guacamol;
   void Start()
    {
        // Crio um Objeto da unity, e atribuo um nome a ele
        GameObject guacamolGameObject = new GameObject("GuacamolJuegos");
        // Atribuo o Objeto adicionando a classe a ele na variavel de referencia Guacamol
        guacamol = guacamolGameObject.AddComponent<GuacamolJuegos>();
        Debug.Log("Teste");
        string a = guacamol.GetName();
        int b = guacamol.GetContratados();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Testezinho
        if (guacamol != null)
        {
            // Testezinho
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log(guacamol.DefinirCargo());
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                string a = guacamol.GetName();
                int b = guacamol.GetContratados();

                SaveAndLoad.SaveToJson(guacamol.GetName(), guacamol.GetContratados());
            }
        }
    }
}
