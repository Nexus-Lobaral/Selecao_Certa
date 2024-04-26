using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curriculo : MonoBehaviour
{
    // Atributos
    public Empresas empresa;
    protected string cargo;
    public int contratados;
    protected List<string> listaPessoas = new List<string>() { "Jo�o", "Maria", "Enzo", "Marcelo" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    protected string nomePessoa;
    protected string caracteristicas;
    protected string detalhes;

    // Construtor
    public Curriculo(Empresas empresa, int contratados) // construo um curriculo, precisando de uma empresa de referencia para pegar os dados
    {
        this.empresa = empresa;
        this.contratados = contratados;
        cargo = empresa.DefinirCargo();
        nomePessoa = listaPessoas[Random.Range(0, listaPessoas.Count)]; // Definindo o nome da pessoa do curriculo
    }

    // Metodos
    


}
