using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nexxt : MonoBehaviour
{
    public int nex;
    public int max;
    public int nexp;
    public GameObject ti;
    public GameObject tempr;
    public GameObject[] kao2;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        nex = Random.Range(0, max);

        key();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void key()
    {
        Spown spown;
        spown = ti.GetComponent<Spown>();
        GameObject cd = transform.GetChild(0).gameObject;
        Destroy(cd);
        spown.Tugi(nex);
        
        GameObject suim = Instantiate(kao2[nexp], transform.position, Quaternion.identity);
        suim.transform.parent = this.transform;
        var rb = suim.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        //var col = suim.GetComponent<Collider2D>();
        //var col2 = suim.GetComponent<Collider2D>();
        //col.isTrigger = true;
        //col2.isTrigger = true;

        //key(nexp);


    }

    
}
