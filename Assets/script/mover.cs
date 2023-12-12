using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public GameObject[] omg;

    // Start is called before the first frame update
    void Start()
    {
        GameObject child1 = transform.Find("1").gameObject;
        GameObject child2 = transform.Find("2").gameObject;
        GameObject child3 = transform.Find("3").gameObject;
        GameObject child4 = transform.Find("4").gameObject;
        GameObject child5 = transform.Find("5").gameObject;
        GameObject child6 = transform.Find("6").gameObject;
        GameObject suim = Instantiate(omg[ruret.list[0]], child1.transform.position, Quaternion.identity);
        suim.transform.parent = child1.transform;
        suim = Instantiate(omg[ruret.list[1]], child2.transform.position, Quaternion.identity);
        suim.transform.parent = child2.transform;
        suim = Instantiate(omg[ruret.list[2]], child3.transform.position, Quaternion.identity);
        suim.transform.parent = child3.transform;
        suim = Instantiate(omg[ruret.list[3]], child4.transform.position, Quaternion.identity);
        suim.transform.parent = child4.transform;
        suim = Instantiate(omg[ruret.list[4]], child5.transform.position, Quaternion.identity);
        suim.transform.parent = child5.transform;
        suim = Instantiate(omg[ruret.list[5]], child6.transform.position, Quaternion.identity);
        suim.transform.parent = child6.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movero()
    {
    }
}
