using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mix : MonoBehaviour
{
   
    public GameObject fe;
    public GameObject me;
    public GameObject supa;
    public GameObject effct;
    public bool maji;
    Spown spown;
    public int ookisa;
    public AudioClip kiran;
    public GameObject spa;
    AudioSource audioSource;

    // public int ookisa;

    // Start is called before the first frame update
    void Start()
    {
        maji = true;
        spown = GameObject.Find("frhi").GetComponent<Spown>();




    }

    // Update is called once per frame
    void Update()
    {

        


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Spown spown;
        spown = GameObject.Find("frhi").GetComponent<Spown>();
        if (collision.gameObject.tag == this.tag)
        {
            if(fe == null)
            {
                
                Destroy(gameObject);

            }
            else
            {
                gameObject.layer = 8;
                Vector2 center = (collision.gameObject.transform.position + gameObject.transform.position) * 0.5f;
                ookisa = int.Parse(collision.gameObject.name);

                if (int.Parse(collision.gameObject.name) < int.Parse(this.gameObject.name))
                {
                    if (maji == true)
                    {
                        maji = false;
                        Vector2 cho = new Vector2(center.x, center.y);
                        string tagname = fe.gameObject.tag;
                        mixsc(tagname);
                        Debug.Log("WTF????");
                        GameObject sui = Instantiate(fe, cho, Quaternion.identity);
                        Destroy(sui.gameObject.transform.GetComponent<Yugo>());
                        fe = null;
                        spown.number++;
                        sui.name = spown.number.ToString();
                        GameObject oni = Instantiate(effct, cho, Quaternion.identity);
                        audioSource = sui.GetComponent<AudioSource>();
                        audioSource.PlayOneShot(kiran);
                        Debug.Log("よっしゃーーーーーーー" + this.gameObject.name);
                        GameObject mos = GameObject.Find("NEMPR");
                        sui.transform.parent = mos.transform;
                        Destroy(gameObject);
                      
                    }
                }
                else
                {
                    //GameObject mos = GameObject.Find("NEMPR");
                   // this.transform.parent = mos.transform;
                    Debug.Log("まけたーー" + this.gameObject.name);
                    Destroy(gameObject);
                }
            }
            

        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
      //  maji = true;
        Debug.Log(maji);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "knife")
        {
            GameObject oni = Instantiate(supa, transform.position, Quaternion.identity);
            GameObject ongi = Instantiate(spa, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void mixsc(string am)
    {
        int number = score.scoren;

        if (am == "che")
        {
            number += 0;
        }
        else if(am == "ich")
        {
            number += 1;
            knifekaisuu.kt += 1;
        }
        else if (am == "gre")
        {
            number += 3;
            knifekaisuu.kt += 3;
        }
        else if (am == "dec")
        {
            number += 6;
            knifekaisuu.kt += 6;
        }
        else if (am == "kak")
        {
            number += 10;
            knifekaisuu.kt += 10;
        }
        else if (am == "app")
        {
            number += 15;
            knifekaisuu.kt += 15;
        }
        else if (am == "nas")
        {
            number += 21;
            knifekaisuu.kt += 21;
        }
        else if (am == "pea")
        {
            number += 28;
            knifekaisuu.kt += 28;
        }
        else if (am == "pin")
        {
            number += 36;
            knifekaisuu.kt += 36;
        }
        else if (am == "mel")
        {
            number += 45;
            knifekaisuu.kt += 45;
        }
        else if (am == "wat")
        {
            number += 55;
            knifekaisuu.kt += 55;
        }
        else 
        {

        }
        score.scoren = number;
        if (knifekaisuu.kt > 4000)
      {
            knifekaisuu.kt = 3999;
         //knifekaisuu.naif = (int)Mathf.Floor(knifekaisuu.kt / 100);
      }
        // if ()
        //  if(knifekaisuu.naif = 0)
        //  {
        //     kt = 0;
        // }
        // knifekaisuu.kt = score.scoren;
        knifekaisuu.naif = (int)Mathf.Floor(knifekaisuu.kt / 1000);
    }
}
