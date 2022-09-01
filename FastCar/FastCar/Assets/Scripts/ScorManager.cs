using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorManager : MonoBehaviour
{
    public Text SkorTxt;
    public static float skor;
    void Start()
    {
        skor = 0;
    }


    void Update()
    {
        SkorTxt.text = skor.ToString();
    }
}
