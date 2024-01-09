using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinifh : MonoBehaviour
{
    public static bool kok;
    // Start is called before the first frame update
    void Start()
    {
        kok = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -56)
        {
            kok = true;
            Destroy(gameObject);
        }
    }
}
