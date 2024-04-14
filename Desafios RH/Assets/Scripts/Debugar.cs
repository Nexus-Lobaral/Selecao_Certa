using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugar : MonoBehaviour
{
    private GuacamolJuegos guacamol;

    // Start is called before the first frame update
    void Start()
    {
        // Crio um Objeto da unity, e atribuo um nome a ele
        GameObject guacamolGameObject = new GameObject("GuacamolJuegos");
        // Atribuo o Objeto adicionando a classe a ele na variavel de referencia Guacamol
        guacamol = guacamolGameObject.AddComponent<GuacamolJuegos>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Testezinho
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log(guacamol.DefinirCargo());
        }
    }
}
