using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruret : MonoBehaviour
{
    public static bool ivent;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = GameObject.FindWithTag("探したいオブジェクトに設定されたタグ");
    }

    // Update is called once per frame
    void Update()
    {
       
     
      
    }

    public void areyouok()
    {
        ivent = true;
        Time.timeScale = 0;
        Debug.Log("ksiochdeuisd");
    }
    
}
