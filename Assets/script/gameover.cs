using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public static Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void over()
    {
        //gameObject.GetComponent<Image>().color = color;
        anim.SetTrigger("OVER");
    }
}
