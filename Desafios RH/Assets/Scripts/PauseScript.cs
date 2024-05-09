using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Game;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            Debug.Log("Pausado");
            Pause();
        }
    }
    public void Pause(){
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Menu Pausado");
        Game.SetActive(false);
    }
    public void Continue(){
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Menu Despausado");
        Game.SetActive(true);
    }
    public void SairJogo()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }
}
