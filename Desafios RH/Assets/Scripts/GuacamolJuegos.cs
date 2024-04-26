using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuacamolJuegos : Empresas // Empresa de jogos que herda da classe de empresa
{
    // Atributos
    protected string descricao; // Descri��o da empresa que aparecer� no card quando for selecionar a empresa
    
    
    // Construtores
    public GuacamolJuegos() 
    {
        listaCargos = new List<string> { "GameDev", "Produtor Executivo", "Designer" }; // Lista de cargos especifico desta empresa
    }

    // Metodos
    public string MostrarDescricao() // Metodo para retornar a variavel de descri��o
    {
        return descricao;
    }
    public List<string> MostrarListaCargos() // // Metodo para retornar Lista de cargos
    {
        return listaCargos;
    }
    public override string DefinirCargo() // Ao chamar este metodo, ele escolhera um dos 3 cargos e retorna o nome cargo
    {
        cargo = listaCargos[Random.Range(0, listaCargos.Count)];
        return cargo;

    }
    public override string GetName(){
        return nome;
    }
    public override int GetContratados(){
        return contratados;
    }
    public void setEmpresa(string nome){
        this.nome = nome;
    }
    public void setContratado(int contratados){
        this.contratados = contratados;
    }

}
