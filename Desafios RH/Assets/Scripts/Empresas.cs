using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Empresas : MonoBehaviour
{
    //Atributos
    public string nome;
    protected List<string> listaCargos =  new List<string>(3);
    protected string cargo;
    public int contratados;

    //Metodos
    public abstract string DefinirCargo(); // todas empresas ter�o um metodo de definir cargo
    
    public abstract string GetName();
    public abstract int GetContratados();
    
    

}
