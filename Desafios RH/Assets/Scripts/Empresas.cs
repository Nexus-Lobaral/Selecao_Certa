using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Empresas : MonoBehaviour
{
    //Atributos
    
    //Metodos

    //ainda to pensando em oq colocar aqui kkkkk

}

public class Cargos
{
    // Atributos
    protected string cargo;

    // Construtor
    public Cargos() {}

    // Metodos
    public void DefinirCargo(List<string> listaCargos) // Ao chamar este metodo, voce coloca a lista de cargos da empresa e então ele escolhera um dos 3 cargos
    {
        cargo = listaCargos[Random.Range(0, listaCargos.Count)]; 
    }
    public string Cargo() // Metodo que retorna o nome cargo
    {
        if (cargo != null)
        {
            return cargo;
        }
        else
        {
            return "Cargo não definido";
        }
    }
}

public class Curriculos
{
    // Atributos
    Cargos cargo = new Cargos();
    GuacamolJuegos GuacamolJuegos = new GuacamolJuegos();
    protected List<string> nomePessoa = new List<string>() {};// Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)

    // Construtor
    


    // Metodos
    
}
