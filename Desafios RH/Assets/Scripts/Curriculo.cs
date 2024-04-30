using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curriculo
{
    // Atributos
    protected Empresas empresa;
    protected string cargo;
    protected List<string> listaPessoas = new List<string>() { "Joao", "Maria", "Enzo", "Marcelo" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    protected string nomePessoa;
    protected string caracteristicas;
    protected string detalhes;

    // Construtor
    public Curriculo(Empresas empresaQPertence) // construo um curriculo, precisando de uma empresa de referencia para pegar os dados
    {
        empresa = empresaQPertence;
        cargo = empresa.DefinirCargo();
        nomePessoa = listaPessoas[Random.Range(0, listaPessoas.Count - 1)]; // Definindo o nome da pessoa aleatoriamente
    }

    // Metodos
    public string GetNomePessoa()
    {
        return nomePessoa;
    }


}
