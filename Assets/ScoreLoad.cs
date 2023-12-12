using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
public class ScoreLoad : MonoBehaviour
{
    public bool sce;
    public Text ScoreeText1;
    public Text ScoreeText2;
    public Text ScoreeText3;
    public Text ScoreeText11;
    public Text ScoreeText22;
    public Text ScoreeText33;
    public string s1;
    public string s2;
    public string s3;

    void Start()
    {
        sce = true;
        LoadScore();
    }

    void Update()
    {
       
    }
    public void LoadScore()
    {
       
            int rank;
            NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("ScoreClass");
            query.OrderByDescending("score");
            query.Limit = 3;
            query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
            {
                if (e != null)
                {
                    Debug.LogWarning("error: " + e.ErrorMessage);
                }
                else
                {
                    for (int i = 0; i < objList.Count; i++)
                    {
                        rank = i + 1;
                        Debug.Log("ScoreRanking " + rank + "位: " + objList[i]["score"]);
                        
                    }
                  
                    ScoreeText1.text = $"1位：{objList[0]["score"]}";
                    ScoreeText2.text = $"2位：{ objList[1]["score"]}";
                    ScoreeText3.text = $"3位：{ objList[2]["score"]}";
                    ScoreeText11.text = $"1位：{objList[0]["score"]}";
                    ScoreeText22.text = $"2位：{ objList[1]["score"]}";
                    ScoreeText33.text = $"3位：{ objList[2]["score"]}";
                }
            });
        
    }
}
