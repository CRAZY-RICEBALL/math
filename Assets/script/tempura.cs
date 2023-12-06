using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempura : MonoBehaviour
{
    private Vector2 mou;
    private Vector2 tar;
    public GameObject mu;
    public float taka;
    public float off;
    public static float max2;
    public static float min2;

    // Start is called before the first frame update
    void Start()
    {
        Nexxt nexxt;
        nexxt = mu.GetComponent<Nexxt>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            Nexxt nexxt;
            nexxt = mu.GetComponent<Nexxt>();
            mou = Input.mousePosition;
            tar = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector2(tar.x + off, taka);
            this.transform.position = new Vector2(Mathf.Clamp(tar.x, min2, max2) + off, taka);

            if (nexxt.nex == 0)
            {
                min2 = -18.3f;
                max2 = 22.5f;
            }
            if (nexxt.nex == 1)
            {
                min2 = -17.9f;
                max2 = 22.1f;
            }
            if (nexxt.nex == 2)
            {
                min2 = -17.8f;
                max2 = 21.8f;
            }
            if (nexxt.nex == 3)
            {
                min2 = -16.4f;
                max2 = 21f;
            }
            if (nexxt.nex == 4)
            {
                min2 = -15.3f;
                max2 = 19.3f;
            }
        }
       

    }
}
