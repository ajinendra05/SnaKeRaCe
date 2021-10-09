using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class blink : MonoBehaviour
{
    RectTransform selfREct;
    // Start is called before the first frame update
    void Start()
    {
     selfREct=GetComponent<RectTransform>();
     InvokeRepeating("shake",0,1);
        
    }

    // Update is called once per frame
    void shake()
    {
        selfREct.DOPunchScale(Vector3.one*0.4f,0.12f,1,0.1f);
        
        
        
    }
}
