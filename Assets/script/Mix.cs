using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mix : MonoBehaviour
{
   
    public GameObject fe;
    public GameObject effct;
    public bool maji;
    Spown spown;
    public int ookisa;
    public AudioClip kiran;
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
                       
                        Destroy(gameObject);
                      
                    }
                }
                else
                {
                   
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
        }
        else if (am == "gre")
        {
            number += 3;
        }
        else if (am == "dec")
        {
            number += 6;
        }
        else if (am == "kak")
        {
            number += 10;
        }
        else if (am == "app")
        {
            number += 15;
        }
        else if (am == "nas")
        {
            number += 21;
        }
        else if (am == "pea")
        {
            number += 28;
        }
        else if (am == "pin")
        {
            number += 36;
        }
        else if (am == "mel")
        {
            number += 45;
        }
        else if (am == "wat")
        {
            number += 55;
        }
        else 
        {

        }
        score.scoren = number;
    }
}
