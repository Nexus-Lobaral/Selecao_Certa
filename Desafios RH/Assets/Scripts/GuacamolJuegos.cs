using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuacamolJuegos : Empresas // Empresa de jogos que herda da classe de empresa
{
    // Atributos
    protected string nome = "Guacamol Juegos";
    protected string descricao; // Descricao da empresa que aparecera no card quando for selecionar a empresa
    
    
    // Construtores
    public GuacamolJuegos() 
    {
        listaCargos = new List<string> { "GameDev", "Produtor Executivo", "Designer" }; // Lista de cargos especifico desta empresa
        contratados = 0;
    }

    // Metodos
    public override string GetDescricao() // Metodo para retornar a variavel de descri��o
    {
        return descricao;
    }
    public override List<string> GetListaCargos() // // Metodo para retornar Lista de cargos
    {
        return listaCargos;
    }
    public override string GetCargo() // Ao chamar este metodo, ele escolhera um dos 3 cargos e retorna o nome cargo
    {
        cargo = listaCargos[Random.Range(0, listaCargos.Count)];
        return cargo;

    }
    public override int GetContratados()
    {
        return contratados;
    }
    public override void SetContratados(int contratados)
    {
        this.contratados = contratados;
    }

}
