using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jagbotum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
       jagr. guruguru = true;
       jagr. guruguru2 = true;
       jagr. guruguru3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stop(int i)
    {
        if (i == 1)
        {
            jagr.guruguru = false;
        }
        if (i == 2)
        {
            jagr.guruguru2 = false;
        }
        if (i == 3)
        {
            jagr.guruguru3 = false;
        }
        if (i == 4)
        {
            jagr.guruguru = true;
            jagr.guruguru2 = true;
            jagr.guruguru3 = true;
        }

    }
}
