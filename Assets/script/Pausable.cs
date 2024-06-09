using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

public class Pausable : MonoBehaviour
{ 
    public static bool existsInstance = false;
    public GameObject tobira;
    public GameObject WPS;
    public GameObject AHJ;
    public Animator anim;
    private bool ok;

    void Awake()
    {
        ok = true;
        anim = tobira.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        //  if (existsInstance)
        //   {
        //      Destroy(gameObject);
        //        return;
        //    }
        //    existsInstance = true;
        //    DontDestroyOnLoad(gameObject);



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            retry.men = true;
            existsInstance = false;
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("SampleScene");


        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            //SceneManager.LoadScene("jag", LoadSceneMode.Additive);
            if (ok == true)
            {
                if(jagr.owata == 3 || jagr.owata == 0)
                {
                    StartCoroutine("jagg");
                }
               
            }

            //Destroy(gameObject);

        }
       
    }

    public void jaggB()
    {
        if (ok == true)
        {
            if (jagr.owata == 3 || jagr.owata == 0)
            {
                StartCoroutine("jagg");
            }

        }
    }

    public void ret()
    {
        retry.men = true;
        existsInstance = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator jagg()
    {
        ok = false;
        Time.timeScale = 0;
        tobira.SetActive(true);
        float time = 1.5f;
        while (time > 0)
        {
            time -= Time.unscaledDeltaTime;
            yield return null;
        }
        AHJ.SetActive(!AHJ.activeSelf);
        WPS.SetActive(!WPS.activeSelf);
        Debug.Log("ｘｆｒｃ");
        anim.SetTrigger("open");
        time = 3f;
        while (time > 0)
        {
            time -= Time.unscaledDeltaTime;
            yield return null;
        }
        ok = true;
        tobira.SetActive(false);
        Time.timeScale = 1;
        // yield break;

        // Debug.Log("ｘｆｒｃ");
        //シーンを非同期で追加する
        // SceneManager.LoadScene("jag", LoadSceneMode.Additive);
        //シーン名を指定する
        //  Scene scene = SceneManager.GetSceneByName("jag");
        //  while (!scene.isLoaded)
        //  {
        //      yield return null;
        //  }
        //指定したシーン名をアクティブにする
        //  SceneManager.SetActiveScene(scene);
        //SceneManager.UnloadSceneAsync("SampleScene");
    }

}

