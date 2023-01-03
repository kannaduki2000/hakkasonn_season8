using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text text_Timer;

    
    public static float time_Limit;

    
    //public static int item_Plus;

    // Start is called before the first frame update
    void Start()
    {
        text_Timer = GetComponent<Text>();
        time_Limit = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer_timer();
    }

    void timer_timer()
    {
        time_Limit -= Time.deltaTime;
        text_Timer.text = "Time : " + Mathf.Round(time_Limit);
    }
}
