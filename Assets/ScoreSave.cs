using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class ScoreSave : MonoBehaviour
{
    public bool sc;

    void Start()
    {
        sc = true;
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            SaveScore();
        }
       
    }
    public void SaveScore()
    {
        if (Time.timeScale == 0)
        {
            if (sc == true)
            {
                sc = false;
                NCMBObject scoreClass = new NCMBObject("ScoreClass");
                scoreClass["score"] = score.scoren;
                scoreClass.SaveAsync((NCMBException e) =>
                {
                    if (e != null)
                    {
                        Debug.Log("Error: " + e.ErrorMessage);
                    }
                    else
                    {
                        Debug.Log("success");
                    }
                });
                NCMBObject name = new NCMBObject("WaterName");
                name["score2"] = startname.namedd;
                name.SaveAsync((NCMBException e) =>
                {
                    if (e != null)
                    {
                        Debug.Log("Error: " + e.ErrorMessage);
                    }
                    else
                    {
                        Debug.Log("success");
                    }
                });
            }
        }
    }
}