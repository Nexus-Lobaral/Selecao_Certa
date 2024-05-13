 using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject gameCena;
    [SerializeField] private GameObject pauseCena;

    // [SerializeField] private string PauseCena;
    // [SerializeField] private string GameCena;

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (gameCena.activeSelf)
                {
                    Debug.Log("Pausado");
                    Pause();
                }
                else 
                {
                    Debug.Log("Despausar");
                    Continue();
                }
            }

    }
    public void Pause(){
        // SceneManager.LoadScene(PauseCena);
        Time.timeScale = 0; // oq isso faz? e praq?
        Debug.Log("Menu Pausado");
        gameCena.SetActive(false);
        pauseCena.SetActive(true);
    }
    public void Continue(){
        // SceneManager.LoadScene(GameCena);
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
}
