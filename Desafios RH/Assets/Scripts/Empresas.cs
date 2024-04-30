using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Empresas
{
    // Classe Abstrata para exigir tudo que as empresas que vão existir, vão precisar

    //Atributos
    protected List<string> listaCargos =  new List<string>(3);
    protected string cargo;
    public int contratados;

    //Metodos
    public abstract string DefinirCargo(); // todas empresas terao um metodo de definir cargo
    public abstract int GetContratados();
    public abstract void SetContratados(int contratados);


}
