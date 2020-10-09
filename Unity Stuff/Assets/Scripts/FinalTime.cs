using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalTime : MonoBehaviour
{
    public Text finalTimer;
    private float milliseconds, seconds, minutes;

    void start()
    {
        finalTimer = GetComponent<Text>() as Text;
    }

    void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        milliseconds = (int)(Time.time * 1000f) % 1000f;

        //update the label value
        finalTimer.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("End Scene"))
        {
            Time.timeScale = 0;
        }
    }
}