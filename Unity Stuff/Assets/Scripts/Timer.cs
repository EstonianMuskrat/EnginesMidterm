using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text runTimer;
    private float milliseconds, seconds, minutes;

    void start()
    {
        runTimer = GetComponent<Text>() as Text;
    }

    void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        milliseconds = (int)(Time.time * 1000f) % 1000f;

        //update the label value
        runTimer.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }
}