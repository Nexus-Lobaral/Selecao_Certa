using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pessoa
{
    // Atributos
    private List<string> listaNomes = new List<string>() { "Laura", "Eduardo", "Amanda", "Gustavo", "Isabella", "Ricardo", "Luana", "Leonardo", "Bianca", "Rodrigo", "Fernanda", "Lucas", "Juliana", "Gabriel", "Carolina", "Thiago", "Natália", "Vinícius", "Ana", "Pedro", "Mariana", "João", "Camila", "Felipe", "Larissa", "Matheus", "Bruna", "Daniel", "Tatiane","Renata", "Marcela", "Bruno", "Alice", "Vitor", "Sara", "Diego", "Larissa", "Henrique", "Talita", "André", "Patrícia", "Alexandre", "Nathalia", "Roberto", "Carla", "Luciana", "Leandro", "Raquel", "Thales", "Manuela", "Fábio", "Luiza", "Felipe", "Sabrina", "Fernando", "Priscila", "Júlio", "Aline" }; // Gerar nome de pessoa aleatoriamente pelo ChatGpt (se for dificil demais, deixa para depois do prototipo)
    private List<string> listaSobrenomes = new List<string>(){ "Silva", "Santos", "Oliveira", "Costa", "Pereira", "Martins", "Ferreira", "Almeida", "Souza", "Lima", "Vieira", "Gonçalves", "Carvalho", "Rodrigues", "Fernandes", "Cardoso", "Dias", "Rocha", "Nunes", "Castro", "Ribeiro", "Alves", "Miranda", "Barbosa", "Pereira", "Santos", "Silva", "Martins", "Barbosa", "Santos", "Pereira", "Martins", "Oliveira", "Fernandes", "Lima", "Rodrigues", "Costa", "Carvalho", "Martins", "Silva", "Almeida", "Costa", "Costa", "Lima", "Santos", "Oliveira", "Almeida", "Pereira", "Martins", "Silva", "Alves", "Oliveira", "Fernandes", "Costa", "Pereira", "Almeida", "Santos", "Rodrigues", "Lima", "Oliveira", "Almeida", "Pereira", "Rodrigues", "Martins", "Ferreira", "Almeida", "Pereira", "Gonçalves", "Carvalho", "Santos", "Silva", "Pereira", "Martins", "Oliveira", "Fernandes", "Silva", "Rodrigues", "Costa", "Ferreira", "Almeida", "Santos", "Pereira", "Rodrigues", "Lima", "Oliveira", "Almeida", "Pereira", "Martins", "Gonçalves", "Carvalho", "Santos", "Silva", "Pereira", "Martins", "Oliveira", "Fernandes"};

    protected string nome;
    protected int idade;
    protected string dialogos;
    protected bool contratado; 
    protected Curriculo curriculo;
    
    // Construtor
    public Pessoa()
    {
        idade = Random.Range(18, 40);
        nome = listaNomes[Random.Range(0, listaNomes.Count)] +" "+ listaSobrenomes[Random.Range(0, listaNomes.Count)];

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
