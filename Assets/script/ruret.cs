using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ruret : MonoBehaviour
{
    public Image fadePanel;          
    public float fadeDuration = 1.0f;
    public static bool ivent;
    public static List<int> list ;
    public GameObject tei;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = GameObject.FindWithTag("探したいオブジェクトに設定されたタグ");
    }

    // Update is called once per frame
    void Update()
    {

       

    }

    public void areyouok()
    {
        ivent = true;
        //Time.timeScale = 0;
        Debug.Log("ksiochdeuisd");
        game();
    }
    
    public void game()
    {
        
        list = new List<int>();
        GameObject go = GameObject.FindWithTag("che");
        if(go != null)
        {
            list.Add(0);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
        go = GameObject.FindWithTag("ich");
        if (go != null)
        {
            list.Add(1);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
        go = GameObject.FindWithTag("gre");
        if (go != null)
        {
            list.Add(2);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
        go = GameObject.FindWithTag("dec");
        if (go != null)
        {
            list.Add(3);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
        go = GameObject.FindWithTag("kak");
        if (go != null)
        {
            list.Add(4);
        }
        go = GameObject.FindWithTag("app");
        if (go != null)
        {
            list.Add(5);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
        
       // Debug.Log(list.Count);


        for (int i = list.Count -1 ; i < 6;)
            {
               list.Add(list[Random.Range(0, i)]);
               i++;
            
        }
       // Debug.Log(list.Count);


       
            Debug.Log(list[0]);
        Debug.Log(list[1]);
        Debug.Log(list[2]);
        Debug.Log(list[3]);
        Debug.Log(list[4]);
        Debug.Log(list[5]);
        StartCoroutine(FadeOutAndLoadScene());




    }

    public IEnumerator FadeOutAndLoadScene()
    {
        fadePanel.enabled = true;                
        float elapsedTime = 0.0f;               
        Color startColor = fadePanel.color;     
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); 

       
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  
            fadePanel.color = Color.Lerp(startColor, endColor, t); 
            yield return null;                                     
        }

        fadePanel.color = endColor;  
        SceneManager.LoadScene("ruret"); 
    }
}
