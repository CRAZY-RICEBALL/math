using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeotoshi : MonoBehaviour
{
    public GameObject nif;
    public GameObject knifes;
    public bool ok;
    // Start is called before the first frame update
    void Start()
    {
        //Tugi();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            if (Spown.knifetime ==true)
            {
                // if (ruret.ivent == false)
                //    {
                if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.O))
                {
                    if (Spown.ok == true)
                    {
                        if (ok == true)
                        {
                           
                                Cre();
                          



                            // audioSource = GetComponent<AudioSource>();
                            //audioSource.PlayOneShot(pon);
                        }
                    }

                }
                //  }
            }

        }

        if(kinifh.kok == true)
        {
            kmade();
        }
    }

    public void Tugi()
    {
        
        score.scoren += -1000;
        knifekaisuu.naif += -1;
       knifekaisuu.kt = knifekaisuu.naif * 1000;
       // knifekaisuu.kt = score.scoren;
        ok = true;
        GameObject sui = Instantiate(nif, transform.position, nif.transform.rotation);
        GameObject cd = sui.transform.GetChild(0).gameObject;
        cd.layer = 8;
        sui.transform.parent = this.transform;
        var rb = sui.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    public void Cre()
    {
        GameObject moss = GameObject.Find("NEMPR");
        ok = false;
        GameObject cd = transform.GetChild(0).gameObject;
        Destroy(cd);
        GameObject sui = Instantiate(nif, transform.position, nif.transform.rotation);
        var rb = sui.GetComponent<Rigidbody2D>();        
        rb.bodyType = RigidbodyType2D.Dynamic;
        sui.transform.parent = null;
        sui.transform.parent = moss.transform;
    }

    public void kmade()
    {
        
        kinifh.kok = false;
        knifes.gameObject.SetActive(true);
        Spown.knifetime = false;
        GetComponent<knifeotoshi>().enabled = false;
        knifes.GetComponent<Spown>().enabled = true;
        this.gameObject.SetActive(false);

    }

    public void kew()
    {
        if (Time.timeScale != 0)
        {
            if (Spown.knifetime == true)
            {
               
                    if (Spown.ok == true)
                    {
                        if (ok == true)
                        {

                            Cre();

                        }
                    }

                
                
            }


        }
    }
}


