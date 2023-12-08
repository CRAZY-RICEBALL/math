using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamewe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.transform.position.y >= 28)
        {
            Debug.Log("ゲームオーバー");
            Time.timeScale = 0;
            gameover.over();

        }
    }
}
