using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AudioManeger : MonoBehaviour
{
public AudioClip aah;  
public AudioClip crowdClapp;
public AudioClip buttonClick;
public AudioClip GameOver; 
 public AudioSource source;
 
 // Start is called before the first frame update
    void Start()
    {
        

    }
    public void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void click()
    {
         Debug.Log("aagaya");
        source.clip = buttonClick;

        
        source.Play();
    }
     public void blast()
    {
        source.clip = aah;
        
        source.Play();
    }
     public void clapp()
    {
         Debug.Log("aagaya");
        source.clip =crowdClapp;
        
        source.Play();
    }
     public void GmOver()
    {
        Debug.Log("aagaya");
        source.clip = GameOver;
        
        source.Play();
    }
}
