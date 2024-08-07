using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class GuacamolJuegos : Empresas // Empresa de jogos que herda da classe de empresa
{
    // Atributos
    private static GuacamolJuegos instance;
    
    
    
    // Construtores
    public GuacamolJuegos() 
    {
        nome = "Guacamol Juegos";
        listaCargos = new List<string> { "GameDev", "Produtor Executivo", "Designer" }; // Lista de cargos especifico desta empresa
        contratados = 0;
        descricao = ""; // Descrição da empresa para aparecer no card
    }

    // Metodos
    public static GuacamolJuegos GetInstance()
    {
        return instance;
    }

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
