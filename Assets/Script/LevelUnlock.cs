using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{

    int levelUnlocked;
    public Button[] lvl;

   
    void Start()
    {
       levelUnlocked = PlayerPrefs.GetInt("levelUnlocked",1);

       for(int i=0;i<lvl.Length;i++)
       {
           lvl[i].interactable=false;
       }

       for(int i=0;i<levelUnlocked;i++)
       {
           lvl[i].interactable=true;
       }
        
    }

    
    
}
