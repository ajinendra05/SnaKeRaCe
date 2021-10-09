
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SP : MonoBehaviour
{
    int startPoint;
     public SP1 spScript;
    public TMP_Text pointShow;

    public Transform SPtf;
    public float speed;
    public bool bl2;
    public float SPspeed;
    public Transform final, head;
    private Camera cam;
    Vector2 temp, tempPressed, temp3;
    Vector3 vector3, vector32;
    bool left, right;
    Rigidbody2D rb;
    public GameObject[] Winpattern;
    // float rotation;
    public AudioManeger audioManeger;
    // Start is called before the first frame update
    void Start()
    {
        SPtf = transform;
        bl2 = true;
        startPoint = Random.Range(3, 7);

        PlayerPrefs.SetInt("spPoint", startPoint);
        pointShow.text = startPoint.ToString();
        cam = Camera.main;
        // SPtf.LeanMoveLocalY(-800,15f).setEaseOutExpo();
        rb = this.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {


        startPoint = PlayerPrefs.GetInt("spPoint", startPoint);
        pointShow.text = startPoint.ToString();
        if (spScript.bl2 == true)
        {
            if (PlayerPrefs.GetInt("spPoint") >= 0)
                SPtf.position = Vector2.MoveTowards(SPtf.position, new Vector3(SPtf.position.x, final.position.y, SPtf.position.z), SPspeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            temp = cam.ScreenToWorldPoint(Input.mousePosition);
            // tempPressed=Input.mousePosition;
            temp3 = temp;
        }

        if (Input.GetMouseButton(0))
        {
            tempPressed = cam.ScreenToWorldPoint(Input.mousePosition);
            // tempPressed=Input.mousePosition;
            if (temp3 != tempPressed)
            {
                if (right)
                {
                    if (tempPressed.x > temp.x)
                    {
                        slide();
                    }
                }
                else if (left)
                {
                    if (tempPressed.x < temp.x)
                    {
                        slide();
                    }
                }
                else
                {
                    slide();
                }


            }
            else
            {
                //SPtf.SetPositionAndRotation(SPtf.position, Quaternion.Euler(0, 0, 0));
                temp = cam.ScreenToWorldPoint(Input.mousePosition);
                // temp=Input.mousePosition;


            }

            temp3 = tempPressed;

        }
        /*

        if(Input.GetMouseButton(0))
        {
            rotation= Input.GetAxis("Horizontal");
            rotation = 25*rotation;
            SPtf.Rotate(0,0,rotation);

        }

        if (Input.GetMouseButtonUp(0))
        {
            SPtf.SetPositionAndRotation(SPtf.position, Quaternion.Euler(0, 0, 0));
        }

        if (SPtf.rotation.z > 25)
        {
            SPtf.SetPositionAndRotation(SPtf.position, Quaternion.Euler(0, 0, 25));
        }
        else if (SPtf.rotation.z < -25)
        {
            SPtf.SetPositionAndRotation(SPtf.position, Quaternion.Euler(0, 0, -25));
        }*/
    }
/*
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        bl2 = false;

        if (collision2D.collider.tag == "line")
        {
            if (collision2D.transform.position.x > SPtf.position.x)
                right = true;
            else if (collision2D.transform.position.x > SPtf.position.x)
                left = true;
            
            StartCoroutine(won());
             
            audioManeger.clapp();
            

        }

    }
    void OnCollisionExit2D(Collision2D collision2D)
    {
        bl2 = true;

        if (collision2D.collider.tag == "line")
        {
            if (collision2D.transform.position.x > SPtf.position.x)
                right = false;
            else if (collision2D.transform.position.x > SPtf.position.x)
                left = false;

        }
    }
*/
    void slide()
    {
        if (SPtf.position.x < 40)
        {
            SPtf.position = new Vector3(42, SPtf.position.y, SPtf.position.z);
        }
        else if (SPtf.position.x > 1400)
        {
            SPtf.position = new Vector3(1398, SPtf.position.y, SPtf.position.z);

        }
        else
        {
            // difference.position.x=tempPressed.position.x-temp.position.x;
            /* if (SPtf.rotation.z < 30 && SPtf.rotation.z > -30)
             {
                 vector32 = new Vector3(0, 0, (temp.x - tempPressed.x) / 70);
               //  SPtf.Rotate(vector32, Space.Self);
             }*/
            vector3 = new Vector3((tempPressed.x - temp.x) / 5, 0, 0);


            // SPtf.position = SPtf.position + vector3;
            // SPtf.position = new Vector3(head.position.x,SPtf.position.y,0);
            rb.MovePosition(new Vector2(SPtf.position.x + vector3.x, SPtf.position.y));
            rb.MovePosition(new Vector2(head.position.x, SPtf.position.y));

        }


    }
/*
    public IEnumerator won()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        Instantiate(Winpattern[0], new Vector3(672, 1639, 387.1176f), Quaternion.identity);
        Instantiate(Winpattern[0], new Vector3(1060, 1910, 387.1176f), Quaternion.identity);
        Instantiate(Winpattern[0], new Vector3(673, 826, 387.1176f), Quaternion.identity);
        Instantiate(Winpattern[0], new Vector3(287, 2026, 387.1176f), Quaternion.identity);
        Instantiate(Winpattern[0], new Vector3(641, 1203, 387.1176f), Quaternion.identity);
    }*/
}
