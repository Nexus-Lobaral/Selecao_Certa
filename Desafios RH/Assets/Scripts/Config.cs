using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Config : MonoBehaviour
{   
    [SerializeField] private GameObject gameCena;
    [SerializeField] private GameObject pauseCena;
    
    void Start(){
        pauseCena.SetActive(false);

    }
    public void Hide(){
        Time.timeScale = 0; 
        Debug.Log("Menu de configurações Sumiu");
        gameCena.SetActive(true);
        pauseCena.SetActive(false);
    }
    public void Show(){
        Time.timeScale = 0; 
        Debug.Log("Menu de configurações apareceu");
        gameCena.SetActive(false);
        pauseCena.SetActive(true);
    }
}
