using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Curriculo
{
    // Atributos
    protected Empresas empresa;
    protected string cargo;
    protected string detalhes; // detalhe variados, como onde cursou e etc...
    protected Pessoa pessoa;
    

    // Construtor
    public Curriculo(Empresas empresaPertence, Pessoa pessoa) // Construo um curriculo, precisando de uma empresa de referencia para pegar os dados
    {
        this.pessoa = pessoa;
        detalhes = ""; // Colocar tipos de detalhes da pessoa gerados aleatoriamente
        empresa = empresaPertence;
        cargo = empresa.GetCargo(); // Nome do cargo
        

    }

    // Metodos
    public string GetNomePessoa()
    {
        return pessoa.GetNome();
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
