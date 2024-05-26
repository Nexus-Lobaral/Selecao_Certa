using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{   public string nomeJogador;
    
    [SerializeField] private string nomeCena;
    [SerializeField] private GameObject gameCena;
    [SerializeField] private GameObject pauseCena;
    public TMP_InputField userName;
    public Button button;
    private string origem = "NomePlayer.txt";
    private string destino = "NomePlayer.txt";

    private void Start(){
        Time.timeScale = 0; 
        Debug.Log("Menu de Nome saiu");
        gameCena.SetActive(true);
        pauseCena.SetActive(false);
    }


    public void Jogar()
    {
        SceneManager.LoadScene(nomeCena);
    }
    
    public void SairJogo()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
        
    }

    public void Pause(){
        if(!File.Exists(origem)){
            using(StreamWriter sw = new StreamWriter(origem)){};
        }else{
            using (StreamReader sr = new StreamReader(origem)){
                nomeJogador = sr.ReadLine();
            }
            if(nomeJogador == null){
                Time.timeScale = 0; 
                Debug.Log("Menu de Nome apareceu");
                gameCena.SetActive(false);
                pauseCena.SetActive(true);
            }else{
                Jogar();
            }
        };
    }
    public void buttonUsar(){
        nomeJogador = userName.text;
        SalvarJogador();  
        Debug.Log("nome do jogador: "+ NomeJogador());   
        Jogar();
    }
    public string NomeJogador(){
        return nomeJogador;
    }
    public void SalvarJogador(){
        // Escrita do nome do jogador no arquivo de destino
        using(StreamWriter sw = new StreamWriter(destino)){
                sw.WriteLine(nomeJogador);
        }
    }
    
}
