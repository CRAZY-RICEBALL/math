using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nempr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject mos = GameObject.Find("NEMPR");
        this.transform.parent = mos.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
