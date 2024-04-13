using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuacamolJuegos : Empresas // Empresa de jogos que herda da classe de empresa
{
    // Atributos
    protected string descricao; // Descrição da empresa que aparecerá no card quando for selecionar a empresa
    
    // Construtores
    public GuacamolJuegos() 
    {
        listaCargos = new List<string> { "GameDev", "Produtor Executivo", "Designer" }; // Lista de cargos especifico desta empresa
    }

    // Metodos
    public string MostrarDescricao() // Metodo para retornar a variavel de descrição
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

}
