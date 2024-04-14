using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Empresas : MonoBehaviour
{
    //Atributos
    protected List<string> listaCargos =  new List<string>(3);
    protected string cargo;

    //Metodos
    public abstract string DefinirCargo(); // todas empresas terão um metodo de definir cargo


}
