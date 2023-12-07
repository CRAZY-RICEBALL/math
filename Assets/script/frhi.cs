using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frhi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = GameObject.Find("Parent").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
