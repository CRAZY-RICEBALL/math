using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jagr : MonoBehaviour
{
    public static bool guruguru;
    public static bool guruguru2;
    public static bool guruguru3;
    public static int owata;
    public float Type;
    public float Speed;
    public GameObject My;
    public int nm;
    public GameObject momu;
    public bool ok;
    public bool os;
    float[] jza ={135.6f,124.3f, 113.0f, 101.7f, 90.4f, 79.1f, 67.8f, 56.5f, 45.2f, 33.9f, 22.6f, 11.3f, 0.0f,
                 -11.3f, -22.6f, -33.9f, -45.2f, -56.5f, -67.8f, -79.1f, -90.4f, -101.7f, -113.0f };
    int[] j1 = { 1, 2, 1, 3, 7, 2, 1, 2, 1, 4, 5, 1, 2, 1, 7, 6, 1, 2, 1, 5, 4, 1, 2, 1 };
    int[] j2 = { 3, 1, 5, 2, 7, 1, 5, 6, 2, 4, 1, 5, 2, 3, 1, 5, 2, 4, 1, 5, 2, 3, 1, 5 };
    int[] j3 = { 5, 3, 2, 1, 7, 4, 3, 2, 1, 6, 3, 2, 1, 6, 3, 2, 1, 6, 3, 2, 1, 5, 3, 2 };
    // Start is called before the first frame update
    void Start()
    {
        ok = true;
        os = true;
        // guruguru = true;
        // guruguru2 = true;
        // guruguru3 = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

         if(owata == 3 || owata == 0)
         {
           if (Input.GetKeyDown(KeyCode.Space))
            {


                owata = 0;
                os = true;
                ok = true;
                guruguru = true;
                guruguru2 = true;
                guruguru3 = true;
                Debug.Log(owata);


                // nm = 23;
            }
        }
       // if (guruguru == true)
       // {
            if (Input.GetKey(KeyCode.V) && Type == 1)
            {
                guruguru = false;
            }
            else
            if (Input.GetKey(KeyCode.B) && Type == 2)
            {
                guruguru2 = false;
            }
            else
            if (Input.GetKey(KeyCode.N) && Type == 3)
            {
                guruguru3 = false;
            }
            else
            if (guruguru == true && Type == 1)
            {
                mawaru1();
            }
        if (guruguru2 == true && Type == 2)
        {
            mawaru1();
        }
        if (guruguru3 == true && Type == 3)
        {
            mawaru1();
        }
        // }


     //   else

       if(guruguru == false && Type == 1)
        {
            Vector2 pose = transform.localPosition;
            pose.y = (nm - 12) * 11.62f + 5.81f;
            transform.localPosition = pose ;
            Debug.Log(j1[nm]);
            jagatari.jag1[0] = j1[nm-1];
            jagatari.jag1[1] = j1[nm];
            jagatari.jag1[2] = j1[nm+1];
            if (os == true)
            {
                owata++;
                os = false;
            }
            Debug.Log(owata);
          //  Debug.Log(jagatari.jag1[0]);
          //  Debug.Log(jagatari.jag1[1]);
          //  Debug.Log(jagatari.jag1[2]);


            //  Vector2 pos = transform.position;
            //   pos.y = nm * 11.3f;
            //   transform.localPosition = pos;

            // if(transform.localPosition.y <= 113 && transform.localPosition.y >= -113)
            //{
            //  for (int i = 0; i < jza.Length; i++)
            // {
            //     if (Mathf.Abs(jza[i] - (transform.localPosition.y * -1)) <= 5.65f)
            //     {
            //           Debug.Log(Mathf.Abs(jza[i] - (transform.localPosition.y * -1)));
            //            Vector2 pos = transform.position;
            //             pos.y = jza[i];
            //             transform.localPosition = pos;
            //          }
            //         else
            //         {
            //             Debug.Log("すみませんでした。");
            //           }
            //      }
            //   }

        }
        if (guruguru2 == false && Type == 2)
        {
            Vector2 pose = transform.localPosition;
            pose.y = (nm - 12) * 11.62f + 5.81f;
            transform.localPosition = pose;
           
            if (os == true)
            {
                owata++;
                os = false;
            }
            Debug.Log(owata);

        }
        if (guruguru3 == false && Type == 3)
        {
            Vector2 pose = transform.localPosition;
            pose.y = (nm - 12) * 11.62f + 5.81f;
            transform.localPosition = pose;
            
            if (os == true)
            {
                owata++;
                os = false;
            }
            Debug.Log(owata);

        }

    }

    public void mawaru1()
    {
        //if (guruguru == true && Type == 1)
        //{
            if (ok == true)
           {
               if (transform.localPosition.y <= -122.01 )//&& transform.localPosition.y <= 126.01)
               {
                    //ok = false;
                    Vector2 pose = transform.localPosition;
                    pose.y = 122.01f;
                    transform.localPosition = pose;
               // GameObject mos = GameObject.Find("ORE");
                //   Debug.Log("sqdfdf4rdtgfqdwsあすぇｄｒｆｇｔｈｙｊ");
                 //  GameObject sui = Instantiate(My, new Vector2(transform.position.x, 250.7f - Speed), Quaternion.identity);

                    //sui.transform.parent = mos.transform;
                  
                   
                   
               }

           }
          //  if (transform.position.y >= -270 && transform.position.y <= -250)
          //  {
           //     Destroy(gameObject);
         //   }

            Vector2 pos = transform.localPosition;
            pos.y -= Speed;
            transform.localPosition = pos;
       // if (Type == 1)
       // {
            nm = (int)Mathf.Round(transform.localPosition.y / 11.62f) + 12;
       //     Debug.Log(nm);
      // }
        // }


    }
    


    public void stop(int i)
    {
        if(i == 1 && Type == 1)
        {
            guruguru = false;
        }
        if (i == 2 && Type == 2)
        {
            guruguru2 = false;
        }
        if (i == 3 && Type == 3)
        {
            guruguru3 = false;
        }

    }

    

    
}
