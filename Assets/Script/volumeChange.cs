using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeChange : MonoBehaviour
{
    [SerializeField] Slider vs;
    void Start()
    {
        load();
        
    }

    public void volumeChanger()
    {
        AudioListener.volume= vs.value;
        save();
        
    }
    public void mute()
    {
        AudioListener.volume= 0;
        save();
        
    }

    void save()
    {
        PlayerPrefs.SetFloat("musicvolume",vs.value);

    }

    void load()
    {
        vs.value=PlayerPrefs.GetFloat("musicvolume",1);
        AudioListener.volume=vs.value;
    }
}
