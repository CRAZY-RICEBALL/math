using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startname : MonoBehaviour
{
    public InputField inputField;
    public Text text;
    public static string namedd;
    

    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputTexts()
    {

        namedd = inputField.text;
        Debug.Log(namedd);

    }

    public void startgame()
    {
       // if(namedd != null)
     //   {
          //  SceneManager.LoadScene("SampleScene");
      //  }

        if(modesen.modem == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }else if(modesen.modem == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (modesen.modem == 2)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (modesen.modem == 3)
        {
            SceneManager.LoadScene("SampleScene");
        }


    }
}
