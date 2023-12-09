using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect : MonoBehaviour
{
    private float s;
    public float maxs;
    public float cansu;
    private float v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v += Time.deltaTime * cansu;
        s = 1 + v;
        s = Mathf.Clamp(s, 0.5f, maxs);
        gameObject.transform.localScale = new Vector2(s, s);
        if(s == maxs)
        {
            Destroy(gameObject);
        }
    }
}
