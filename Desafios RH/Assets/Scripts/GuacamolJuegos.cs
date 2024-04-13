using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuacamolJuegos : Empresas
{
    // Atributos
    protected string descricao; // Descri��o da empresa que aparecer� no card quando for selecionar a empresa
    private List<string> listaCargosDJogos = new List<string>() { "GameDev", "Produtor Executivo", "Designer" }; // Lista de cargos
    // Construtores
    public GuacamolJuegos() { }

    // Metodos
    public string MostrarDescricao() // Metodo para retornar a variavel de descri��o
    {
        return descricao;
    }

}
