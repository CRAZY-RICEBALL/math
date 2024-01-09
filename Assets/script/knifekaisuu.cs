using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class knifekaisuu : MonoBehaviour
{
    public static int naif;
    public static int kt;
    public Text ScoreText2;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //naif = 0;
        //kt = score.scoren;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"x{naif.ToString()}";
        ScoreText2.text = $"x{kt.ToString()}";

        //  if (kt >= 100 && kt < 200)
        //  {
        //      naif = 1;

        //       //score.scoren = score.scoren - 100;
        //  }else
        //    if (kt >= 200 && kt < 300)
        //  {
        //       naif = 2;
        //score.scoren = score.scoren - 100;
        //     }
        //  else
        //   if (kt >= 300 )
        //  {
        //      naif = 3;
        //score.scoren = score.scoren - 100;
        //   }


    }
}
