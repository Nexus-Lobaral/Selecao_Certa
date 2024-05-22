using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Jogador
{
    // Atributos
    protected string nome;
    protected int status; // total de pontos acumulados, se contratou certo ou n�o
    protected List<Pessoa> pessoas = new List<Pessoa>();
    protected List<Curriculo> curriculos = new List<Curriculo>();

    // Construtor
    public Jogador()
    {
        
    }

    // Metodos
    public List<Curriculo> GetCurriculos()
    { 
        return curriculos; 
    }
    public List<Pessoa> GetPessoas()
    {
        return pessoas;
    }
    public void AddCurriculo(Curriculo curriculo)
    {
        curriculos.Add(curriculo);
    }
    public void AddPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }
    public void SetStatus(int status)
    {
        this.status = status;
    }
    public int GetStatus()
    {
        return status;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome) 
    { 
        this.nome = nome;
    }
    public void LerNomeJogador(){
        using (StreamReader sr = new StreamReader("NomePlayer.txt")) // localiza e ler o nome do jogador
        {
                nome = sr.ReadLine();
        }
    }
}
