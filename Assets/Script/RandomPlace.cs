using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPlace : MonoBehaviour
{   
     int currentLevel;
    float CnvsScale;
    Transform EggTf;
    float x;
     float y;
    public float Xmin,Xmax;
    public float Ymin,Ymax;
     public GameObject canVas;
    float _height;
    float width;
    float posX,posY;
     
    // Start is called before the first frame update
    void Start()
    {  
        canVas=GameObject.FindWithTag("me");
        _height=canVas.transform.localScale.y;
        width=canVas.transform.localScale.x;
       y=Random.Range(Ymin,Ymax);
       x=Random.Range(Xmin,Xmax);
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        switch(currentLevel)
        {
            case 1 :
            CnvsScale=3.5902f;
            break;
             case 2 :
            CnvsScale=2.7712f;
            break;
             case 3 :
            CnvsScale=3.2933f;
            break;
             case 4 :
            CnvsScale=3.2933f;
            break; 
            case 5 :
            CnvsScale=3.2933f;
            break; 
            case 6 :
            CnvsScale=1.8f;
            break; 
            case 7 :
            CnvsScale=1.8f;
            break;
             case  8:
            CnvsScale=1.8f;
            break;
             case 9 :
            CnvsScale=1.8f;
            break;
             case 10 :
            CnvsScale=1.8f;
            break;


        }
        
    
       
        
        EggTf=transform;
        EggTf.position= new Vector3(x*width/CnvsScale,y*_height/CnvsScale,0);
    }

   
}
