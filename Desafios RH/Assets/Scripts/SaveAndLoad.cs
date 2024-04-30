using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaveAndLoad
{
    private Empresas empresa; // empresa a qual sera salvada
    public SaveAndLoad(Empresas empresa)
    {
        this.empresa = empresa; // transforma o objeto empresa do codigo em empresa solicitada na hora de chamar o metodo
    }

    public void SaveToJson(/*int contratados*/) // Metodo de salvar
    {
        // empresa.SetContratados(contratados);
        string json = JsonUtility.ToJson(empresa,true); // transforma toda a classe empresa em string Json
        File.WriteAllText(Application.dataPath + "/Save.json", json); // escreve todo json criado dentro de um arquivo json
        
    }

    public void LoadFromJson() // Metodo de load
    {
        if (File.Exists(Application.dataPath + "/Save.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/Save.json"); // Lê tudo do arquivo Json
            JsonUtility.FromJsonOverwrite(json, empresa); // Carrega os dados diretamente na instância existente
            // GuacamolJuegos data = JsonUtility.FromJson<GuacamolJuegos>(json);
            // empresa.SetContratados(empresa.GetContratados()); 
        }

    }

}