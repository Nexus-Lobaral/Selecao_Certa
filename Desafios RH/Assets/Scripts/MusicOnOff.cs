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
    public AudioSource audio;
    bool sws;
    public Slider controleVolume;
    // Start is called before the first frame update
    void Start()
    {
        toggle.GetComponent<Toggle>();
        audio.GetComponent<AudioSource>();
        controleVolume.GetComponent<Slider>();
    }

    // Update is called once per frame
     void Update(){
        OnOff();
    }

    public void OnOff(){
        audio.volume = controleVolume.value;
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
        if(!sws == true){
            audio.mute = true;
        } else{
            audio.mute = false;
        }
    }
}
