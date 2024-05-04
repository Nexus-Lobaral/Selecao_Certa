using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curriculo
{
    // Atributos
    protected Empresas empresa;
    protected string cargo;
    private List<string> listaPessoas = new List<string>() { "Joao", "Maria", "Enzo", "Marcelo" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    protected string nomePessoa;
    protected string detalhes; // detalhe variados, como onde cursou e etc...
    

    // Construtor
    public Curriculo(Empresas empresaPertence) // Construo um curriculo, precisando de uma empresa de referencia para pegar os dados
    {
        nomePessoa = listaPessoas[Random.Range(0, listaPessoas.Count)]; // Definindo o nome da pessoa aleatoriamente
        detalhes = ""; // Colocar tipos de detalhes da pessoa gerados aleatoriamente
        empresa = empresaPertence;
        cargo = empresa.GetCargo(); // Nome do cargo
        

    }

    // Metodos
    public string GetNomePessoa()
    {
        return nomePessoa;
    }
    public string GetCargo()
    {
        return cargo;
    }
    public string GetDetalhes()
    {
        return detalhes;
    }

}
