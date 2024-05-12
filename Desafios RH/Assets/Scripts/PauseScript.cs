 using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private string PauseCena;
    [SerializeField] private string GameCena;

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (SceneManager.GetActiveScene().name == GameCena)
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
        SceneManager.LoadScene(PauseCena);
        Time.timeScale = 0; // oq isso faz? e praq?
        Debug.Log("Menu Pausado");
        // Game.SetActive(false);
    }
    public void Continue(){
        SceneManager.LoadScene(GameCena);
        Time.timeScale = 1; // ...
        Debug.Log("Menu Despausado");
        // Game.SetActive(true);
    }
    public void SairJogo()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }
}
