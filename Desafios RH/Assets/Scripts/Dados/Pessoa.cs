using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pessoa 
{
    // Atributos
    private List<string> listaNomesMasc = new List<string>() { "Vinícius", "Eduardo", "Gustavo", "Ricardo", "Leonardo", "Gabriel", "Thiago", "Rodrigo", "Lucas", "Gustavo", "João", "Felipe", "Daniel", "Diego", "Henrique", "Thales", "Fábio", "Fernando", "Júlio" };
    private List<string> listaNomesFem = new List<string>() { "Laura", "Amanda", "Isabella", "Luana", "Bianca", "Fernanda", "Juliana", "Ana", "Mariana", "Camila", "Larissa", "Bruna", "Renata", "Marcela", "Natália", "Carla", "Luciana", "Raquel", "Manuela", "Luiza", "Sabrina", "Priscila", "Aline" };
    private List<string> listaSobrenomes = new List<string>() { "Silva", "Santos", "Oliveira", "Costa", "Pereira", "Martins", "Ferreira", "Almeida", "Souza", "Lima", "Vieira", "Gonçalves", "Carvalho", "Rodrigues", "Fernandes", "Cardoso", "Dias", "Rocha", "Nunes", "Castro", "Ribeiro", "Alves", "Miranda", "Barbosa", "Pereira", "Santos", "Silva", "Martins", "Barbosa" };

    public Sprite imagemPessoa;
    private string nomeCompleto;
    private string nomePrimeiro;
    private int idade;
    public bool contratado;
    public string genero;
    private GuacamolJuegos guacamol = new GuacamolJuegos();
    private Curriculo curriculo { get; }
    private TextAsset dialogo { get; }
    
    // Construtor
    public Pessoa(Sprite fotoPessoa, TextAsset dialogoJson)
    {
        int i = Random.Range(0, 2);
        if (i == 0)
        {
            genero = "masculino";
            nomePrimeiro = listaNomesMasc[Random.Range(0, listaNomesMasc.Count)];
        }
        else
        {
            genero = "feminino";
            nomePrimeiro = listaNomesFem[Random.Range(0, listaNomesFem.Count)];
        }
        nomeCompleto = nomePrimeiro + " " + listaSobrenomes[Random.Range(0, listaSobrenomes.Count)];
        idade = Random.Range(18, 31);
        curriculo = new Curriculo(guacamol, this);
        imagemPessoa = fotoPessoa;
        dialogo = dialogoJson;
    }


    // Metodos
    
    public string GetNome()
    {
        return nomeCompleto;
    }
    public int GetIdade() 
    {
        return idade;
    }


}
