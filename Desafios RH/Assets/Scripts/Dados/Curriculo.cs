using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Net.Http.Headers;
using UnityEditor.Build.Pipeline;
using System.Reflection;
using Unity.Properties;

public class Curriculo : MonoBehaviour
{   
    // Atributos
    private System.Random random = new System.Random();
    private int numRandom;
    protected Empresas empresa;
    protected string cargo;
    protected string detalhes; // detalhes variados, como onde cursou e etc...
    protected Pessoa pessoa;
    protected List<string> Curriculos = new List<string>();
    protected List<int> CurriculosNota = new List<int>();

    // Construtor
    public Curriculo(Empresas empresaPertence, Pessoa pessoa)
    {
        
        this.pessoa = pessoa;
        detalhes = ""; // Colocar tipos de detalhes da pessoa gerados aleatoriamente
        empresa = empresaPertence;
        cargo = empresa.GetCargo(); // Nome do cargo
        #region 
        Curriculos.Add($"Nome: {pessoa.GetNome()} /nContato: - Telefone: 99 - E-mail: {pessoa.GetNome()}gmail - Endereço: Rua sem nome /nObjetivo Profissional: Obter um emprego /nResumo Profissional: Alguma experiência em várias coisas /nFormação Acadêmica: Escola, não lembro o nome /nExperiência Profissional: Trabalhei em alguns lugares /nHabilidades: Algumas habilidades básicas /nIdiomas: Português (básico) /nReferências: Sobrenome (não lembro)");
        CurriculosNota.Add(1);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /nContato: - Telefone: 5555 /n- E-mail: {pessoa.GetNome()}@email /n- Endereço: Rua Desconhecida, Número Não Identificado /nObjetivo Profissional: Conseguir um emprego /nResumo Profissional: Alguma experiência em algumas coisas /nFormação Acadêmica: Escola Municipal, Data Desconhecida /nExperiência Profissional: Trabalhei em poucos lugares /nHabilidades: Algumas habilidades básicas /nIdiomas: Português (básico) /nReferências: Nome (não lembro)");
        CurriculosNota.Add(2);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /nContato: - Telefone: 1234 /n- E-mail: {pessoa.GetNome()}@email /n- Endereço: Rua Sem Nome, Número Não Identificado /nObjetivo Profissional: Encontrar uma oportunidade de emprego /nResumo Profissional: Alguma experiência em áreas diversas /nFormação Acadêmica: Escola Estadual, Sem data /nExperiência Profissional: Trabalhos ocasionais /nHabilidades: Conhecimentos básicos em informática /nIdiomas: Português (nativo) /nReferências: Disponíveis mediante solicitação");
        CurriculosNota.Add(3);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /nContato: - Telefone: 9876 /n- E-mail: {pessoa.GetNome()}@email /n- Endereço: Rua Desconhecida, Número Não Informado /nObjetivo Profissional: Ingressar no mercado de trabalho /nResumo Profissional: Alguma experiência em áreas administrativas /nFormação Acadêmica: Escola Municipal, Data Indefinida /nExperiência Profissional: Estágio em escritório por curto período /nHabilidades: Boa comunicação e organização /nIdiomas: Português (nativo), Inglês (básico) /nReferências: Disponíveis mediante solicitação");
        CurriculosNota.Add(4);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /nContato: - Telefone: 555-1234 /n- E-mail: {pessoa.GetNome()}@email /n- Endereço: Rua dos Sonhos, Número 123 /nObjetivo Profissional: Desenvolver uma carreira sólida /nResumo Profissional: Experiência consistente em vendas /nFormação Acadêmica: Ensino Médio Completo, Escola Estadual, 2015 /nExperiência Profissional: Vendedor em loja de varejo por 2 anos /nHabilidades: Excelente habilidade de comunicação e persuasão /nIdiomas: Português (nativo), Inglês (intermediário) /nReferências: Fornecidas mediante solicitação");
        CurriculosNota.Add(5);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /n Contato: /n Telefone: 555-9876 /n E-mail: {pessoa.GetNome()}@email /n Endereço: Rua das Flores, Número 789 /n Objetivo Profissional: Conseguir uma posição como desenvolvedor de software /n Resumo Profissional: Experiência em desenvolvimento de software e solução de problemas /n Formação Acadêmica: Bacharelado em Ciência da Computação, Universidade ABC, Concluído em 2019 /n Experiência Profissional: /n Desenvolvedor Júnior em empresa de tecnologia por 2 anos /n Habilidades: /n Conhecimento em linguagens de programação como Java, Python e JavaScript /n Familiaridade com bancos de dados SQL /n Habilidade em resolução de problemas e trabalho em equipe /n Idiomas: Português (nativo), Inglês (intermediário) /n Referências: Disponíveis mediante solicitação");
        CurriculosNota.Add(6);
        Curriculos.Add($"Nome: {pessoa.GetNome()} /n Contato: /n Telefone: 555-5678 /n E-mail: {pessoa.GetNome()}@email /n Endereço: Avenida das Estrelas, Número 456 /n Objetivo Profissional: Desenvolver uma carreira como desenvolvedora de software /n Resumo Profissional: Experiência sólida em desenvolvimento de software e gerenciamento de projetos /n Formação Acadêmica: Graduação em Engenharia de Computação, Universidade XYZ, Concluído em 2018 /n Experiência Profissional: /n Desenvolvedora Pleno em empresa de tecnologia por 4 anos /n Habilidades: /n Ampla experiência em linguagens de programação como Java, Python e C++ /n Conhecimento avançado em desenvolvimento web e mobile /n Habilidade em liderança de equipe e comunicação eficaz /n Idiomas: Português (nativo), Inglês (avançado) /n Referências: Fornecidas mediante solicitação");
        CurriculosNota.Add(7);
        Curriculos.Add($"Nome: {pessoa.GetNome()} Contato: Telefone: 555-6789 E-mail: {pessoa.GetNome()}@email Endereço: Rua das Árvores, Número 789 Objetivo Profissional: Alcançar excelência como desenvolvedor de software Resumo Profissional: Vasta experiência em desenvolvimento de software e liderança de equipe Formação Acadêmica: Mestrado em Ciência da Computação, Universidade XYZ, Concluído em 2020 Experiência Profissional: Desenvolvedor Sênior em empresa de tecnologia por 6 anos Habilidades: Experiente em linguagens de programação como Java, Python, e Ruby Domínio avançado em arquitetura de software e design de sistemas Excelente habilidade em liderança, comunicação e resolução de problemas Idiomas: Português (nativo), Inglês (fluente) Referências: Fornecidas mediante solicitação");
        CurriculosNota.Add(8);
        Curriculos.Add($"Nome: {pessoa.GetNome()} Contato: Telefone: 555-6789 E-mail: {pessoa.GetNome()}@email Endereço: Rua das Árvores, Número 789 Objetivo Profissional: Alcançar excelência como desenvolvedor de software Resumo Profissional: Vasta experiência em desenvolvimento de software e liderança de equipe Formação Acadêmica: Mestrado em Ciência da Computação, Universidade XYZ, Concluído em 2020 Experiência Profissional: Desenvolvedor Sênior em empresa de tecnologia por 6 anos Habilidades: Experiente em linguagens de programação como Java, Python, e Ruby Domínio avançado em arquitetura de software e design de sistemas Excelente habilidade em liderança, comunicação e resolução de problemas Idiomas: Português (nativo), Inglês (fluente) Referências: Fornecidas mediante solicitação");
        CurriculosNota.Add(9);
        Curriculos.Add($"Nome: {pessoa.GetNome()} Contato: Telefone: 555-6789 E-mail: {pessoa.GetNome()}@email Endereço: Rua das Árvores, Número 789 Objetivo Profissional: Alcançar excelência como desenvolvedor de software Resumo Profissional: Vasta experiência em desenvolvimento de software e liderança de equipe Formação Acadêmica: Mestrado em Ciência da Computação, Universidade XYZ, Concluído em 2020 Experiência Profissional: Desenvolvedor Sênior em empresa de tecnologia por 6 anos Habilidades: Experiente em linguagens de programação como Java, Python, e Ruby Domínio avançado em arquitetura de software e design de sistemas Excelente habilidade em liderança, comunicação e resolução de problemas Idiomas: Português (nativo), Inglês (fluente) Referências: Fornecidas mediante solicitação");
        CurriculosNota.Add(10);
        #endregion
        
    }

    // Métodos
    public string GetNomePessoa()
    {
        return pessoa.GetNome();
    }
    public string GetCargo()
    {
        return cargo;
    }
    public string GetDetalhes()
    {
        return detalhes;
    }
    public string GetCurriculo(){
        numRandom = random.Next(0,10);
        return Curriculos[numRandom];
    }
    public int GetNota(){
        return CurriculosNota[numRandom];
    }
}
