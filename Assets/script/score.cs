using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoren;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoren = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = scoren.ToString();
    }
}
