using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Empresas : MonoBehaviour
{
    //Atributos
    protected List<string> listaCargos = new List<string>(3);
    protected string cargo;

    //Metodos
    public abstract string DefinirCargo(); // todas empresas terão um metodo de definir cargo
    //ainda to pensando em oq mais colocar aqui kkkkk

}
/*
public class Cargos
{
    // Atributos
     // inicializando a variavel cargo

    // Construtor

    // Metodos
    
    public void DefinirCargo() // 
    {
        
    }
    
    public string Cargo(List<string> listaCargos) // Ao chamar este metodo, voce coloca a lista de cargos da empresa e então ele escolhera um dos 3 cargos e retorna o nome cargo
    {
        cargo = listaCargos[Random.Range(0, listaCargos.Count)];
        return cargo;
    }
    
}
*/

public class Curriculos
{
    // Atributos
    Empresas empresa;
    protected string cargo;
    protected List<string> listaPessoas = new List<string>() {"João", "Maria", "Enzo", "Marcelo"}; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    protected string nomePessoa;
    protected string caracteristicas;
    protected string detalhes;

    // Construtor
    public Curriculos(Empresas empresa) // construo um curriculo, precisando de uma empresa de referencia para pegar os dados
    {
        this.empresa = empresa;
        cargo = empresa.DefinirCargo();
        nomePessoa = listaPessoas[Random.Range(0, listaPessoas.Count)]; // Definindo o nome da pessoa do curriculo
    }

    // Metodos

}
