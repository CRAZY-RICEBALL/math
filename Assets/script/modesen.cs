using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class modesen : MonoBehaviour
{
    public Text text;
    public static int modem;
    // Start is called before the first frame update
    void Start()
    {
        //ノーマルモード
        modem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modesentaku()
    {

        if (modem == 0)
        {

            gameObject.GetComponent<Image>().color = new Color32(0, 90, 255, 119);
            // text = text.GetComponent<Text>();
            text.text = "イージーモード";
            modem = 1;
        }
        else if (modem == 1)
        {

            gameObject.GetComponent<Image>().color = new Color32(255, 10, 0, 119);
            // text = text.GetComponent<Text>();
            text.text = "開発中";
            modem = 2;

        }
        else if (modem == 2)
        {

            gameObject.GetComponent<Image>().color = new Color32(255, 255, 0, 119);
            // text = text.GetComponent<Text>();
            text.text = "開発中";
            modem = 3;
        }
        else if (modem == 3)
        {

            gameObject.GetComponent<Image>().color = new Color32(96, 255, 0, 119);
            // text = text.GetComponent<Text>();
            text.text = "ノーマルモード";
            modem = 0;
        }
      
    }
}
