using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Egg : MonoBehaviour
{  
    public Transform EggTf;
    public GameObject egg;
    public int EggPoint;
    public TMP_Text point;
    int tempCount;
    
    // Start is called before the first frame update
    void Start()
    {  
      
       
        egg= this.gameObject;
        EggTf=transform;
        
        
        EggPoint=Random.Range(1,5);
        point.text= EggPoint.ToString();
        
    }
    void OnCollisionEnter2D(Collision2D collision2D)
    {
      
      if(collision2D.collider.tag=="sp")
      {
        tempCount=PlayerPrefs.GetInt("spPoint",2);
        
        StartCoroutine(dstry());
        LeanTweenExt.LeanScale(egg,new Vector3(4,4,4),0.08f);
        PlayerPrefs.SetInt("spPoint",tempCount+EggPoint);
       
      }
    }
  
 

  public IEnumerator dstry()
  {
      yield return new WaitForSeconds(0.11f);
      Destroy(egg);
  }
}
