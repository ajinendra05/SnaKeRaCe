using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pointMove : MonoBehaviour
{   
     int currentLevel;
    float CnvsScale;
    public Transform tf;
    public bool bl;
    Vector2 vector2;
   public float speed;
   public Transform finaltf;
   private float _height;
  float RealSpeed;
   public GameObject caNvas;



    /*#region PROPERTIES
    public float Height {
        get {
            return _height;
        }
    }
    #endregion*/

    // Start is called before the first frame update
    void Start()
    {  bl =true;
        tf = transform;
        _height=caNvas.transform.localScale.y;
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
        
    
    //    _height=screen.Height;
       RealSpeed=(float)(_height*800/CnvsScale);
//vector2=  new Vector2(725,-9618);
//vector2=  new Vector2(tf.position.x,-9618);
//_height=screen.Height;
vector2=  new Vector2(tf.position.x,finaltf.position.y);
//vector2=  new Vector2(tf.position.x,tf.position.y-10910);
//Debug.log("a "+ tf.position.y.ToString());
//Debug.log("a" +(tf.position.y-10910).ToString());
//Debug.log("a"+finaltf.position.y.ToString());

       // tf.LeanMoveLocalY(-7050,30f);//.setEaseInQuart();
    }

    // Update is called once per frame
    void Update()
    {
        //tf.LeanMoveLocalY(-7050,10f).SetEaseOutQuart();
        if(PlayerPrefs.GetInt("spPoint")>=0)
        if(bl)
        {
        tf.position= Vector2.MoveTowards(tf.position,vector2,RealSpeed*Time.deltaTime);
        }
    }
}
