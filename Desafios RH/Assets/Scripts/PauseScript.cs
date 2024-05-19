 using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject gameCena;
    [SerializeField] private GameObject pauseCena;
    [SerializeField] private string nextCena;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && gameCena != null)
        {
            if (gameCena.activeSelf)
            {
                Pause();
            }
            else
            {
                Continue();
            }
        }
    }
    public void Pause(){
        Time.timeScale = 0; // oq isso faz? e praq?
        Debug.Log("Menu Pausado");
        gameCena.SetActive(false);
        pauseCena.SetActive(true);
    }
    public void Continue(){
        Time.timeScale = 1; // ...
        Debug.Log("Menu Despausado");
        gameCena.SetActive(true);
        pauseCena.SetActive(false);
    }
    public void SairJogo()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(nextCena);
    }
}
