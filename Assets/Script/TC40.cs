using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TC40 : MonoBehaviour
{
    public GameObject go;
int currentLevel;
    float CnvsScale;
        public ActivatePannel AP;
    public TMP_Text point;
    public int PointOnBox;
    public Transform boxtf;
    public int NowSpPoint;
    public pointMove ptmv;
    public SP SPBool;
    public GameObject pattern;
    bool checkCollision;
    float red, grren, blue, temp;
     public GameObject canVas;
    float _height;
    float width;
    float posX,posY;
    // Start is called before the first frame update
    void Start()
    {
        go = this.gameObject;
        boxtf = transform;
        canVas=GameObject.FindWithTag("me");
        _height=canVas.transform.localScale.y;
        width=canVas.transform.localScale.x;
        PointOnBox = Random.Range(36, 40);
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

        red = 1;
        grren = (float)(0.820 - (PointOnBox * 0.024));
        blue = 0;

        ptmv = GetComponentInParent<pointMove>();
        SPBool = GetComponentInParent<SP>();
        NowSpPoint = PlayerPrefs.GetInt("spPoint", 1);
        //PointOnBox=Random.Range(1,4);

        var img = go.GetComponent<Image>();
        img.color = new Color(red, grren, blue, 1f);




    }


    // Update is called once per frame
    void Update()
    {
        red = 1;
        grren = (float)(0.844 - (PointOnBox * 0.024));
        blue = 0;

        point.text = PointOnBox.ToString();
        var img = go.GetComponent<Image>();
        img.color = new Color(red, grren, blue, 1f);

    }
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        checkCollision = true;
        if (collision2D.collider.tag == "sp")
        {

            ptmv.bl = false;

            NowSpPoint = PlayerPrefs.GetInt("spPoint", 1);


            PlayerPrefs.SetInt("spPoint", --NowSpPoint);
            --PointOnBox;
            LeanTweenExt.LeanScale(go, new Vector2(1.08f, 1.08f), 0.2f).setEaseOutExpo();

            if (PointOnBox == 0)
            { posX= (float) (boxtf.position.x/width*CnvsScale);
                     posY= (float) (boxtf.position.y/_height*CnvsScale);
                Destroy(go);
                Instantiate(pattern,new Vector2(posX,posY), Quaternion.identity);
                ptmv.bl = true;

            }
            else if (NowSpPoint<= 0)
            {
                AP.GameOverS();

            }
            else
            {
                StartCoroutine(ruko2());

            }

        }

    }

    public IEnumerator ruko()
    {
        yield return new WaitForSeconds(0.0011f);

        PlayerPrefs.SetInt("spPoint", --NowSpPoint);
        --PointOnBox;
        LeanTweenExt.LeanScale(go, new Vector2(1.08f, 1.08f), 0.2f).setEaseOutExpo();

        if (PointOnBox == 0)
        {posX= (float) (boxtf.position.x/width*CnvsScale);
                     posY= (float) (boxtf.position.y/_height*CnvsScale);
            Destroy(go);
            Instantiate(pattern,new Vector2(posX,posY), Quaternion.identity);
            ptmv.bl = true;

        }
        else if (NowSpPoint <= 0)
        {

            AP.GameOverS();
        }
        else
        {
            StartCoroutine(ruko2());

        }

    }
    public IEnumerator ruko2()
    {
        yield return new WaitForSeconds(0.21f);


        LeanTweenExt.LeanScale(go, new Vector2(1f, 1f), 0.001f);
        if (checkCollision)
            StartCoroutine(ruko());


    }
    void OnCollisionExit2D(Collision2D collisionnninfo)
    {
        ptmv.bl = true;
        checkCollision = false;
    }
}
