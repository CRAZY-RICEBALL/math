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
    private float max;
    private float min;

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
            this.transform.position = new Vector2(Mathf.Clamp(tar.x, min, max) + off, taka);

            if (nexxt.nex == 0)
            {
                min = -18.3f;
                max = 22.7f;
            }
            if (nexxt.nex == 1)
            {
                min = -17.9f;
                max = 22.1f;
            }
            if (nexxt.nex == 2)
            {
                min = -17.8f;
                max = 21.8f;
            }
            if (nexxt.nex == 3)
            {
                min = -16.4f;
                max = 21f;
            }
            if (nexxt.nex == 4)
            {
                min = -15.3f;
                max = 19.3f;
            }
        }
       

    }
}
