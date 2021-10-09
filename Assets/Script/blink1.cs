using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class blink1 : MonoBehaviour
{
    RectTransform selfREct;
    // Start is called before the first frame update
    void Start()
    {
     selfREct=GetComponent<RectTransform>();
     InvokeRepeating("shake",0,1.5f);
        
    }

    // Update is called once per frame
    void shake()
    {
        selfREct.DOShakePosition(1,10,20,90,false,true);
        
    }
}
