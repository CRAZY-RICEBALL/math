using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yugo : MonoBehaviour
{
    //public GameObject fe;
    //public GameObject ti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        Spown spown;
        spown = GameObject.Find("frhi").GetComponent<Spown>();
        gameObject.AddComponent<gamewe>();
        spown.no();
        
            Destroy(this.gameObject.transform.GetComponent<Yugo>());
           // Debug.Log("214212");
      

    }
}

