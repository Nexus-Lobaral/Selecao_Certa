using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pessoa
{
    // Atributos
    private List<string> listaNomes = new List<string>() { "Joao", "Maria", "Enzo", "Marcelo" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    protected string nome;
    protected int idade;
    protected string dialogos;
    protected bool contratado; 
    protected Curriculo curriculo;
    
    // Construtor
    public Pessoa()
    {
        idade = Random.Range(18, 40);
        nome = listaNomes[Random.Range(0, listaNomes.Count)];
    }


    // Metodos
    public void SistemaDialogos()
    {
        // ...
    }
    public string GetNome()
    {
        return nome;
    }
    public int GetIdade() 
    {
        return idade;
    }
}
