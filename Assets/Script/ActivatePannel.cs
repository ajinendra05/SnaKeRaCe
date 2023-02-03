//Try to change something3

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActivatePannel : MonoBehaviour
{
     public GameObject pannel;
     public AudioManeger audioManeger;
     
  //  public GameObject Currentpannel;
    public int SpPoint;
    int index;
    int flag;
    // Start is called before the first frame update
    void Start()
    {
      flag=0;
    }


    // Update is called once per frame
    void Update()
    {
      if(flag==0)
        if(PlayerPrefs.GetInt("spPoint")<=0)
        { 
           flag++;
            GameOverS();
            Debug.Log("yahihu2"); 
            audioManeger.GmOver();
             Debug.Log("yahihu");

        }
    }
    public void GameOverS()
    {
       
        pannel.SetActive(true);
      //  gameObject.SetActive(true);
                 //   Currentpannel.SetActive(false) ;
    }
    public void restart()
    {
        index= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);

    }
}

