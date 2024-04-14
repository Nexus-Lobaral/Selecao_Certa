using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Curriculos : MonoBehaviour 
{
    // Atributos
    Empresas empresa;
    protected string cargo;
    protected List<string> listaPessoas = new List<string>() { "João", "Maria", "Enzo", "Marcelo" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
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
