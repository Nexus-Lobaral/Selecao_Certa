using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaveAndLoad : MonoBehaviour
{
    protected string Name;
    public int Contratados;

    public void SaveToJson(string name, int contratados){
        GuacamolJuegos data = new GuacamolJuegos();
        data.setEmpresa(name);
        data.setContratado(contratados);
        string json = JsonUtility.ToJson(data,true);
        File.WriteAllText(Application.dataPath + "/Save.json", json);
        
    }

    public void LoadFromJson(){
        string json = File.ReadAllText(Application.dataPath + "/Save.json");
        GuacamolJuegos data = JsonUtility.FromJson<GuacamolJuegos>(json);
        Name = data.name;
        Contratados = data.GetContratados();
    }

}