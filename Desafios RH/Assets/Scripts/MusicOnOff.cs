using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
public class MusicOnOff : MonoBehaviour
{
    public Toggle toggle;
    string Music = "Music.txt";
    bool sws;
    // Start is called before the first frame update
    void Start()
    {
        toggle.GetComponent<Toggle>();
    }

    // Update is called once per frame
     void Update(){
        OnOff();
    }

    public void OnOff(){
        if (sws != toggle.isOn){
            if(toggle.isOn == true){
                using(StreamWriter sw = new StreamWriter(Music)){
                    sw.WriteLine("true");
                }
            Debug.Log("Ligado");
            sws = true;
            }else{
                using(StreamWriter sw = new StreamWriter(Music)){
                    sw.WriteLine("false");
                }
                Debug.Log("desligado");
                sws = false;
            }
        }
    }
}
